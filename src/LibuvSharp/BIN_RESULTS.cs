using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class BIN_RESULTS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal       uint NumberOfBins;
        internal fixed byte BinCountsPadding[4];
        internal fixed byte BinCounts[24];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, BIN_RESULTS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, BIN_RESULTS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, BIN_RESULTS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out BIN_RESULTS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static BIN_RESULTS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new BIN_RESULTS(native.ToPointer(), skipVTables);
    }

    internal static BIN_RESULTS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (BIN_RESULTS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static BIN_RESULTS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new BIN_RESULTS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private BIN_RESULTS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected BIN_RESULTS(void* native, bool skipVTables = false)
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

    public BIN_COUNT[] BinCounts
    {
        get
        {
            BIN_COUNT[] __value = null;
            if (((__Internal*)__Instance)->BinCounts != null)
            {
                __value = new BIN_COUNT[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = BIN_COUNT.__GetOrCreateInstance((IntPtr)((BIN_COUNT.__Internal*)&(((__Internal*)__Instance)->BinCounts[i * sizeof(BIN_COUNT.__Internal)])), true, true);
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
                    *(BIN_COUNT.__Internal*) &((__Internal*)__Instance)->BinCounts[i * sizeof(BIN_COUNT.__Internal)] = *(BIN_COUNT.__Internal*)value[i].__Instance;
            }
        }
    }
}