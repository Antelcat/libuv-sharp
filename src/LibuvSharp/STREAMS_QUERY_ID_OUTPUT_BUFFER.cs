using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class STREAMS_QUERY_ID_OUTPUT_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal uint StreamId;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, STREAMS_QUERY_ID_OUTPUT_BUFFER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, STREAMS_QUERY_ID_OUTPUT_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, STREAMS_QUERY_ID_OUTPUT_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out STREAMS_QUERY_ID_OUTPUT_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static STREAMS_QUERY_ID_OUTPUT_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new STREAMS_QUERY_ID_OUTPUT_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static STREAMS_QUERY_ID_OUTPUT_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (STREAMS_QUERY_ID_OUTPUT_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static STREAMS_QUERY_ID_OUTPUT_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new STREAMS_QUERY_ID_OUTPUT_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private STREAMS_QUERY_ID_OUTPUT_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected STREAMS_QUERY_ID_OUTPUT_BUFFER(void* native, bool skipVTables = false)
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

    public uint StreamId
    {
        get => ((__Internal*)__Instance)->StreamId;

        set => ((__Internal*)__Instance)->StreamId = value;
    }
}