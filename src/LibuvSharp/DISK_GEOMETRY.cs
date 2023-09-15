using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_GEOMETRY : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal global::LARGE_INTEGER.__Internal Cylinders;
        internal global::LibuvSharp.MEDIA_TYPE    MediaType;
        internal uint                             TracksPerCylinder;
        internal uint                             SectorsPerTrack;
        internal uint                             BytesPerSector;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_GEOMETRY> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_GEOMETRY>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_GEOMETRY managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_GEOMETRY managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_GEOMETRY __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_GEOMETRY(native.ToPointer(), skipVTables);
    }

    internal static DISK_GEOMETRY __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_GEOMETRY)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_GEOMETRY __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_GEOMETRY(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_GEOMETRY(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_GEOMETRY(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.MEDIA_TYPE MediaType
    {
        get => ((__Internal*)__Instance)->MediaType;

        set => ((__Internal*)__Instance)->MediaType = value;
    }

    public uint TracksPerCylinder
    {
        get => ((__Internal*)__Instance)->TracksPerCylinder;

        set => ((__Internal*)__Instance)->TracksPerCylinder = value;
    }

    public uint SectorsPerTrack
    {
        get => ((__Internal*)__Instance)->SectorsPerTrack;

        set => ((__Internal*)__Instance)->SectorsPerTrack = value;
    }

    public uint BytesPerSector
    {
        get => ((__Internal*)__Instance)->BytesPerSector;

        set => ((__Internal*)__Instance)->BytesPerSector = value;
    }
}