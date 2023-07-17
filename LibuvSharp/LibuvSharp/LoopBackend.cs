using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

public class LoopBackend
{
	IntPtr nativeHandle;

	internal LoopBackend(Loop loop)
	{
		nativeHandle = loop.NativeHandle;
	}

	public int FileDescriptor => uv_backend_fd(nativeHandle);
	public int Timeout => uv_backend_timeout(nativeHandle);
}