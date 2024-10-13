using System.Runtime.InteropServices;

namespace LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct uv_dirent_t
{
    public sbyte*                name;
    public UVDirectoryEntityType type;
}
