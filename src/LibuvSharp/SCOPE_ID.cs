using System.Runtime.InteropServices;

public partial class SCOPE_ID
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal _0.__Internal _0;
    }

    public partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal __0.__Internal _0;

            [FieldOffset(0)]
            internal uint Value;
        }

        public partial class __0
        {
            [StructLayout(LayoutKind.Sequential, Size = 4)]
            public struct __Internal
            {
                internal uint Zone;
                internal uint Level;
            }
        }
    }
}