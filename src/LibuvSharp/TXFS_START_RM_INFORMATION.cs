using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_START_RM_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 48)]
    public partial struct __Internal
    {
        internal       uint   Flags;
        internal       ulong  LogContainerSize;
        internal       uint   LogContainerCountMin;
        internal       uint   LogContainerCountMax;
        internal       uint   LogGrowthIncrement;
        internal       uint   LogAutoShrinkPercentage;
        internal       uint   TmLogPathOffset;
        internal       ushort TmLogPathLength;
        internal       ushort LoggingMode;
        internal       ushort LogPathLength;
        internal       ushort Reserved;
        internal fixed char   LogPath[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_START_RM_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_START_RM_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_START_RM_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_START_RM_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_START_RM_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_START_RM_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static TXFS_START_RM_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_START_RM_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_START_RM_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_START_RM_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_START_RM_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_START_RM_INFORMATION(void* native, bool skipVTables = false)
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

    public ulong LogContainerSize
    {
        get => ((__Internal*)__Instance)->LogContainerSize;

        set => ((__Internal*)__Instance)->LogContainerSize = value;
    }

    public uint LogContainerCountMin
    {
        get => ((__Internal*)__Instance)->LogContainerCountMin;

        set => ((__Internal*)__Instance)->LogContainerCountMin = value;
    }

    public uint LogContainerCountMax
    {
        get => ((__Internal*)__Instance)->LogContainerCountMax;

        set => ((__Internal*)__Instance)->LogContainerCountMax = value;
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

    public uint TmLogPathOffset
    {
        get => ((__Internal*)__Instance)->TmLogPathOffset;

        set => ((__Internal*)__Instance)->TmLogPathOffset = value;
    }

    public ushort TmLogPathLength
    {
        get => ((__Internal*)__Instance)->TmLogPathLength;

        set => ((__Internal*)__Instance)->TmLogPathLength = value;
    }

    public ushort LoggingMode
    {
        get => ((__Internal*)__Instance)->LoggingMode;

        set => ((__Internal*)__Instance)->LoggingMode = value;
    }

    public ushort LogPathLength
    {
        get => ((__Internal*)__Instance)->LogPathLength;

        set => ((__Internal*)__Instance)->LogPathLength = value;
    }

    public ushort Reserved
    {
        get => ((__Internal*)__Instance)->Reserved;

        set => ((__Internal*)__Instance)->Reserved = value;
    }

    public char[] LogPath
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->LogPath, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->LogPath[i] = value[i];
            }
        }
    }
}