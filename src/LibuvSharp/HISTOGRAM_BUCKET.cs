using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class HISTOGRAM_BUCKET : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal uint Reads;
        internal uint Writes;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, HISTOGRAM_BUCKET> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, HISTOGRAM_BUCKET>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, HISTOGRAM_BUCKET managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out HISTOGRAM_BUCKET managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static HISTOGRAM_BUCKET __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new HISTOGRAM_BUCKET(native.ToPointer(), skipVTables);
    }

    internal static HISTOGRAM_BUCKET __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (HISTOGRAM_BUCKET)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static HISTOGRAM_BUCKET __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new HISTOGRAM_BUCKET(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private HISTOGRAM_BUCKET(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected HISTOGRAM_BUCKET(void* native, bool skipVTables = false)
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

    public uint Reads
    {
        get => ((__Internal*)__Instance)->Reads;

        set => ((__Internal*)__Instance)->Reads = value;
    }

    public uint Writes
    {
        get => ((__Internal*)__Instance)->Writes;

        set => ((__Internal*)__Instance)->Writes = value;
    }
}