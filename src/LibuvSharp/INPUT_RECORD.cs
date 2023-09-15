using System.Runtime.InteropServices;

public unsafe partial class INPUT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 20)]
    public partial struct __Internal
    {
        internal ushort                                EventType;
        internal global::INPUT_RECORD.Event.__Internal Event;
    }

    public unsafe partial struct Event
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::KEY_EVENT_RECORD.__Internal KeyEvent;

            [FieldOffset(0)]
            internal global::MOUSE_EVENT_RECORD.__Internal MouseEvent;

            [FieldOffset(0)]
            internal global::WINDOW_BUFFER_SIZE_RECORD.__Internal WindowBufferSizeEvent;

            [FieldOffset(0)]
            internal global::MENU_EVENT_RECORD.__Internal MenuEvent;

            [FieldOffset(0)]
            internal global::FOCUS_EVENT_RECORD.__Internal FocusEvent;
        }
    }
}