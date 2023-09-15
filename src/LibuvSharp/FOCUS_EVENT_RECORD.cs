using System.Runtime.InteropServices;

public unsafe partial class FOCUS_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal int bSetFocus;
    }
}