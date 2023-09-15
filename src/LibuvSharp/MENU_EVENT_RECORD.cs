using System.Runtime.InteropServices;

public unsafe partial class MENU_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal uint dwCommandId;
    }
}