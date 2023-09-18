using System.Runtime.InteropServices;

public partial class SockaddrIn6
{
    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public struct __Internal
    {
        internal ushort             sin6_family;
        internal ushort             sin6_port;
        internal uint               sin6_flowinfo;
        internal In6Addr.__Internal sin6_addr;
        internal _0.__Internal      _0;
    }

    public partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal uint sin6_scope_id;

            [FieldOffset(0)]
            internal SCOPE_ID.__Internal sin6_scope_struct;
        }
    }
}