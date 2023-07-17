using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

public class Prepare : StartableCallbackHandle
{


	public Prepare()
		: this(Loop.Constructor)
	{
	}

	public Prepare(Loop loop)
		: base(loop, HandleType.UV_PREPARE, uv_prepare_init)
	{
	}

	public override void Start()
	{
		Invoke(uv_prepare_start);
	}

	public override void Stop()
	{
		Invoke(uv_prepare_stop);
	}
}