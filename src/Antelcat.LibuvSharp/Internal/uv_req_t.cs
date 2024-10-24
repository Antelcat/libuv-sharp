using System.Runtime.InteropServices;

namespace Antelcat.LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal struct uv_req_t
{
    public IntPtr      data;
    public RequestType type;
}
