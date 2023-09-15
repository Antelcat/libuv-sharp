using System.Runtime.InteropServices;

public unsafe partial class GUID
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal       uint   Data1;
        internal       ushort Data2;
        internal       ushort Data3;
        internal fixed byte   Data4[8];
    }
}