using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_TRACK_MODIFIED_RANGES : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public struct __Internal
    {
        internal uint  Flags;
        internal uint  Unused;
        internal ulong ChunkSize;
        internal long  FileSizeThreshold;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, USN_TRACK_MODIFIED_RANGES> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, USN_TRACK_MODIFIED_RANGES>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, USN_TRACK_MODIFIED_RANGES managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out USN_TRACK_MODIFIED_RANGES managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_TRACK_MODIFIED_RANGES __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_TRACK_MODIFIED_RANGES(native.ToPointer(), skipVTables);
    }

    internal static USN_TRACK_MODIFIED_RANGES __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_TRACK_MODIFIED_RANGES)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_TRACK_MODIFIED_RANGES __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_TRACK_MODIFIED_RANGES(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_TRACK_MODIFIED_RANGES(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_TRACK_MODIFIED_RANGES(void* native, bool skipVTables = false)
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

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public uint Unused
    {
        get => ((__Internal*)__Instance)->Unused;

        set => ((__Internal*)__Instance)->Unused = value;
    }

    public ulong ChunkSize
    {
        get => ((__Internal*)__Instance)->ChunkSize;

        set => ((__Internal*)__Instance)->ChunkSize = value;
    }

    public long FileSizeThreshold
    {
        get => ((__Internal*)__Instance)->FileSizeThreshold;

        set => ((__Internal*)__Instance)->FileSizeThreshold = value;
    }
}