using System.Runtime.InteropServices;

public unsafe partial class In6Addr
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal global::In6Addr.U.__Internal u;
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed byte Byte[16];

            [FieldOffset(0)]
            internal fixed ushort Word[8];
        }
    }
}