using System.Runtime.InteropServices;

public partial class InAddr
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal S_un.__Internal S_un;
    }

    public partial struct S_un
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal S_un_b.__Internal S_un_b;

            [FieldOffset(0)]
            internal S_un_w.__Internal S_un_w;

            [FieldOffset(0)]
            internal uint S_addr;
        }

        public partial class S_un_b
        {
            [StructLayout(LayoutKind.Sequential, Size = 4)]
            public struct __Internal
            {
                internal byte s_b1;
                internal byte s_b2;
                internal byte s_b3;
                internal byte s_b4;
            }
        }

        public partial class S_un_w
        {
            [StructLayout(LayoutKind.Sequential, Size = 4)]
            public struct __Internal
            {
                internal ushort s_w1;
                internal ushort s_w2;
            }
        }
    }
}