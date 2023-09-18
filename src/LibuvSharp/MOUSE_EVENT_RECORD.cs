using System.Runtime.InteropServices;

public partial class MOUSE_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal COORD.__Internal dwMousePosition;
        internal uint             dwButtonState;
        internal uint             dwControlKeyState;
        internal uint             dwEventFlags;
    }
}