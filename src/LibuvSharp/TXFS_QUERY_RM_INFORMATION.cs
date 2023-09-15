using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_QUERY_RM_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 176)]
    public partial struct __Internal
    {
        internal uint                             BytesRequired;
        internal ulong                            TailLsn;
        internal ulong                            CurrentLsn;
        internal ulong                            ArchiveTailLsn;
        internal ulong                            LogContainerSize;
        internal global::LARGE_INTEGER.__Internal HighestVirtualClock;
        internal uint                             LogContainerCount;
        internal uint                             LogContainerCountMax;
        internal uint                             LogContainerCountMin;
        internal uint                             LogGrowthIncrement;
        internal uint                             LogAutoShrinkPercentage;
        internal uint                             Flags;
        internal ushort                           LoggingMode;
        internal ushort                           Reserved;
        internal uint                             RmState;
        internal ulong                            LogCapacity;
        internal ulong                            LogFree;
        internal ulong                            TopsSize;
        internal ulong                            TopsUsed;
        internal ulong                            TransactionCount;
        internal ulong                            OnePCCount;
        internal ulong                            TwoPCCount;
        internal ulong                            NumberLogFileFull;
        internal ulong                            OldestTransactionAge;
        internal global::GUID.__Internal          RMName;
        internal uint                             TmLogPathOffset;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_QUERY_RM_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_QUERY_RM_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_QUERY_RM_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_QUERY_RM_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_QUERY_RM_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_QUERY_RM_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static TXFS_QUERY_RM_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_QUERY_RM_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_QUERY_RM_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_QUERY_RM_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_QUERY_RM_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_QUERY_RM_INFORMATION(void* native, bool skipVTables = false)
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

    public uint BytesRequired
    {
        get => ((__Internal*)__Instance)->BytesRequired;

        set => ((__Internal*)__Instance)->BytesRequired = value;
    }

    public ulong TailLsn
    {
        get => ((__Internal*)__Instance)->TailLsn;

        set => ((__Internal*)__Instance)->TailLsn = value;
    }

    public ulong CurrentLsn
    {
        get => ((__Internal*)__Instance)->CurrentLsn;

        set => ((__Internal*)__Instance)->CurrentLsn = value;
    }

    public ulong ArchiveTailLsn
    {
        get => ((__Internal*)__Instance)->ArchiveTailLsn;

        set => ((__Internal*)__Instance)->ArchiveTailLsn = value;
    }

    public ulong LogContainerSize
    {
        get => ((__Internal*)__Instance)->LogContainerSize;

        set => ((__Internal*)__Instance)->LogContainerSize = value;
    }

    public uint LogContainerCount
    {
        get => ((__Internal*)__Instance)->LogContainerCount;

        set => ((__Internal*)__Instance)->LogContainerCount = value;
    }

    public uint LogContainerCountMax
    {
        get => ((__Internal*)__Instance)->LogContainerCountMax;

        set => ((__Internal*)__Instance)->LogContainerCountMax = value;
    }

    public uint LogContainerCountMin
    {
        get => ((__Internal*)__Instance)->LogContainerCountMin;

        set => ((__Internal*)__Instance)->LogContainerCountMin = value;
    }

    public uint LogGrowthIncrement
    {
        get => ((__Internal*)__Instance)->LogGrowthIncrement;

        set => ((__Internal*)__Instance)->LogGrowthIncrement = value;
    }

    public uint LogAutoShrinkPercentage
    {
        get => ((__Internal*)__Instance)->LogAutoShrinkPercentage;

        set => ((__Internal*)__Instance)->LogAutoShrinkPercentage = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public ushort LoggingMode
    {
        get => ((__Internal*)__Instance)->LoggingMode;

        set => ((__Internal*)__Instance)->LoggingMode = value;
    }

    public ushort Reserved
    {
        get => ((__Internal*)__Instance)->Reserved;

        set => ((__Internal*)__Instance)->Reserved = value;
    }

    public uint RmState
    {
        get => ((__Internal*)__Instance)->RmState;

        set => ((__Internal*)__Instance)->RmState = value;
    }

    public ulong LogCapacity
    {
        get => ((__Internal*)__Instance)->LogCapacity;

        set => ((__Internal*)__Instance)->LogCapacity = value;
    }

    public ulong LogFree
    {
        get => ((__Internal*)__Instance)->LogFree;

        set => ((__Internal*)__Instance)->LogFree = value;
    }

    public ulong TopsSize
    {
        get => ((__Internal*)__Instance)->TopsSize;

        set => ((__Internal*)__Instance)->TopsSize = value;
    }

    public ulong TopsUsed
    {
        get => ((__Internal*)__Instance)->TopsUsed;

        set => ((__Internal*)__Instance)->TopsUsed = value;
    }

    public ulong TransactionCount
    {
        get => ((__Internal*)__Instance)->TransactionCount;

        set => ((__Internal*)__Instance)->TransactionCount = value;
    }

    public ulong OnePCCount
    {
        get => ((__Internal*)__Instance)->OnePCCount;

        set => ((__Internal*)__Instance)->OnePCCount = value;
    }

    public ulong TwoPCCount
    {
        get => ((__Internal*)__Instance)->TwoPCCount;

        set => ((__Internal*)__Instance)->TwoPCCount = value;
    }

    public ulong NumberLogFileFull
    {
        get => ((__Internal*)__Instance)->NumberLogFileFull;

        set => ((__Internal*)__Instance)->NumberLogFileFull = value;
    }

    public ulong OldestTransactionAge
    {
        get => ((__Internal*)__Instance)->OldestTransactionAge;

        set => ((__Internal*)__Instance)->OldestTransactionAge = value;
    }

    public uint TmLogPathOffset
    {
        get => ((__Internal*)__Instance)->TmLogPathOffset;

        set => ((__Internal*)__Instance)->TmLogPathOffset = value;
    }
}