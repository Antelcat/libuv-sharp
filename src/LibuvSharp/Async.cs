using static LibuvSharp.Libuv;
namespace LibuvSharp;

public class Async : CallbackHandle
{
	
	public Async()
		: this(Loop.Constructor)
	{
	}

	public Async(Loop loop)
		: base(loop, HandleType.UV_ASYNC)
	{
		uv_async_init(loop.NativeHandle, NativeHandle, uv_callback).Success();
	}



	public void Send()
	{
		Invoke(uv_async_send);
	}
}