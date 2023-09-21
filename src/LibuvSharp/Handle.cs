using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

public abstract unsafe class Handle : IHandle, IDisposable
{
	public Loop Loop { get; protected set; }

	public IntPtr NativeHandle { get; private set; }

	internal GCHandle GCHandle { get; set; }

	private uv_handle_t * handle {
		get {
			CheckDisposed();
			return (uv_handle_t *)NativeHandle;
		}
	}

	internal IntPtr DataPointer {
		get => handle->data;
		set => handle->data = value;
	}

	internal static T FromIntPtr<T>(IntPtr ptr) => (T)GCHandle.FromIntPtr(((uv_handle_t*)ptr)->data).Target;

	public HandleType HandleType => handle->type;

	internal Handle(Loop loop, IntPtr handle)
	{
		loop.NotNull(nameof(loop));

		NativeHandle = handle;
		GCHandle = GCHandle.Alloc(this);
		Loop = loop;

		Loop.handles[NativeHandle] = this;

		DataPointer = GCHandle.ToIntPtr(GCHandle);
	}

	internal Handle(Loop loop, int size)
		: this(loop, UV.Alloc(size)) { }

	internal Handle(Loop loop, HandleType handleType)
		: this(loop, Size(handleType)) { }

	internal Handle(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int> constructor)
		: this(loop, handleType) => Construct(constructor);

	internal Handle(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int, int> constructor, int arg1)
		: this(loop, handleType) => Construct(constructor, arg1);

	internal void Construct(Func<IntPtr, IntPtr, int> constructor)
	{
		constructor(Loop.NativeHandle, NativeHandle).Success();
	}

	internal void Construct(Func<IntPtr, IntPtr, int, int> constructor, int arg1)
	{
		constructor(Loop.NativeHandle, NativeHandle, arg1).Success();
	}

	internal void Construct(Func<IntPtr, IntPtr, int, int, int> constructor, int arg1, int arg2)
	{
		constructor(Loop.NativeHandle, NativeHandle, arg1, arg2).Success();
	}

	public event Action? Closed;

	private Action? closeCallback;

	private static void CloseCallback(IntPtr handlePointer)
	{
		var pointer = FromIntPtr<Handle>(handlePointer);
		pointer.Cleanup(handlePointer, pointer.closeCallback);
	}

	public void Cleanup(IntPtr nativeHandle, Action? callback)
	{
		// Remove handle
		if (NativeHandle == IntPtr.Zero) return;
		Loop.handles.Remove(nativeHandle);

		UV.Free(nativeHandle);
		NativeHandle = IntPtr.Zero;
		Closed?.Invoke();
		callback?.Invoke();

		if (GCHandle.IsAllocated) GCHandle.Free();
	}

	public void Close(Action? callback)
	{
		if (IsClosing || IsClosed) return;
		closeCallback = callback;
		uv_close(NativeHandle, CloseCallback);
	}

	public void Close()
	{
		Close(null);
	}

	public bool IsClosed => NativeHandle == IntPtr.Zero;

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		Close();
	}

	public bool IsActive {
		get {
			if (IsClosed) {
				return false;
			}
			return uv_is_active(NativeHandle) != 0;
		}
	}
	
	public bool IsClosing {
		get {
			if (IsClosed) {
				return false;
			}
			return uv_is_closing(NativeHandle) != 0;
		}
	}

	/// <summary>
	/// Is the underlying still alive? Returns true if handle
	/// is not closing or closed.
	/// </summary>
	/// <value><c>true</c> if this instance is not closing or closed; otherwise, <c>false</c>.</value>
	public bool IsAlive => !IsClosed && !IsClosing;

	public void Ref()
	{
		if (IsClosed) {
			return;
		}
		uv_ref(NativeHandle);
	}

	public void Unref()
	{
		if (IsClosed) {
			return;
		}
		uv_unref(NativeHandle);
	}

	public bool HasRef {
		get {
			if (IsClosed) {
				return false;
			}
			return uv_has_ref(NativeHandle) != 0;
		}
	}

	
	public static int Size(HandleType type)
	{
		return uv_handle_size(type);
	}

	
	public static HandleType Guess(int fd)
	{
		return uv_guess_handle(fd);
	}

	protected void CheckDisposed()
	{
		if (NativeHandle == IntPtr.Zero)
		{
			throw new ObjectDisposedException(GetType().ToString(), "handle was closed");
		}
	}

	protected void Invoke(Func<IntPtr, int> function)
	{
		CheckDisposed();

		function(NativeHandle).Success();
	}

	protected void Invoke<T1>(Func<IntPtr, T1, int> function, T1 arg1)
	{
		CheckDisposed();

		function(NativeHandle, arg1).Success();
	}

	protected void Invoke<T1, T2>(Func<IntPtr, T1, T2, int> function, T1 arg1, T2 arg2)
	{
		CheckDisposed();

		function(NativeHandle, arg1, arg2).Success();
	}

	protected void Invoke<T1, T2, T3>(Func<IntPtr, T1, T2, T3, int> function, T1 arg1, T2 arg2, T3 arg3)
	{
		CheckDisposed();

		function(NativeHandle, arg1, arg2, arg3).Success();
	}
}