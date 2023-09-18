using System.Runtime.InteropServices;

public unsafe partial class WIN32FIND_DATAW
{
    [StructLayout(LayoutKind.Sequential, Size = 592)]
    public struct __Internal
    {
        internal       uint                dwFileAttributes;
        internal       FILETIME.__Internal ftCreationTime;
        internal       FILETIME.__Internal ftLastAccessTime;
        internal       FILETIME.__Internal ftLastWriteTime;
        internal       uint                nFileSizeHigh;
        internal       uint                nFileSizeLow;
        internal       uint                dwReserved0;
        internal       uint                dwReserved1;
        internal fixed char                cFileName[260];
        internal fixed char                cAlternateFileName[14];
    }
}