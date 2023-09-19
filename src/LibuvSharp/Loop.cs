using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;
namespace LibuvSharp;

internal enum uv_run_mode
{
	UV_RUN_DEFAULT = 0,
	UV_RUN_ONCE,
	UV_RUN_NOWAIT
}

public partial class Loop : IDisposable
{
	private static Loop? @default;

	public static Loop Default => @default ??= new Loop(uv_default_loop(), new CopyingByteBufferAllocator());

	[ThreadStatic]
	private static Loop? currentLoop;

	public IntPtr NativeHandle { get; protected set; }

	public ByteBufferAllocatorBase? ByteBufferAllocator { get; protected set; }

	private readonly Async         async;
	private readonly AsyncCallback callback;

	internal Loop(IntPtr handle, ByteBufferAllocatorBase allocator)
	{
		NativeHandle = handle;
		ByteBufferAllocator = allocator;

		callback = new AsyncCallback(this);
		async = new Async(this);

		// this fixes a strange bug, where you can't send async
		// stuff from other threads
		Sync(() => { });
		async.Send();
		RunOnce();

		// ignore our allocated resources
		async.Unref();
		callback.Unref();
	}

	public Loop()
		: this(new CopyingByteBufferAllocator())
	{
	}

	public Loop(ByteBufferAllocatorBase allocator)
		: this(CreateLoop(), allocator)
	{
	}

	private static IntPtr CreateLoop()
	{
		var ptr = UV.Alloc(uv_loop_size().ToInt32());
		uv_loop_init(ptr).Success();
		return ptr;
	}

	private unsafe uv_loop_t* loop_t => (uv_loop_t*)NativeHandle;

	public unsafe uint ActiveHandlesCount => loop_t->active_handles;

	public unsafe IntPtr Data {
		get => loop_t->data;
		set => loop_t->data = value;
	}

	public bool IsRunning { get; private set; }

	private bool RunGuard(Action? action)
	{
		if (IsRunning) {
			return false;
		}

		// save the value, restore it aftwards
		var tmp = currentLoop;

		IsRunning = true;
		currentLoop = this;

		action?.Invoke();

		IsRunning = false;
		currentLoop = tmp;

		return true;
	}

	private bool RunGuard(Action context, Func<bool> func)
	{
		return RunGuard(context) && func();
	}

	public bool Run()
	{
		return RunGuard(() => uv_run(NativeHandle, uv_run_mode.UV_RUN_DEFAULT));
	}

	public bool Run(Action context)
	{
		return RunGuard(context, Run);
	}

	public bool RunOnce()
	{
		return RunGuard(() => uv_run(NativeHandle, uv_run_mode.UV_RUN_ONCE));
	}

	public bool RunOnce(Action context)
	{
		return RunGuard(context, RunOnce);
	}

	public bool RunAsync()
	{
		return RunGuard(() => uv_run(NativeHandle, uv_run_mode.UV_RUN_NOWAIT));
	}

	public bool RunAsync(Action context)
	{
		return RunGuard(context, RunAsync);
	}

	public void UpdateTime()
	{
		uv_update_time(NativeHandle);
	}

	public ulong Now => uv_now(NativeHandle);

	public void Sync(Action cb)
	{
		callback.Send(cb);
	}

	public void Sync(IEnumerable<Action> callbacks)
	{
		callback.Send(callbacks);
	}

	~Loop()
	{
		Dispose(false);
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		// close all active handles
		foreach (var kvp in handles) {
			var handle = kvp.Value;
			if (!handle.IsClosing) {
				handle.Dispose();
			}
		}

		// make sure the callbacks of close are called
		RunOnce();

		if (disposing) {
			if (ByteBufferAllocator != null) {
				ByteBufferAllocator.Dispose();
				ByteBufferAllocator = null;
			}
		}

		var r = uv_loop_close(NativeHandle);
		r.Success();
	}

	private static walk_cb walk_callback = WalkCallback;

	private static void WalkCallback(IntPtr handle, IntPtr arg)
	{
		var gchandle = GCHandle.FromIntPtr(arg);
		(gchandle.Target as Action<IntPtr>)?.Invoke(handle);
	}

	public void Walk(Action<IntPtr> cb)
	{
		var gcHandle = GCHandle.Alloc(cb, GCHandleType.Normal);
		uv_walk(NativeHandle, walk_callback, GCHandle.ToIntPtr(gcHandle));
		gcHandle.Free();
	}

	public IntPtr[] Handles {
		get {
			var list = new List<IntPtr>();
			Walk(handle => list.Add(handle));
			return list.ToArray();
		}
	}

	internal readonly Dictionary<IntPtr, Handle> handles = new();

	public Handle? GetHandle(IntPtr ptr)
	{
		return handles.TryGetValue(ptr, out var handle) ? handle : null;
	}

	public Handle?[] ActiveHandles {
		get {
			var tmp = Handles;
			var ret = new Handle?[tmp.Length];
			for (var i = 0; i < tmp.Length; i++) {
				ret[i] = GetHandle(tmp[i]);
			}
			return ret;
		}
	}

	public int RefCount { get; private set; }

	public void Ref() {
		if (RefCount == 0) {
			async.Ref();
		}
		RefCount++;
	}

	public void Unref() {
		if (RefCount <= 0) {
			return;
		}
		if (RefCount == 1) {
			async.Unref();
		}
		RefCount--;
	}

	private LoopBackend? loopBackend;
	public  LoopBackend  Backend => loopBackend ??= new LoopBackend(this);

	public void Stop()
	{
		uv_stop(NativeHandle);
	}
	
	public bool IsAlive => uv_loop_alive(NativeHandle) != 0;
}