using System.Runtime.InteropServices;

public partial struct LARGE_INTEGER
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal _0.__Internal _0;

        [FieldOffset(0)]
        internal U.__Internal u;

        [FieldOffset(0)]
        internal long QuadPart;
    }

    public partial class _0
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct __Internal
        {
            internal uint LowPart;
            internal int  HighPart;
        }
    }

    public partial class U
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct __Internal
        {
            internal uint LowPart;
            internal int  HighPart;
        }
    }
}