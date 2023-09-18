using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class NTFS_EXTENDED_VOLUME_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal uint   ByteCount;
        internal ushort MajorVersion;
        internal ushort MinorVersion;
        internal uint   BytesPerPhysicalSector;
        internal ushort LfsMajorVersion;
        internal ushort LfsMinorVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, NTFS_EXTENDED_VOLUME_DATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, NTFS_EXTENDED_VOLUME_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, NTFS_EXTENDED_VOLUME_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out NTFS_EXTENDED_VOLUME_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static NTFS_EXTENDED_VOLUME_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new NTFS_EXTENDED_VOLUME_DATA(native.ToPointer(), skipVTables);
    }

    internal static NTFS_EXTENDED_VOLUME_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (NTFS_EXTENDED_VOLUME_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static NTFS_EXTENDED_VOLUME_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new NTFS_EXTENDED_VOLUME_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private NTFS_EXTENDED_VOLUME_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected NTFS_EXTENDED_VOLUME_DATA(void* native, bool skipVTables = false)
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

    public uint ByteCount
    {
        get => ((__Internal*)__Instance)->ByteCount;

        set => ((__Internal*)__Instance)->ByteCount = value;
    }

    public ushort MajorVersion
    {
        get => ((__Internal*)__Instance)->MajorVersion;

        set => ((__Internal*)__Instance)->MajorVersion = value;
    }

    public ushort MinorVersion
    {
        get => ((__Internal*)__Instance)->MinorVersion;

        set => ((__Internal*)__Instance)->MinorVersion = value;
    }

    public uint BytesPerPhysicalSector
    {
        get => ((__Internal*)__Instance)->BytesPerPhysicalSector;

        set => ((__Internal*)__Instance)->BytesPerPhysicalSector = value;
    }

    public ushort LfsMajorVersion
    {
        get => ((__Internal*)__Instance)->LfsMajorVersion;

        set => ((__Internal*)__Instance)->LfsMajorVersion = value;
    }

    public ushort LfsMinorVersion
    {
        get => ((__Internal*)__Instance)->LfsMinorVersion;

        set => ((__Internal*)__Instance)->LfsMinorVersion = value;
    }
}