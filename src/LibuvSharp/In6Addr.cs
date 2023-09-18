using System.Runtime.InteropServices;

public unsafe partial class In6Addr
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal U.__Internal u;
    }

    public partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal fixed byte Byte[16];

            [FieldOffset(0)]
            internal fixed ushort Word[8];
        }
    }
}