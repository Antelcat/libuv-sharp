using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial struct USN_RECORD_UNION
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal USN_RECORD_COMMON_HEADER.__Internal Header;

        [FieldOffset(0)]
        internal USN_RECORD_V2.__Internal V2;

        [FieldOffset(0)]
        internal USN_RECORD_V3.__Internal V3;

        [FieldOffset(0)]
        internal USN_RECORD_V4.__Internal V4;
    }

    private  __Internal __instance;
    internal __Internal __Instance => __instance;

    internal static USN_RECORD_UNION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return new USN_RECORD_UNION(native.ToPointer(), skipVTables);
    }

    internal static USN_RECORD_UNION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RECORD_UNION(native, skipVTables);
    }

    private USN_RECORD_UNION(__Internal native, bool skipVTables = false)
        : this()
    {
        __instance = native;
    }

    private USN_RECORD_UNION(void* native, bool skipVTables = false) : this()
    {
        __instance = *(__Internal*) native;
    }

    public USN_RECORD_COMMON_HEADER Header
    {
        get => USN_RECORD_COMMON_HEADER.__CreateInstance(__instance.Header);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.Header = *(USN_RECORD_COMMON_HEADER.__Internal*) value.__Instance;
        }
    }

    public USN_RECORD_V2 V2
    {
        get => USN_RECORD_V2.__CreateInstance(__instance.V2);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.V2 = *(USN_RECORD_V2.__Internal*) value.__Instance;
        }
    }

    public USN_RECORD_V3 V3
    {
        get => USN_RECORD_V3.__CreateInstance(__instance.V3);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.V3 = *(USN_RECORD_V3.__Internal*) value.__Instance;
        }
    }

    public USN_RECORD_V4 V4
    {
        get => USN_RECORD_V4.__CreateInstance(__instance.V4);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.V4 = *(USN_RECORD_V4.__Internal*) value.__Instance;
        }
    }
}