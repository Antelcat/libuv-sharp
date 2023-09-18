using System.Runtime.InteropServices;

public partial class INPUT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 20)]
    public struct __Internal
    {
        internal ushort           EventType;
        internal Event.__Internal Event;
    }

    public partial struct Event
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal KEY_EVENT_RECORD.__Internal KeyEvent;

            [FieldOffset(0)]
            internal MOUSE_EVENT_RECORD.__Internal MouseEvent;

            [FieldOffset(0)]
            internal WINDOW_BUFFER_SIZE_RECORD.__Internal WindowBufferSizeEvent;

            [FieldOffset(0)]
            internal MENU_EVENT_RECORD.__Internal MenuEvent;

            [FieldOffset(0)]
            internal FOCUS_EVENT_RECORD.__Internal FocusEvent;
        }
    }
}