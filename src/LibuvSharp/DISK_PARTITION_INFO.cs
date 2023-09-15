using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_PARTITION_INFO : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal uint SizeOfPartitionInfo;

        [FieldOffset(4)]
        internal global::LibuvSharp.PARTITION_STYLE PartitionStyle;

        [FieldOffset(8)]
        internal global::LibuvSharp.DISK_PARTITION_INFO._0.Mbr.__Internal Mbr;

        [FieldOffset(8)]
        internal global::LibuvSharp.DISK_PARTITION_INFO._0.Gpt.__Internal Gpt;
    }

    public unsafe partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.DISK_PARTITION_INFO._0.Mbr.__Internal Mbr;

            [FieldOffset(0)]
            internal global::LibuvSharp.DISK_PARTITION_INFO._0.Gpt.__Internal Gpt;
        }

        public unsafe partial class Mbr
        {
            [StructLayout(LayoutKind.Sequential, Size = 8)]
            public partial struct __Internal
            {
                internal uint Signature;
                internal uint CheckSum;
            }
        }

        public unsafe partial class Gpt
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal global::GUID.__Internal DiskId;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_PARTITION_INFO> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_PARTITION_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_PARTITION_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_PARTITION_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_PARTITION_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_PARTITION_INFO(native.ToPointer(), skipVTables);
    }

    internal static DISK_PARTITION_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_PARTITION_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_PARTITION_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_PARTITION_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_PARTITION_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_PARTITION_INFO(void* native, bool skipVTables = false)
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

    public uint SizeOfPartitionInfo
    {
        get => ((__Internal*)__Instance)->SizeOfPartitionInfo;

        set => ((__Internal*)__Instance)->SizeOfPartitionInfo = value;
    }

    public global::LibuvSharp.PARTITION_STYLE PartitionStyle
    {
        get => ((__Internal*)__Instance)->PartitionStyle;

        set => ((__Internal*)__Instance)->PartitionStyle = value;
    }
}