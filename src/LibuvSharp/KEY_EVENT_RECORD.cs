using System.Runtime.InteropServices;

public partial class KEY_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal int              bKeyDown;
        internal ushort           wRepeatCount;
        internal ushort           wVirtualKeyCode;
        internal ushort           wVirtualScanCode;
        internal UChar.__Internal uChar;
        internal uint             dwControlKeyState;
    }

    public partial struct UChar
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal char UnicodeChar;

            [FieldOffset(0)]
            internal sbyte AsciiChar;
        }
    }
}