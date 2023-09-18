using System.Runtime.InteropServices;

public partial class FOCUS_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal int bSetFocus;
    }
}