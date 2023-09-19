using static LibuvSharp.Libuv;

namespace LibuvSharp;

public class LoopBackend
{
	private readonly IntPtr nativeHandle;

	internal LoopBackend(Loop loop)
	{
		nativeHandle = loop.NativeHandle;
	}

	public int FileDescriptor => uv_backend_fd(nativeHandle);
	public int Timeout => uv_backend_timeout(nativeHandle);
}