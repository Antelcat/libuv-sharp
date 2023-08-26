using static LibuvSharp.Libuv;

namespace LibuvSharp;

public class Idle : StartableCallbackHandle
{


	public Idle()
		: this(Loop.Constructor)
	{
	}

	public Idle(Loop loop)
		: base(loop, HandleType.UV_IDLE, uv_idle_init)
	{
	}

	public override void Start()
	{
		Invoke(uv_idle_start);
	}

	public override void Stop()
	{
		Invoke(uv_idle_stop);
	}
}