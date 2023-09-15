using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class EXFAT_STATISTICS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 36)]
    public partial struct __Internal
    {
        internal uint CreateHits;
        internal uint SuccessfulCreates;
        internal uint FailedCreates;
        internal uint NonCachedReads;
        internal uint NonCachedReadBytes;
        internal uint NonCachedWrites;
        internal uint NonCachedWriteBytes;
        internal uint NonCachedDiskReads;
        internal uint NonCachedDiskWrites;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.EXFAT_STATISTICS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.EXFAT_STATISTICS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.EXFAT_STATISTICS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.EXFAT_STATISTICS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static EXFAT_STATISTICS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new EXFAT_STATISTICS(native.ToPointer(), skipVTables);
    }

    internal static EXFAT_STATISTICS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (EXFAT_STATISTICS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static EXFAT_STATISTICS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new EXFAT_STATISTICS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private EXFAT_STATISTICS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected EXFAT_STATISTICS(void* native, bool skipVTables = false)
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

    public uint CreateHits
    {
        get => ((__Internal*)__Instance)->CreateHits;

        set => ((__Internal*)__Instance)->CreateHits = value;
    }

    public uint SuccessfulCreates
    {
        get => ((__Internal*)__Instance)->SuccessfulCreates;

        set => ((__Internal*)__Instance)->SuccessfulCreates = value;
    }

    public uint FailedCreates
    {
        get => ((__Internal*)__Instance)->FailedCreates;

        set => ((__Internal*)__Instance)->FailedCreates = value;
    }

    public uint NonCachedReads
    {
        get => ((__Internal*)__Instance)->NonCachedReads;

        set => ((__Internal*)__Instance)->NonCachedReads = value;
    }

    public uint NonCachedReadBytes
    {
        get => ((__Internal*)__Instance)->NonCachedReadBytes;

        set => ((__Internal*)__Instance)->NonCachedReadBytes = value;
    }

    public uint NonCachedWrites
    {
        get => ((__Internal*)__Instance)->NonCachedWrites;

        set => ((__Internal*)__Instance)->NonCachedWrites = value;
    }

    public uint NonCachedWriteBytes
    {
        get => ((__Internal*)__Instance)->NonCachedWriteBytes;

        set => ((__Internal*)__Instance)->NonCachedWriteBytes = value;
    }

    public uint NonCachedDiskReads
    {
        get => ((__Internal*)__Instance)->NonCachedDiskReads;

        set => ((__Internal*)__Instance)->NonCachedDiskReads = value;
    }

    public uint NonCachedDiskWrites
    {
        get => ((__Internal*)__Instance)->NonCachedDiskWrites;

        set => ((__Internal*)__Instance)->NonCachedDiskWrites = value;
    }
}