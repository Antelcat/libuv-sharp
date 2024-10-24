using System.Runtime.InteropServices;

namespace Antelcat.LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal struct uv_loop_t
{
    public IntPtr data;
    public uint   active_handles;
}
