using System.Runtime.InteropServices;

public unsafe partial class OVERLAPPED
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal ulong                            Internal;
        internal ulong                            InternalHigh;
        internal global::OVERLAPPED._0.__Internal _0;
        internal IntPtr                         hEvent;
    }

    public unsafe partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::OVERLAPPED._0.__0.__Internal _0;

            [FieldOffset(0)]
            internal IntPtr Pointer;
        }

        public unsafe partial class __0
        {
            [StructLayout(LayoutKind.Sequential, Size = 8)]
            public partial struct __Internal
            {
                internal uint Offset;
                internal uint OffsetHigh;
            }
        }
    }
}