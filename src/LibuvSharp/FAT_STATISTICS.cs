using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FAT_STATISTICS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 36)]
    public struct __Internal
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

    internal static readonly ConcurrentDictionary<IntPtr, FAT_STATISTICS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, FAT_STATISTICS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, FAT_STATISTICS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out FAT_STATISTICS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FAT_STATISTICS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FAT_STATISTICS(native.ToPointer(), skipVTables);
    }

    internal static FAT_STATISTICS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FAT_STATISTICS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FAT_STATISTICS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FAT_STATISTICS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FAT_STATISTICS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FAT_STATISTICS(void* native, bool skipVTables = false)
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