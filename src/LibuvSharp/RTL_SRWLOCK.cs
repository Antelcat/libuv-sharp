using System.Runtime.InteropServices;

public partial class RTL_SRWLOCK
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal IntPtr Ptr;
    }
}