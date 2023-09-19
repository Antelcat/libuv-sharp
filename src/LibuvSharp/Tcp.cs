using System.Net;
using System.Net.Sockets;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

public class TcpListener : Listener<Tcp>, IBindable<TcpListener, IPEndPoint>, ILocalAddress<IPEndPoint>
{
    public TcpListener()
        : this(Loop.Constructor)
    {
    }

    public TcpListener(Loop loop)
        : base(loop, HandleType.UV_TCP, uv_tcp_init)
    {
    }

    private void Bind(IPAddress ipAddress, int port, bool dualstack)
    {
        CheckDisposed();

        UV.Bind(this, uv_tcp_bind, uv_tcp_bind, ipAddress, port, dualstack);
    }

    public void Bind(int port)
    {
        Bind(IPAddress.IPv6Any, port, true);
    }

    public void Bind(IPEndPoint endPoint)
    {
        endPoint.NotNull(nameof(endPoint));
        Bind(endPoint.Address, endPoint.Port, false);
    }

    protected override UVStream Create()
    {
        return new Tcp(Loop);
    }

    public bool SimultaneosAccepts
    {
        set => Invoke(uv_tcp_simultaneos_accepts, value ? 1 : 0);
    }

    public IPEndPoint LocalAddress
    {
        get
        {
            CheckDisposed();
            return UV.GetSockname(this, uv_tcp_getsockname);
        }
    }
}

public class Tcp
    : UVStream, IConnectable<Tcp, IPEndPoint>, ILocalAddress<IPEndPoint>, IRemoteAddress<IPEndPoint>
{
    public Tcp() : this(Loop.Constructor)
    {
    }

    public Tcp(Loop loop) : base(loop, HandleType.UV_TCP, uv_tcp_init)
    {
    }

    public void Connect(IPEndPoint ipEndPoint, Action<Exception> callback)
    {
        CheckDisposed();

        ipEndPoint.NotNull(nameof(ipEndPoint));
        callback.NotNull(nameof(callback));
        Ensure.AddressFamily(ipEndPoint.Address);

        var cpr = new ConnectRequest();
        cpr.Callback = (status, cpr2) => status.Success(callback);

        int r;
        if (ipEndPoint.Address.AddressFamily == AddressFamily.InterNetwork)
        {
            var address = UV.ToStruct(ipEndPoint.Address.ToString(), ipEndPoint.Port);
            r = uv_tcp_connect(cpr.Handle, NativeHandle, ref address, CallbackPermaRequest.CallbackDelegate);
        }
        else
        {
            var address = UV.ToStruct6(ipEndPoint.Address.ToString(), ipEndPoint.Port);
            r = uv_tcp_connect(cpr.Handle, NativeHandle, ref address, CallbackPermaRequest.CallbackDelegate);
        }

        r.Success();
    }

    public bool NoDelay
    {
        set => Invoke(uv_tcp_nodelay, value ? 1 : 0);
    }

    public void SetKeepAlive(bool enable, int delay)
    {
        Invoke(uv_tcp_keepalive, enable ? 1 : 0, delay);
    }

    public IPEndPoint LocalAddress
    {
        get
        {
            CheckDisposed();

            return UV.GetSockname(this, uv_tcp_getsockname);
        }
    }

    public IPEndPoint RemoteAddress
    {
        get
        {
            CheckDisposed();
            return UV.GetSockname(this, uv_tcp_getpeername);
        }
    }
}