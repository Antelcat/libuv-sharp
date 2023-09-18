using System.Runtime.InteropServices;

public partial class RTL_CONDITION_VARIABLE
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal IntPtr Ptr;
    }
}