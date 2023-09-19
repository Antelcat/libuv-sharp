using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;
namespace LibuvSharp;

public class Udp : HandleBase, IMessageSender<UdpMessage>, IMessageReceiver<UdpReceiveMessage>, ITrySend<UdpMessage>, IBindable<Udp, IPEndPoint>
{
	private ByteBufferAllocatorBase? allocator;
	public ByteBufferAllocatorBase? ByteBufferAllocator {
		get => allocator ?? Loop.ByteBufferAllocator;
		set => allocator = value;
	}

	public Udp()
		: this(Loop.Constructor)
	{
	}

	public Udp(Loop loop)
		: base(loop, HandleType.UV_UDP, uv_udp_init)
	{
	}

	private void Bind(IPAddress ipAddress, int port, bool dualstack)
	{
		CheckDisposed();
		UV.Bind(this, uv_udp_bind, uv_udp_bind, ipAddress, port, dualstack);
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


	public void Send(UdpMessage message, Action<Exception> callback)
	{
		CheckDisposed();

		message.EndPoint.NotNull("message EndPoint");
		Ensure.AddressFamily(message.EndPoint.Address);

		var ipEndPoint = message.EndPoint;
		var data = message.Payload;

		var datagchandle = GCHandle.Alloc(data.Array, GCHandleType.Pinned);
		var cpr = new CallbackPermaRequest(RequestType.UV_UDP_SEND);
		cpr.Callback = (status, cpr2) => {
			datagchandle.Free();
			status.Success(callback);
		};

		var ptr = (IntPtr)(datagchandle.AddrOfPinnedObject().ToInt64() + data.Offset);

		int r;
		var buf = new[] { new uv_buf_t(ptr, data.Count) };

		if (ipEndPoint.Address.AddressFamily == AddressFamily.InterNetwork) {
			var address = UV.ToStruct(ipEndPoint.Address.ToString(), ipEndPoint.Port);
			r = uv_udp_send(cpr.Handle, NativeHandle, buf, 1, ref address, CallbackPermaRequest.CallbackDelegate);
		} else {
			var address = UV.ToStruct6(ipEndPoint.Address.ToString(), ipEndPoint.Port);
			r = uv_udp_send(cpr.Handle, NativeHandle, buf, 1, ref address, CallbackPermaRequest.CallbackDelegate);
		}
		r.Success();
	}

	private static recv_start_callback recv_start_cb = recv_callback;

	private static void recv_callback(IntPtr handlePointer, IntPtr nread, ref uv_buf_t buf, IntPtr sockaddr, ushort flags)
	{
		var handle = FromIntPtr<Udp>(handlePointer);
		handle.recv_callback(handlePointer, nread, sockaddr, flags);
	}

	private void recv_callback(IntPtr handle, IntPtr nread, IntPtr sockaddr, ushort flags)
	{
		var n = (int)nread;

		if (n == 0) {
			return;
		}

		if (Message == null) return;
		var ep = UV.GetIPEndPoint(sockaddr, true);

		var msg = new UdpReceiveMessage(
			ep,
			ByteBufferAllocator.Retrieve(n),
			(flags & (short)uv_udp_flags.UV_UDP_PARTIAL) > 0
		);

		Message?.Invoke(msg);
	}

	public void Resume()
	{
		CheckDisposed();

		var r = uv_udp_recv_start(NativeHandle, ByteBufferAllocator.AllocCallback, recv_start_cb);
		r.Success();
	}

	public void Pause()
	{
		Invoke(uv_udp_recv_stop);
	}

	public event Action<UdpReceiveMessage>? Message;

	public byte TTL {
		set => Invoke(uv_udp_set_ttl, (int)value);
	}
	
	public bool Broadcast {
		set => Invoke(uv_udp_set_broadcast, value ? 1 : 0);
	}

	public byte MulticastTTL {
		set => Invoke(uv_udp_set_multicast_ttl, (int)value);
	}

	public bool MulticastLoop {
		set => Invoke(uv_udp_set_multicast_loop, value ? 1 : 0);
	}
	
	public IPEndPoint LocalAddress {
		get {
			CheckDisposed();

			return UV.GetSockname(this, uv_udp_getsockname);
		}
	}

	public unsafe int TrySend(UdpMessage message)
	{
		message.NotNull(nameof(message));

		var data = message.Payload;
		var ipEndPoint = message.EndPoint;

		fixed (byte* bytePtr = data.Array) {
			var ptr = (IntPtr)(bytePtr + message.Payload.Offset);
			int r;
			var buf = new[] { new uv_buf_t(ptr, data.Count) };

			if (ipEndPoint.Address.AddressFamily == AddressFamily.InterNetwork) {
				var address = UV.ToStruct(ipEndPoint.Address.ToString(), ipEndPoint.Port);
				r = uv_udp_try_send(NativeHandle, buf, 1, ref address);
			} else {
				var address = UV.ToStruct6(ipEndPoint.Address.ToString(), ipEndPoint.Port);
				r = uv_udp_try_send(NativeHandle, buf, 1, ref address);
			}
			return r;
		}
	}
}