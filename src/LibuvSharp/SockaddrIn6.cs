using System.Runtime.InteropServices;

public unsafe partial class SockaddrIn6
{
    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public partial struct __Internal
    {
        internal ushort                            sin6_family;
        internal ushort                            sin6_port;
        internal uint                              sin6_flowinfo;
        internal global::In6Addr.__Internal        sin6_addr;
        internal global::SockaddrIn6._0.__Internal _0;
    }

    public unsafe partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint sin6_scope_id;

            [FieldOffset(0)]
            internal global::SCOPE_ID.__Internal sin6_scope_struct;
        }
    }
}