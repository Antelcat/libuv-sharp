using System.Runtime.InteropServices;

public partial class COORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal short X;
        internal short Y;
    }
}