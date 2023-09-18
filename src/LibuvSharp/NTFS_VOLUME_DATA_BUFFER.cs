using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class NTFS_VOLUME_DATA_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 96)]
    public struct __Internal
    {
        internal LARGE_INTEGER.__Internal VolumeSerialNumber;
        internal LARGE_INTEGER.__Internal NumberSectors;
        internal LARGE_INTEGER.__Internal TotalClusters;
        internal LARGE_INTEGER.__Internal FreeClusters;
        internal LARGE_INTEGER.__Internal TotalReserved;
        internal uint                     BytesPerSector;
        internal uint                     BytesPerCluster;
        internal uint                     BytesPerFileRecordSegment;
        internal uint                     ClustersPerFileRecordSegment;
        internal LARGE_INTEGER.__Internal MftValidDataLength;
        internal LARGE_INTEGER.__Internal MftStartLcn;
        internal LARGE_INTEGER.__Internal Mft2StartLcn;
        internal LARGE_INTEGER.__Internal MftZoneStart;
        internal LARGE_INTEGER.__Internal MftZoneEnd;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, NTFS_VOLUME_DATA_BUFFER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, NTFS_VOLUME_DATA_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, NTFS_VOLUME_DATA_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out NTFS_VOLUME_DATA_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static NTFS_VOLUME_DATA_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new NTFS_VOLUME_DATA_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static NTFS_VOLUME_DATA_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (NTFS_VOLUME_DATA_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static NTFS_VOLUME_DATA_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new NTFS_VOLUME_DATA_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private NTFS_VOLUME_DATA_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected NTFS_VOLUME_DATA_BUFFER(void* native, bool skipVTables = false)
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

    public uint BytesPerSector
    {
        get => ((__Internal*)__Instance)->BytesPerSector;

        set => ((__Internal*)__Instance)->BytesPerSector = value;
    }

    public uint BytesPerCluster
    {
        get => ((__Internal*)__Instance)->BytesPerCluster;

        set => ((__Internal*)__Instance)->BytesPerCluster = value;
    }

    public uint BytesPerFileRecordSegment
    {
        get => ((__Internal*)__Instance)->BytesPerFileRecordSegment;

        set => ((__Internal*)__Instance)->BytesPerFileRecordSegment = value;
    }

    public uint ClustersPerFileRecordSegment
    {
        get => ((__Internal*)__Instance)->ClustersPerFileRecordSegment;

        set => ((__Internal*)__Instance)->ClustersPerFileRecordSegment = value;
    }
}