using System.Runtime.InteropServices;

namespace LibuvSharp;

internal static class NativeMethods
{

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_listen(IntPtr stream, int backlog, Handle.callback callback);

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_accept(IntPtr server, IntPtr client);

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_tcp_getsockname(IntPtr handle, IntPtr addr, ref int length);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void uv_fs_cb(IntPtr IntPtr);

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_pipe_init(IntPtr loop, IntPtr handle, int ipc);

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_pipe_bind(IntPtr handle, string name);

	[DllImport(libuv.Lib, CallingConvention = CallingConvention.Cdecl)]
	public static extern int uv_pipe_getsockname(IntPtr handle, IntPtr buf, ref IntPtr len);
}