using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PERF_BIN : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal       uint NumberOfBins;
        internal       uint TypeOfBin;
        internal fixed byte BinsRanges[16];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_BIN> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_BIN>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PERF_BIN managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PERF_BIN managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_BIN __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_BIN(native.ToPointer(), skipVTables);
    }

    internal static PERF_BIN __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_BIN)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_BIN __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_BIN(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_BIN(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_BIN(void* native, bool skipVTables = false)
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

    public uint NumberOfBins
    {
        get => ((__Internal*)__Instance)->NumberOfBins;

        set => ((__Internal*)__Instance)->NumberOfBins = value;
    }

    public uint TypeOfBin
    {
        get => ((__Internal*)__Instance)->TypeOfBin;

        set => ((__Internal*)__Instance)->TypeOfBin = value;
    }

    public global::LibuvSharp.BIN_RANGE[] BinsRanges
    {
        get
        {
            global::LibuvSharp.BIN_RANGE[] __value = null;
            if (((__Internal*)__Instance)->BinsRanges != null)
            {
                __value = new global::LibuvSharp.BIN_RANGE[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = global::LibuvSharp.BIN_RANGE.__GetOrCreateInstance((IntPtr)((global::LibuvSharp.BIN_RANGE.__Internal*)&(((__Internal*)__Instance)->BinsRanges[i * sizeof(global::LibuvSharp.BIN_RANGE.__Internal)])), true, true);
            }
            return __value;
        }

        set
        {
            if (value != null)
            {
                if (value.Length != 1)
                    throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                for (var i = 0; i < 1; i++)
                    *(global::LibuvSharp.BIN_RANGE.__Internal*) &((__Internal*)__Instance)->BinsRanges[i * sizeof(global::LibuvSharp.BIN_RANGE.__Internal)] = *(global::LibuvSharp.BIN_RANGE.__Internal*)value[i].__Instance;
            }
        }
    }
}