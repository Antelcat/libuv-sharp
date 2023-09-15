using System.Runtime.InteropServices;

public unsafe partial class WINDOW_BUFFER_SIZE_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal global::COORD.__Internal dwSize;
    }
}