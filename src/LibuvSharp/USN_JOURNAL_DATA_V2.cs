using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_JOURNAL_DATA_V2 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 80)]
    public struct __Internal
    {
        internal ulong  UsnJournalID;
        internal long   FirstUsn;
        internal long   NextUsn;
        internal long   LowestValidUsn;
        internal long   MaxUsn;
        internal ulong  MaximumSize;
        internal ulong  AllocationDelta;
        internal ushort MinSupportedMajorVersion;
        internal ushort MaxSupportedMajorVersion;
        internal uint   Flags;
        internal ulong  RangeTrackChunkSize;
        internal long   RangeTrackFileSizeThreshold;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, USN_JOURNAL_DATA_V2> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, USN_JOURNAL_DATA_V2>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, USN_JOURNAL_DATA_V2 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out USN_JOURNAL_DATA_V2 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_JOURNAL_DATA_V2 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_JOURNAL_DATA_V2(native.ToPointer(), skipVTables);
    }

    internal static USN_JOURNAL_DATA_V2 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_JOURNAL_DATA_V2)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_JOURNAL_DATA_V2 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_JOURNAL_DATA_V2(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_JOURNAL_DATA_V2(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_JOURNAL_DATA_V2(void* native, bool skipVTables = false)
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

    public ulong UsnJournalID
    {
        get => ((__Internal*)__Instance)->UsnJournalID;

        set => ((__Internal*)__Instance)->UsnJournalID = value;
    }

    public long FirstUsn
    {
        get => ((__Internal*)__Instance)->FirstUsn;

        set => ((__Internal*)__Instance)->FirstUsn = value;
    }

    public long NextUsn
    {
        get => ((__Internal*)__Instance)->NextUsn;

        set => ((__Internal*)__Instance)->NextUsn = value;
    }

    public long LowestValidUsn
    {
        get => ((__Internal*)__Instance)->LowestValidUsn;

        set => ((__Internal*)__Instance)->LowestValidUsn = value;
    }

    public long MaxUsn
    {
        get => ((__Internal*)__Instance)->MaxUsn;

        set => ((__Internal*)__Instance)->MaxUsn = value;
    }

    public ulong MaximumSize
    {
        get => ((__Internal*)__Instance)->MaximumSize;

        set => ((__Internal*)__Instance)->MaximumSize = value;
    }

    public ulong AllocationDelta
    {
        get => ((__Internal*)__Instance)->AllocationDelta;

        set => ((__Internal*)__Instance)->AllocationDelta = value;
    }

    public ushort MinSupportedMajorVersion
    {
        get => ((__Internal*)__Instance)->MinSupportedMajorVersion;

        set => ((__Internal*)__Instance)->MinSupportedMajorVersion = value;
    }

    public ushort MaxSupportedMajorVersion
    {
        get => ((__Internal*)__Instance)->MaxSupportedMajorVersion;

        set => ((__Internal*)__Instance)->MaxSupportedMajorVersion = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public ulong RangeTrackChunkSize
    {
        get => ((__Internal*)__Instance)->RangeTrackChunkSize;

        set => ((__Internal*)__Instance)->RangeTrackChunkSize = value;
    }

    public long RangeTrackFileSizeThreshold
    {
        get => ((__Internal*)__Instance)->RangeTrackFileSizeThreshold;

        set => ((__Internal*)__Instance)->RangeTrackFileSizeThreshold = value;
    }
}