using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class QUERY_BAD_RANGES_INPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal       uint Flags;
        internal       uint NumRanges;
        internal fixed byte Ranges[16];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.QUERY_BAD_RANGES_INPUT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.QUERY_BAD_RANGES_INPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.QUERY_BAD_RANGES_INPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.QUERY_BAD_RANGES_INPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static QUERY_BAD_RANGES_INPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new QUERY_BAD_RANGES_INPUT(native.ToPointer(), skipVTables);
    }

    internal static QUERY_BAD_RANGES_INPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (QUERY_BAD_RANGES_INPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static QUERY_BAD_RANGES_INPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new QUERY_BAD_RANGES_INPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private QUERY_BAD_RANGES_INPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected QUERY_BAD_RANGES_INPUT(void* native, bool skipVTables = false)
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

    public uint NumRanges
    {
        get => ((__Internal*)__Instance)->NumRanges;

        set => ((__Internal*)__Instance)->NumRanges = value;
    }

    public global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE[] Ranges
    {
        get
        {
            global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE[] __value = null;
            if (((__Internal*)__Instance)->Ranges != null)
            {
                __value = new global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__GetOrCreateInstance((IntPtr)((global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__Internal*)&(((__Internal*)__Instance)->Ranges[i * sizeof(global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__Internal)])), true, true);
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
                    *(global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__Internal*) &((__Internal*)__Instance)->Ranges[i * sizeof(global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__Internal)] = *(global::LibuvSharp.QUERY_BAD_RANGES_INPUT_RANGE.__Internal*)value[i].__Instance;
            }
        }
    }
}