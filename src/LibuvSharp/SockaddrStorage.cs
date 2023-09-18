using System.Runtime.InteropServices;

public unsafe partial class SockaddrStorage
{
    [StructLayout(LayoutKind.Sequential, Size = 128)]
    public struct __Internal
    {
        internal       ushort ss_family;
        internal fixed sbyte  __ss_pad1[6];
        internal       long   __ss_align;
        internal fixed sbyte  __ss_pad2[112];
    }
}