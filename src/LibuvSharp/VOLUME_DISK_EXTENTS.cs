using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class VOLUME_DISK_EXTENTS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal       uint NumberOfDiskExtents;
        internal fixed byte ExtentsPadding[4];
        internal fixed byte Extents[24];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, VOLUME_DISK_EXTENTS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, VOLUME_DISK_EXTENTS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, VOLUME_DISK_EXTENTS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out VOLUME_DISK_EXTENTS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static VOLUME_DISK_EXTENTS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new VOLUME_DISK_EXTENTS(native.ToPointer(), skipVTables);
    }

    internal static VOLUME_DISK_EXTENTS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (VOLUME_DISK_EXTENTS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static VOLUME_DISK_EXTENTS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new VOLUME_DISK_EXTENTS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private VOLUME_DISK_EXTENTS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected VOLUME_DISK_EXTENTS(void* native, bool skipVTables = false)
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

    public uint NumberOfDiskExtents
    {
        get => ((__Internal*)__Instance)->NumberOfDiskExtents;

        set => ((__Internal*)__Instance)->NumberOfDiskExtents = value;
    }

    public DISK_EXTENT[] Extents
    {
        get
        {
            DISK_EXTENT[] __value = null;
            if (((__Internal*)__Instance)->Extents != null)
            {
                __value = new DISK_EXTENT[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = DISK_EXTENT.__GetOrCreateInstance((IntPtr)((DISK_EXTENT.__Internal*)&(((__Internal*)__Instance)->Extents[i * sizeof(DISK_EXTENT.__Internal)])), true, true);
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
                    *(DISK_EXTENT.__Internal*) &((__Internal*)__Instance)->Extents[i * sizeof(DISK_EXTENT.__Internal)] = *(DISK_EXTENT.__Internal*)value[i].__Instance;
            }
        }
    }
}