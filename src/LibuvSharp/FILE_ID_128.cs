using System.Runtime.InteropServices;

public unsafe partial class FILE_ID_128
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal fixed byte Identifier[16];
    }
}