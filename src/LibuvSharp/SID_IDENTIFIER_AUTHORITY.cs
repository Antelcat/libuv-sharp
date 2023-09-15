using System.Runtime.InteropServices;

public unsafe partial class SID_IDENTIFIER_AUTHORITY
{
    [StructLayout(LayoutKind.Sequential, Size = 6)]
    public partial struct __Internal
    {
        internal fixed byte Value[6];
    }
}