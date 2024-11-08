using System.Runtime.InteropServices;

namespace Antelcat.LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct uv_fs_t
{
    public int       fs_type;
    public IntPtr    loop;
    public IntPtr    cb;
    public IntPtr    result;
    public IntPtr    ptr;
    public sbyte*    path;
    public uv_stat_t buf;
}
