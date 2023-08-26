using static LibuvSharp.Libuv;
namespace LibuvSharp;

public class Check : StartableCallbackHandle
{
	public Check()
		: this(Loop.Constructor)
	{
	}

	public Check(Loop loop)
		: base(loop, HandleType.UV_IDLE, uv_check_init)
	{
	}

	public override void Start()
	{
		Invoke(uv_check_start);
	}

	public override void Stop()
	{
		Invoke(uv_check_stop);
	}
}