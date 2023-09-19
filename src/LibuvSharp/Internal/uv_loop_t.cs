using System.Runtime.InteropServices;

namespace LibuvSharp;

[StructLayout(LayoutKind.Sequential)]
internal struct uv_loop_t
{
	public IntPtr data;
	public uint active_handles;
}