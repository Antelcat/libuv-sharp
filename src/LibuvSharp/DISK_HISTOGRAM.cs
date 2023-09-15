using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_HISTOGRAM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 72)]
    public partial struct __Internal
    {
        internal global::LARGE_INTEGER.__Internal DiskSize;
        internal global::LARGE_INTEGER.__Internal Start;
        internal global::LARGE_INTEGER.__Internal End;
        internal global::LARGE_INTEGER.__Internal Average;
        internal global::LARGE_INTEGER.__Internal AverageRead;
        internal global::LARGE_INTEGER.__Internal AverageWrite;
        internal uint                             Granularity;
        internal uint                             Size;
        internal uint                             ReadCount;
        internal uint                             WriteCount;
        internal IntPtr                         Histogram;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_HISTOGRAM> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_HISTOGRAM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_HISTOGRAM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_HISTOGRAM managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_HISTOGRAM __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_HISTOGRAM(native.ToPointer(), skipVTables);
    }

    internal static DISK_HISTOGRAM __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_HISTOGRAM)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_HISTOGRAM __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_HISTOGRAM(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_HISTOGRAM(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_HISTOGRAM(void* native, bool skipVTables = false)
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

    public uint Granularity
    {
        get => ((__Internal*)__Instance)->Granularity;

        set => ((__Internal*)__Instance)->Granularity = value;
    }

    public uint Size
    {
        get => ((__Internal*)__Instance)->Size;

        set => ((__Internal*)__Instance)->Size = value;
    }

    public uint ReadCount
    {
        get => ((__Internal*)__Instance)->ReadCount;

        set => ((__Internal*)__Instance)->ReadCount = value;
    }

    public uint WriteCount
    {
        get => ((__Internal*)__Instance)->WriteCount;

        set => ((__Internal*)__Instance)->WriteCount = value;
    }

    public global::LibuvSharp.HISTOGRAM_BUCKET Histogram
    {
        get
        {
            var __result0 = global::LibuvSharp.HISTOGRAM_BUCKET.__GetOrCreateInstance(((__Internal*)__Instance)->Histogram, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->Histogram = value is null ? IntPtr.Zero : value.__Instance;
    }
}