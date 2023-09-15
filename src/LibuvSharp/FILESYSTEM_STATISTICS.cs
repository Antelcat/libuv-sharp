using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILESYSTEM_STATISTICS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 56)]
    public partial struct __Internal
    {
        internal ushort FileSystemType;
        internal ushort Version;
        internal uint   SizeOfCompleteStructure;
        internal uint   UserFileReads;
        internal uint   UserFileReadBytes;
        internal uint   UserDiskReads;
        internal uint   UserFileWrites;
        internal uint   UserFileWriteBytes;
        internal uint   UserDiskWrites;
        internal uint   MetaDataReads;
        internal uint   MetaDataReadBytes;
        internal uint   MetaDataDiskReads;
        internal uint   MetaDataWrites;
        internal uint   MetaDataWriteBytes;
        internal uint   MetaDataDiskWrites;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILESYSTEM_STATISTICS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILESYSTEM_STATISTICS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FILESYSTEM_STATISTICS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FILESYSTEM_STATISTICS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILESYSTEM_STATISTICS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILESYSTEM_STATISTICS(native.ToPointer(), skipVTables);
    }

    internal static FILESYSTEM_STATISTICS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILESYSTEM_STATISTICS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILESYSTEM_STATISTICS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILESYSTEM_STATISTICS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILESYSTEM_STATISTICS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILESYSTEM_STATISTICS(void* native, bool skipVTables = false)
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

    public uint UserFileReads
    {
        get => ((__Internal*)__Instance)->UserFileReads;

        set => ((__Internal*)__Instance)->UserFileReads = value;
    }

    public uint UserFileReadBytes
    {
        get => ((__Internal*)__Instance)->UserFileReadBytes;

        set => ((__Internal*)__Instance)->UserFileReadBytes = value;
    }

    public uint UserDiskReads
    {
        get => ((__Internal*)__Instance)->UserDiskReads;

        set => ((__Internal*)__Instance)->UserDiskReads = value;
    }

    public uint UserFileWrites
    {
        get => ((__Internal*)__Instance)->UserFileWrites;

        set => ((__Internal*)__Instance)->UserFileWrites = value;
    }

    public uint UserFileWriteBytes
    {
        get => ((__Internal*)__Instance)->UserFileWriteBytes;

        set => ((__Internal*)__Instance)->UserFileWriteBytes = value;
    }

    public uint UserDiskWrites
    {
        get => ((__Internal*)__Instance)->UserDiskWrites;

        set => ((__Internal*)__Instance)->UserDiskWrites = value;
    }

    public uint MetaDataReads
    {
        get => ((__Internal*)__Instance)->MetaDataReads;

        set => ((__Internal*)__Instance)->MetaDataReads = value;
    }

    public uint MetaDataReadBytes
    {
        get => ((__Internal*)__Instance)->MetaDataReadBytes;

        set => ((__Internal*)__Instance)->MetaDataReadBytes = value;
    }

    public uint MetaDataDiskReads
    {
        get => ((__Internal*)__Instance)->MetaDataDiskReads;

        set => ((__Internal*)__Instance)->MetaDataDiskReads = value;
    }

    public uint MetaDataWrites
    {
        get => ((__Internal*)__Instance)->MetaDataWrites;

        set => ((__Internal*)__Instance)->MetaDataWrites = value;
    }

    public uint MetaDataWriteBytes
    {
        get => ((__Internal*)__Instance)->MetaDataWriteBytes;

        set => ((__Internal*)__Instance)->MetaDataWriteBytes = value;
    }

    public uint MetaDataDiskWrites
    {
        get => ((__Internal*)__Instance)->MetaDataDiskWrites;

        set => ((__Internal*)__Instance)->MetaDataDiskWrites = value;
    }
}