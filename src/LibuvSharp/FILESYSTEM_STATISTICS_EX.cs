using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILESYSTEM_STATISTICS_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 104)]
    public struct __Internal
    {
        internal ushort FileSystemType;
        internal ushort Version;
        internal uint   SizeOfCompleteStructure;
        internal ulong  UserFileReads;
        internal ulong  UserFileReadBytes;
        internal ulong  UserDiskReads;
        internal ulong  UserFileWrites;
        internal ulong  UserFileWriteBytes;
        internal ulong  UserDiskWrites;
        internal ulong  MetaDataReads;
        internal ulong  MetaDataReadBytes;
        internal ulong  MetaDataDiskReads;
        internal ulong  MetaDataWrites;
        internal ulong  MetaDataWriteBytes;
        internal ulong  MetaDataDiskWrites;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, FILESYSTEM_STATISTICS_EX> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, FILESYSTEM_STATISTICS_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, FILESYSTEM_STATISTICS_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out FILESYSTEM_STATISTICS_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILESYSTEM_STATISTICS_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILESYSTEM_STATISTICS_EX(native.ToPointer(), skipVTables);
    }

    internal static FILESYSTEM_STATISTICS_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILESYSTEM_STATISTICS_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILESYSTEM_STATISTICS_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILESYSTEM_STATISTICS_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILESYSTEM_STATISTICS_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILESYSTEM_STATISTICS_EX(void* native, bool skipVTables = false)
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

    public ushort FileSystemType
    {
        get => ((__Internal*)__Instance)->FileSystemType;

        set => ((__Internal*)__Instance)->FileSystemType = value;
    }

    public ushort Version
    {
        get => ((__Internal*)__Instance)->Version;

        set => ((__Internal*)__Instance)->Version = value;
    }

    public uint SizeOfCompleteStructure
    {
        get => ((__Internal*)__Instance)->SizeOfCompleteStructure;

        set => ((__Internal*)__Instance)->SizeOfCompleteStructure = value;
    }

    public ulong UserFileReads
    {
        get => ((__Internal*)__Instance)->UserFileReads;

        set => ((__Internal*)__Instance)->UserFileReads = value;
    }

    public ulong UserFileReadBytes
    {
        get => ((__Internal*)__Instance)->UserFileReadBytes;

        set => ((__Internal*)__Instance)->UserFileReadBytes = value;
    }

    public ulong UserDiskReads
    {
        get => ((__Internal*)__Instance)->UserDiskReads;

        set => ((__Internal*)__Instance)->UserDiskReads = value;
    }

    public ulong UserFileWrites
    {
        get => ((__Internal*)__Instance)->UserFileWrites;

        set => ((__Internal*)__Instance)->UserFileWrites = value;
    }

    public ulong UserFileWriteBytes
    {
        get => ((__Internal*)__Instance)->UserFileWriteBytes;

        set => ((__Internal*)__Instance)->UserFileWriteBytes = value;
    }

    public ulong UserDiskWrites
    {
        get => ((__Internal*)__Instance)->UserDiskWrites;

        set => ((__Internal*)__Instance)->UserDiskWrites = value;
    }

    public ulong MetaDataReads
    {
        get => ((__Internal*)__Instance)->MetaDataReads;

        set => ((__Internal*)__Instance)->MetaDataReads = value;
    }

    public ulong MetaDataReadBytes
    {
        get => ((__Internal*)__Instance)->MetaDataReadBytes;

        set => ((__Internal*)__Instance)->MetaDataReadBytes = value;
    }

    public ulong MetaDataDiskReads
    {
        get => ((__Internal*)__Instance)->MetaDataDiskReads;

        set => ((__Internal*)__Instance)->MetaDataDiskReads = value;
    }

    public ulong MetaDataWrites
    {
        get => ((__Internal*)__Instance)->MetaDataWrites;

        set => ((__Internal*)__Instance)->MetaDataWrites = value;
    }

    public ulong MetaDataWriteBytes
    {
        get => ((__Internal*)__Instance)->MetaDataWriteBytes;

        set => ((__Internal*)__Instance)->MetaDataWriteBytes = value;
    }

    public ulong MetaDataDiskWrites
    {
        get => ((__Internal*)__Instance)->MetaDataDiskWrites;

        set => ((__Internal*)__Instance)->MetaDataDiskWrites = value;
    }
}