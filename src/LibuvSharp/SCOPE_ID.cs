using System.Runtime.InteropServices;

public unsafe partial class SCOPE_ID
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal global::SCOPE_ID._0.__Internal _0;
    }

    public unsafe partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::SCOPE_ID._0.__0.__Internal _0;

            [FieldOffset(0)]
            internal uint Value;
        }

        public unsafe partial class __0
        {
            [StructLayout(LayoutKind.Sequential, Size = 4)]
            public partial struct __Internal
            {
                internal uint Zone;
                internal uint Level;
            }
        }
    }
}