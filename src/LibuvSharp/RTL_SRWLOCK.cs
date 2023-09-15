using System.Runtime.InteropServices;

public unsafe partial class RTL_SRWLOCK
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public partial struct __Internal
    {
        internal IntPtr Ptr;
    }
}