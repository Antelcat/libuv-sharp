using System.Runtime.InteropServices;
using LibuvSharp.Internal;

namespace LibuvSharp;

public abstract class BasePipeListener<TListener, TStream> : Listener<TStream>, ILocalAddress<string>, IBindable<TListener, string>
    where TStream : class, IUVStream<ArraySegment<byte>>
    where TListener : IListener<TStream>
{
    internal BasePipeListener(Loop loop, bool ipc)
        : base(loop, HandleType.UV_NAMED_PIPE, NativeMethods.uv_pipe_init, ipc ? 1 : 0)
    {
    }

    public void Bind(string name)
    {
        Ensure.ArgumentNotNull(name, nameof(name));
        Invoke(NativeMethods.uv_pipe_bind, name);
    }

    public string LocalAddress => UV.ToString(4096, (IntPtr buffer, ref IntPtr length) => NativeMethods.uv_pipe_getsockname(NativeHandle, buffer, ref length));
}

public class PipeListener(Loop loop) : BasePipeListener<PipeListener, Pipe>(loop, false)
{
    public PipeListener()
        : this(Loop.Constructor)
    {
    }

    protected override UVStream Create()
    {
        return new Pipe(Loop);
    }
}

public class IPCPipeListener(Loop loop) : BasePipeListener<IPCPipeListener, IPCPipe>(loop, true)
{
    public IPCPipeListener()
        : this(Loop.Constructor)
    {
    }

    protected override UVStream Create()
    {
        return new IPCPipe(Loop);
    }
}

public class Pipe : UVStream, IConnectable<Pipe, string>, IRemoteAddress<string>
{
    private readonly unsafe uv_pipe_t* pipe_t;

    public Pipe()
        : this(Loop.Constructor)
    {
    }

    public Pipe(Loop loop)
        : this(loop, false)
    {
    }

    internal unsafe Pipe(Loop loop, bool interProcessCommunication)
        : base(loop, HandleType.UV_NAMED_PIPE, NativeMethods.uv_pipe_init, interProcessCommunication ? 1 : 0)
    {
        pipe_t = (uv_pipe_t*)(NativeHandle.ToInt64() + Size(HandleType.UV_STREAM));
    }

    public unsafe bool InterProcessCommunication => pipe_t->rpc >= 1;

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    private static extern void uv_pipe_connect(IntPtr req, IntPtr handle, string name, callback connect_cb);

    public void Connect(string name, Action<Exception?>? callback)
    {
        CheckDisposed();

        Ensure.ArgumentNotNull(name, nameof(name));

        var  cpr  = new ConnectRequest();
        var pipe = this;

        cpr.Callback = (status, _) => Ensure.Success(status, callback, name);

        uv_pipe_connect(cpr.Handle, pipe.NativeHandle, name, CallbackPermaRequest.CallbackDelegate);
    }

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_pipe_getpeername(IntPtr handle, IntPtr buf, ref IntPtr len);

    public string RemoteAddress
    {
        get
        {
            CheckDisposed();

            return UV.ToString(4096, (IntPtr buffer, ref IntPtr length) => uv_pipe_getpeername(NativeHandle, buffer, ref length));
        }
    }
}

public class IPCPipe(Loop loop) : Pipe(loop, true)
{
    public IPCPipe() : this(Loop.Constructor)
    {
    }

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_write2(IntPtr req, IntPtr handle, uv_buf_t[] bufs, int bufcnt, IntPtr sendHandle, callback callback);

    public void Write(Handle handle, ArraySegment<byte> segment, Action<Exception?>? callback)
    {
        CheckDisposed();

        var datagchandle = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
        CallbackPermaRequest cpr = new(RequestType.UV_WRITE)
        {
            Callback = (status, _) =>
            {
                datagchandle.Free();
                Ensure.Success(status, callback);
            }
        };

        var ptr = (IntPtr)(datagchandle.AddrOfPinnedObject().ToInt64() + segment.Offset);

        var buf = new[] { new uv_buf_t(ptr, segment.Count) };
        var r   = uv_write2(cpr.Handle, NativeHandle, buf, 1, handle.NativeHandle, CallbackPermaRequest.CallbackDelegate);
        Ensure.Success(r);
    }

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_pipe_pending_count(IntPtr handle);

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    internal static extern HandleType uv_pipe_pending_type(IntPtr pipe);

    protected override void OnData(ArraySegment<byte> data)
    {
        var count = uv_pipe_pending_count(NativeHandle);
        if(count-- > 0)
        {
            var     type   = uv_pipe_pending_type(NativeHandle);
            Handle? handle = type switch
            {
                HandleType.UV_UDP        => new Udp(Loop),
                HandleType.UV_TCP        => new Tcp(Loop),
                HandleType.UV_NAMED_PIPE => new Pipe(Loop),
                _                        => null
            };
            if(handle != null)
            {
                Invoke(NativeMethods.uv_accept, handle.NativeHandle);
                OnHandleData(handle, data);
            }
        }
        base.OnData(data);
    }

    protected virtual void OnHandleData(Handle handle, ArraySegment<byte> data)
    {
        HandleData?.Invoke(handle, data);
    }

    public event Action<Handle, ArraySegment<byte>>? HandleData;
}
