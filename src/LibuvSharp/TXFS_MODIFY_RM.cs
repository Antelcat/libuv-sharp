using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_MODIFY_RM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public partial struct __Internal
    {
        internal uint   Flags;
        internal uint   LogContainerCountMax;
        internal uint   LogContainerCountMin;
        internal uint   LogContainerCount;
        internal uint   LogGrowthIncrement;
        internal uint   LogAutoShrinkPercentage;
        internal ulong  Reserved;
        internal ushort LoggingMode;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_MODIFY_RM> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_MODIFY_RM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_MODIFY_RM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_MODIFY_RM managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_MODIFY_RM __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_MODIFY_RM(native.ToPointer(), skipVTables);
    }

    internal static TXFS_MODIFY_RM __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_MODIFY_RM)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_MODIFY_RM __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_MODIFY_RM(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_MODIFY_RM(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_MODIFY_RM(void* native, bool skipVTables = false)
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

    public uint LogContainerCount
    {
        get => ((__Internal*)__Instance)->LogContainerCount;

        set => ((__Internal*)__Instance)->LogContainerCount = value;
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

    public ulong Reserved
    {
        get => ((__Internal*)__Instance)->Reserved;

        set => ((__Internal*)__Instance)->Reserved = value;
    }

    public ushort LoggingMode
    {
        get => ((__Internal*)__Instance)->LoggingMode;

        set => ((__Internal*)__Instance)->LoggingMode = value;
    }
}