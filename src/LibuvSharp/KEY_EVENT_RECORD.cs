using System.Runtime.InteropServices;

public unsafe partial class KEY_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal int                                       bKeyDown;
        internal ushort                                    wRepeatCount;
        internal ushort                                    wVirtualKeyCode;
        internal ushort                                    wVirtualScanCode;
        internal global::KEY_EVENT_RECORD.UChar.__Internal uChar;
        internal uint                                      dwControlKeyState;
    }

    public unsafe partial struct UChar
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal char UnicodeChar;

            [FieldOffset(0)]
            internal sbyte AsciiChar;
        }
    }
}