using System.Runtime.InteropServices;

public unsafe partial struct LARGE_INTEGER
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::LARGE_INTEGER._0.__Internal _0;

        [FieldOffset(0)]
        internal global::LARGE_INTEGER.U.__Internal u;

        [FieldOffset(0)]
        internal long QuadPart;
    }

    public unsafe partial class _0
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public partial struct __Internal
        {
            internal uint LowPart;
            internal int  HighPart;
        }
    }

    public unsafe partial class U
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public partial struct __Internal
        {
            internal uint LowPart;
            internal int  HighPart;
        }
    }
}