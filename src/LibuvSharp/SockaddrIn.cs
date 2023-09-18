using System.Runtime.InteropServices;

public unsafe partial class SockaddrIn
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal       ushort            sin_family;
        internal       ushort            sin_port;
        internal       InAddr.__Internal sin_addr;
        internal fixed sbyte             sin_zero[8];
    }
}