using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PERF_COUNTER_BLOCK : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4, Pack = 8)]
    public partial struct __Internal
    {
        internal uint ByteLength;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_COUNTER_BLOCK> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_COUNTER_BLOCK>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PERF_COUNTER_BLOCK managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PERF_COUNTER_BLOCK managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_COUNTER_BLOCK __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_COUNTER_BLOCK(native.ToPointer(), skipVTables);
    }

    internal static PERF_COUNTER_BLOCK __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_COUNTER_BLOCK)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_COUNTER_BLOCK __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_COUNTER_BLOCK(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_COUNTER_BLOCK(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_COUNTER_BLOCK(void* native, bool skipVTables = false)
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
}