using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

public abstract unsafe class UVStream
	: HandleBase, IUVStream<ArraySegment<byte>>, ITryWrite<ArraySegment<byte>>
{
	private uv_stream_t* stream;

	private long PendingWrites { get; set; }

	public long WriteQueueSize
	{
		get
		{
			CheckDisposed();

			return stream->write_queue_size.ToInt64();
		}
	}

	private ByteBufferAllocatorBase? allocator;

	public ByteBufferAllocatorBase? ByteBufferAllocator
	{
		get => allocator ?? Loop.ByteBufferAllocator;
		set => allocator = value;
	}

	internal UVStream(Loop loop, IntPtr handle)
		: base(loop, handle)
	{
		stream = (uv_stream_t*)(handle.ToInt64() + Size(HandleType.UV_HANDLE));
	}

	internal UVStream(Loop loop, int size)
		: this(loop, UV.Alloc(size))
	{
	}

	internal UVStream(Loop loop, HandleType type)
		: this(loop, Size(type))
	{
	}

	internal UVStream(Loop loop, HandleType type, Func<IntPtr, IntPtr, int> constructor)
		: this(loop, type)
	{
		Construct(constructor);
	}

	internal UVStream(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int, int> constructor, int arg1)
		: this(loop, handleType)
	{
		Construct(constructor, arg1);
	}

	internal UVStream(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int, int, int> constructor, int arg1,
		int arg2)
		: this(loop, handleType)
	{
		Construct(constructor, arg1, arg2);
	}

	public void Resume()
	{
		CheckDisposed();

		void Cb(IntPtr ptr, IntPtr size, uv_buf_t buf)
		{
			var stream = FromIntPtr<UVStream>(ptr);
			stream.Rcallback(ptr, size);
		}

		var r = uv_read_start(NativeHandle, ByteBufferAllocator.AllocCallback, Cb);
		r.Success();
	}

	public void Pause()
	{
		Invoke(uv_read_stop);
	}


	private void Rcallback(IntPtr _, IntPtr size)
	{
		var nread = size.ToInt64();
		switch (nread)
		{
			case 0:
				return;
			case < 0 when UVException.Map((int)nread) == UVErrorCode.EOF:
				Close(Complete);
				break;
			case < 0:
				OnError(Ensure.Map((int)nread));
				Close();
				break;
			default:
				OnData(ByteBufferAllocator.Retrieve(size.ToInt32()));
				break;
		}
	}

	protected virtual void OnComplete()
	{
		Complete?.Invoke();
	}

	public event Action Complete;

	protected virtual void OnError(Exception exception)
	{
		Error?.Invoke(exception);
	}

	public event Action<Exception> Error;

	protected virtual void OnData(ArraySegment<byte> data)
	{
		Data?.Invoke(data);
	}

	public event Action<ArraySegment<byte>> Data;

	private void OnDrain()
	{
		Drain?.Invoke();
	}

	public event Action Drain;

	public void Write(ArraySegment<byte> data, Action<Exception> callback)
	{
		CheckDisposed();

		var index = data.Offset;
		var count = data.Count;

		PendingWrites++;

		var datagchandle = GCHandle.Alloc(data.Array, GCHandleType.Pinned);
		var cpr          = new CallbackPermaRequest(RequestType.UV_WRITE);
		cpr.Callback = (status, cpr2) =>
		{
			datagchandle.Free();
			PendingWrites--;

			status.Success(callback);

			if (PendingWrites == 0)
			{
				OnDrain();
			}
		};

		var ptr = (IntPtr)(datagchandle.AddrOfPinnedObject().ToInt64() + index);

		var buf = new[] { new uv_buf_t(ptr, count) };
		var r   = uv_write(cpr.Handle, NativeHandle, buf, 1, CallbackPermaRequest.CallbackDelegate);
		r.Success();
	}

	public void Write(IList<ArraySegment<byte>> buffers, Action<Exception> callback)
	{
		CheckDisposed();

		PendingWrites++;

		int i;
		var n             = buffers.Count;
		var datagchandles = new GCHandle[n];
		var cpr           = new CallbackPermaRequest(RequestType.UV_WRITE);
		cpr.Callback = (status, cpr2) =>
		{
			for (i = 0; i < n; ++i)
				datagchandles[i].Free();

			PendingWrites--;

			status.Success(callback);

			if (PendingWrites == 0)
			{
				OnDrain();
			}
		};
		var bufs = new uv_buf_t[n];
		for (i = 0; i < n; ++i)
		{
			var data         = buffers[i];
			var index        = data.Offset;
			var count        = data.Count;
			var datagchandle = GCHandle.Alloc(data.Array, GCHandleType.Pinned);
			var ptr          = (IntPtr)(datagchandle.AddrOfPinnedObject().ToInt64() + index);
			bufs[i]          = new uv_buf_t(ptr, count);
			datagchandles[i] = datagchandle;
		}

		var r = uv_write(cpr.Handle, NativeHandle, bufs, n, CallbackPermaRequest.CallbackDelegate);
		r.Success();
	}

	public void Shutdown(Action<Exception>? callback)
	{
		CheckDisposed();

		var cbr = new CallbackPermaRequest(RequestType.UV_SHUTDOWN);
		cbr.Callback = (status, _) =>
		{
			status.Success(ex => Close(() =>
			{
				callback?.Invoke(ex);
			}));
		};
		uv_shutdown(cbr.Handle, NativeHandle, CallbackPermaRequest.CallbackDelegate);
	}

	internal bool readable;

	public bool Readable
	{
		get
		{
			CheckDisposed();

			return uv_is_readable(NativeHandle) != 0;
		}
		set => readable = value;
	}

	internal bool writeable;

	public bool Writeable
	{
		get
		{
			CheckDisposed();

			return uv_is_writable(NativeHandle) != 0;
		}
		set => writeable = value;
	}

	public int TryWrite(ArraySegment<byte> data)
	{
		CheckDisposed();

		data.Array.NotNull("data");

		fixed (byte* bytePtr = data.Array)
		{
			var ptr = (IntPtr)(bytePtr + data.Offset);
			var buf = new[] { new uv_buf_t(ptr, data.Count) };
			var r   = uv_try_write(NativeHandle, buf, 1);
			r.Success();
			return r;
		}
	}
}