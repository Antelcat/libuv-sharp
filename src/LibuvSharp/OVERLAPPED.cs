using System.Runtime.InteropServices;

public partial class OVERLAPPED
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal ulong         Internal;
        internal ulong         InternalHigh;
        internal _0.__Internal _0;
        internal IntPtr        hEvent;
    }

    public partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal __0.__Internal _0;

            [FieldOffset(0)]
            internal IntPtr Pointer;
        }

        public partial class __0
        {
            [StructLayout(LayoutKind.Sequential, Size = 8)]
            public struct __Internal
            {
                internal uint Offset;
                internal uint OffsetHigh;
            }
        }
    }
}