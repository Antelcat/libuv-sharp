using System.Runtime.InteropServices;

namespace LibuvSharp
{
	public class LoopBackend
	{
		IntPtr nativeHandle;

		internal LoopBackend(Loop loop)
		{
			nativeHandle = loop.NativeHandle;
		}

		[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
		static extern int uv_backend_fd(IntPtr loop);

		public int FileDescriptor => uv_backend_fd(nativeHandle);

        [DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
		static extern int uv_backend_timeout(IntPtr loop);

		public int Timeout => uv_backend_timeout(nativeHandle);
    }
}

