using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PERF_COUNTER_DEFINITION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40, Pack = 8)]
    public partial struct __Internal
    {
        internal uint ByteLength;
        internal uint CounterNameTitleIndex;
        internal uint CounterNameTitle;
        internal uint CounterHelpTitleIndex;
        internal uint CounterHelpTitle;
        internal int  DefaultScale;
        internal uint DetailLevel;
        internal uint CounterType;
        internal uint CounterSize;
        internal uint CounterOffset;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_COUNTER_DEFINITION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_COUNTER_DEFINITION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PERF_COUNTER_DEFINITION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PERF_COUNTER_DEFINITION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_COUNTER_DEFINITION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_COUNTER_DEFINITION(native.ToPointer(), skipVTables);
    }

    internal static PERF_COUNTER_DEFINITION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_COUNTER_DEFINITION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_COUNTER_DEFINITION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_COUNTER_DEFINITION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_COUNTER_DEFINITION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_COUNTER_DEFINITION(void* native, bool skipVTables = false)
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

    public uint ByteLength
    {
        get => ((__Internal*)__Instance)->ByteLength;

        set => ((__Internal*)__Instance)->ByteLength = value;
    }

    public uint CounterNameTitleIndex
    {
        get => ((__Internal*)__Instance)->CounterNameTitleIndex;

        set => ((__Internal*)__Instance)->CounterNameTitleIndex = value;
    }

    public uint CounterNameTitle
    {
        get => ((__Internal*)__Instance)->CounterNameTitle;

        set => ((__Internal*)__Instance)->CounterNameTitle = value;
    }

    public uint CounterHelpTitleIndex
    {
        get => ((__Internal*)__Instance)->CounterHelpTitleIndex;

        set => ((__Internal*)__Instance)->CounterHelpTitleIndex = value;
    }

    public uint CounterHelpTitle
    {
        get => ((__Internal*)__Instance)->CounterHelpTitle;

        set => ((__Internal*)__Instance)->CounterHelpTitle = value;
    }

    public int DefaultScale
    {
        get => ((__Internal*)__Instance)->DefaultScale;

        set => ((__Internal*)__Instance)->DefaultScale = value;
    }

    public uint DetailLevel
    {
        get => ((__Internal*)__Instance)->DetailLevel;

        set => ((__Internal*)__Instance)->DetailLevel = value;
    }

    public uint CounterType
    {
        get => ((__Internal*)__Instance)->CounterType;

        set => ((__Internal*)__Instance)->CounterType = value;
    }

    public uint CounterSize
    {
        get => ((__Internal*)__Instance)->CounterSize;

        set => ((__Internal*)__Instance)->CounterSize = value;
    }

    public uint CounterOffset
    {
        get => ((__Internal*)__Instance)->CounterOffset;

        set => ((__Internal*)__Instance)->CounterOffset = value;
    }
}