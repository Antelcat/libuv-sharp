using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class QUERY_BAD_RANGES_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal       uint  Flags;
        internal       uint  NumBadRanges;
        internal       ulong NextOffsetToLookUp;
        internal fixed byte  BadRanges[24];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, QUERY_BAD_RANGES_OUTPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, QUERY_BAD_RANGES_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, QUERY_BAD_RANGES_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out QUERY_BAD_RANGES_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static QUERY_BAD_RANGES_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new QUERY_BAD_RANGES_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static QUERY_BAD_RANGES_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (QUERY_BAD_RANGES_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static QUERY_BAD_RANGES_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new QUERY_BAD_RANGES_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private QUERY_BAD_RANGES_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected QUERY_BAD_RANGES_OUTPUT(void* native, bool skipVTables = false)
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

    public uint NumBadRanges
    {
        get => ((__Internal*)__Instance)->NumBadRanges;

        set => ((__Internal*)__Instance)->NumBadRanges = value;
    }

    public ulong NextOffsetToLookUp
    {
        get => ((__Internal*)__Instance)->NextOffsetToLookUp;

        set => ((__Internal*)__Instance)->NextOffsetToLookUp = value;
    }

    public QUERY_BAD_RANGES_OUTPUT_RANGE[] BadRanges
    {
        get
        {
            QUERY_BAD_RANGES_OUTPUT_RANGE[] __value = null;
            if (((__Internal*)__Instance)->BadRanges != null)
            {
                __value = new QUERY_BAD_RANGES_OUTPUT_RANGE[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = QUERY_BAD_RANGES_OUTPUT_RANGE.__GetOrCreateInstance((IntPtr)(QUERY_BAD_RANGES_OUTPUT_RANGE.__Internal*)&((__Internal*)__Instance)->BadRanges[i * sizeof(QUERY_BAD_RANGES_OUTPUT_RANGE.__Internal)], true, true);
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
                    *(QUERY_BAD_RANGES_OUTPUT_RANGE.__Internal*) &((__Internal*)__Instance)->BadRanges[i * sizeof(QUERY_BAD_RANGES_OUTPUT_RANGE.__Internal)] = *(QUERY_BAD_RANGES_OUTPUT_RANGE.__Internal*)value[i].__Instance;
            }
        }
    }
}