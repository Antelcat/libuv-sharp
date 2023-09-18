using System.Runtime.InteropServices;

public partial class MENU_EVENT_RECORD
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal uint dwCommandId;
    }
}