using System.Runtime.InteropServices;

public unsafe partial class MOUSE_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal global::COORD.__Internal dwMousePosition;
        internal uint                     dwButtonState;
        internal uint                     dwControlKeyState;
        internal uint                     dwEventFlags;
    }
}