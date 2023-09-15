using System.Runtime.InteropServices;

public unsafe partial class WIN32FIND_DATAW
{
    [StructLayout(LayoutKind.Sequential, Size = 592)]
    public partial struct __Internal
    {
        internal       uint                        dwFileAttributes;
        internal       global::FILETIME.__Internal ftCreationTime;
        internal       global::FILETIME.__Internal ftLastAccessTime;
        internal       global::FILETIME.__Internal ftLastWriteTime;
        internal       uint                        nFileSizeHigh;
        internal       uint                        nFileSizeLow;
        internal       uint                        dwReserved0;
        internal       uint                        dwReserved1;
        internal fixed char                        cFileName[260];
        internal fixed char                        cAlternateFileName[14];
    }
}