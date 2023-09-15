using System.Runtime.InteropServices;

public unsafe partial class COORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal short X;
        internal short Y;
    }
}