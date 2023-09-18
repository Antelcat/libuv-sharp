using System.Runtime.InteropServices;

public unsafe partial class SID
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct __Internal
    {
        internal       byte                                Revision;
        internal       byte                                SubAuthorityCount;
        internal       SID_IDENTIFIER_AUTHORITY.__Internal IdentifierAuthority;
        internal fixed uint                                SubAuthority[1];
    }
}