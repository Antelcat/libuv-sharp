using System.Runtime.InteropServices;

namespace LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal struct uv_req_t
{
    public IntPtr      data;
    public RequestType type;
}
