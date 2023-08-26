using static LibuvSharp.Libuv;

namespace LibuvSharp;

public partial class HandleBase : ISendBufferSize, IReceiveBufferSize
{

	int Invoke(buffer_size_function function, int value)
	{
		CheckDisposed();

		var r = function(NativeHandle, out value);
		Ensure.Success(r);
		return r;
	}

	int Apply(buffer_size_function buffer_size, int value)
	{
		return Invoke(buffer_size, value);
	}

	public int SendBufferSize {
		get => Apply(uv_send_buffer_size, 0);
		set => Apply(uv_send_buffer_size, @value);
	}

	public int ReceiveBufferSize {
		get => Apply(uv_recv_buffer_size, 0);
		set => Apply(uv_recv_buffer_size, @value);
	}
}