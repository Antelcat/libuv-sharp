using System.Runtime.InteropServices;

public partial class WINDOW_BUFFER_SIZE_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal COORD.__Internal dwSize;
    }
}