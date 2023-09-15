using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_RECORD_COMMON_HEADER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public partial struct __Internal
    {
        internal uint   RecordLength;
        internal ushort MajorVersion;
        internal ushort MinorVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RECORD_COMMON_HEADER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RECORD_COMMON_HEADER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.USN_RECORD_COMMON_HEADER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.USN_RECORD_COMMON_HEADER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_RECORD_COMMON_HEADER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_RECORD_COMMON_HEADER(native.ToPointer(), skipVTables);
    }

    internal static USN_RECORD_COMMON_HEADER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_RECORD_COMMON_HEADER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_RECORD_COMMON_HEADER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RECORD_COMMON_HEADER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_RECORD_COMMON_HEADER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_RECORD_COMMON_HEADER(void* native, bool skipVTables = false)
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

    public uint RecordLength
    {
        get => ((__Internal*)__Instance)->RecordLength;

        set => ((__Internal*)__Instance)->RecordLength = value;
    }

    public ushort MajorVersion
    {
        get => ((__Internal*)__Instance)->MajorVersion;

        set => ((__Internal*)__Instance)->MajorVersion = value;
    }

    public ushort MinorVersion
    {
        get => ((__Internal*)__Instance)->MinorVersion;

        set => ((__Internal*)__Instance)->MinorVersion = value;
    }
}