using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PERF_OBJECT_TYPE : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 64, Pack = 8)]
    public partial struct __Internal
    {
        internal uint                             TotalByteLength;
        internal uint                             DefinitionLength;
        internal uint                             HeaderLength;
        internal uint                             ObjectNameTitleIndex;
        internal uint                             ObjectNameTitle;
        internal uint                             ObjectHelpTitleIndex;
        internal uint                             ObjectHelpTitle;
        internal uint                             DetailLevel;
        internal uint                             NumCounters;
        internal int                              DefaultCounter;
        internal int                              NumInstances;
        internal uint                             CodePage;
        internal global::LARGE_INTEGER.__Internal PerfTime;
        internal global::LARGE_INTEGER.__Internal PerfFreq;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_OBJECT_TYPE> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_OBJECT_TYPE>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PERF_OBJECT_TYPE managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PERF_OBJECT_TYPE managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_OBJECT_TYPE __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_OBJECT_TYPE(native.ToPointer(), skipVTables);
    }

    internal static PERF_OBJECT_TYPE __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_OBJECT_TYPE)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_OBJECT_TYPE __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_OBJECT_TYPE(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_OBJECT_TYPE(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_OBJECT_TYPE(void* native, bool skipVTables = false)
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

    public uint TotalByteLength
    {
        get => ((__Internal*)__Instance)->TotalByteLength;

        set => ((__Internal*)__Instance)->TotalByteLength = value;
    }

    public uint DefinitionLength
    {
        get => ((__Internal*)__Instance)->DefinitionLength;

        set => ((__Internal*)__Instance)->DefinitionLength = value;
    }

    public uint HeaderLength
    {
        get => ((__Internal*)__Instance)->HeaderLength;

        set => ((__Internal*)__Instance)->HeaderLength = value;
    }

    public uint ObjectNameTitleIndex
    {
        get => ((__Internal*)__Instance)->ObjectNameTitleIndex;

        set => ((__Internal*)__Instance)->ObjectNameTitleIndex = value;
    }

    public uint ObjectNameTitle
    {
        get => ((__Internal*)__Instance)->ObjectNameTitle;

        set => ((__Internal*)__Instance)->ObjectNameTitle = value;
    }

    public uint ObjectHelpTitleIndex
    {
        get => ((__Internal*)__Instance)->ObjectHelpTitleIndex;

        set => ((__Internal*)__Instance)->ObjectHelpTitleIndex = value;
    }

    public uint ObjectHelpTitle
    {
        get => ((__Internal*)__Instance)->ObjectHelpTitle;

        set => ((__Internal*)__Instance)->ObjectHelpTitle = value;
    }

    public uint DetailLevel
    {
        get => ((__Internal*)__Instance)->DetailLevel;

        set => ((__Internal*)__Instance)->DetailLevel = value;
    }

    public uint NumCounters
    {
        get => ((__Internal*)__Instance)->NumCounters;

        set => ((__Internal*)__Instance)->NumCounters = value;
    }

    public int DefaultCounter
    {
        get => ((__Internal*)__Instance)->DefaultCounter;

        set => ((__Internal*)__Instance)->DefaultCounter = value;
    }

    public int NumInstances
    {
        get => ((__Internal*)__Instance)->NumInstances;

        set => ((__Internal*)__Instance)->NumInstances = value;
    }

    public uint CodePage
    {
        get => ((__Internal*)__Instance)->CodePage;

        set => ((__Internal*)__Instance)->CodePage = value;
    }
}