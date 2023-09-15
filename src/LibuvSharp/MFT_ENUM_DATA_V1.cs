using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class MFT_ENUM_DATA_V1 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal ulong  StartFileReferenceNumber;
        internal long   LowUsn;
        internal long   HighUsn;
        internal ushort MinMajorVersion;
        internal ushort MaxMajorVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MFT_ENUM_DATA_V1> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MFT_ENUM_DATA_V1>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.MFT_ENUM_DATA_V1 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.MFT_ENUM_DATA_V1 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MFT_ENUM_DATA_V1 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MFT_ENUM_DATA_V1(native.ToPointer(), skipVTables);
    }

    internal static MFT_ENUM_DATA_V1 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MFT_ENUM_DATA_V1)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MFT_ENUM_DATA_V1 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MFT_ENUM_DATA_V1(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MFT_ENUM_DATA_V1(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MFT_ENUM_DATA_V1(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public void Dispose()
    {
        Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
    }

    partial void DisposePartial(bool disposing);

    protected internal virtual void Dispose(bool disposing, bool callNativeDtor )
    {
        if (__Instance == IntPtr.Zero)
            return;
        NativeToManagedMap.TryRemove(__Instance, out _);
        DisposePartial(disposing);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public ulong StartFileReferenceNumber
    {
        get => ((__Internal*)__Instance)->StartFileReferenceNumber;

        set => ((__Internal*)__Instance)->StartFileReferenceNumber = value;
    }

    public long LowUsn
    {
        get => ((__Internal*)__Instance)->LowUsn;

        set => ((__Internal*)__Instance)->LowUsn = value;
    }

    public long HighUsn
    {
        get => ((__Internal*)__Instance)->HighUsn;

        set => ((__Internal*)__Instance)->HighUsn = value;
    }

    public ushort MinMajorVersion
    {
        get => ((__Internal*)__Instance)->MinMajorVersion;

        set => ((__Internal*)__Instance)->MinMajorVersion = value;
    }

    public ushort MaxMajorVersion
    {
        get => ((__Internal*)__Instance)->MaxMajorVersion;

        set => ((__Internal*)__Instance)->MaxMajorVersion = value;
    }
}