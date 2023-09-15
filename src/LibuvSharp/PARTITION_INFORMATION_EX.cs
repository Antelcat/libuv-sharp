using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PARTITION_INFORMATION_EX : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::LibuvSharp.PARTITION_STYLE PartitionStyle;

        [FieldOffset(8)]
        internal global::LARGE_INTEGER.__Internal StartingOffset;

        [FieldOffset(16)]
        internal global::LARGE_INTEGER.__Internal PartitionLength;

        [FieldOffset(24)]
        internal uint PartitionNumber;

        [FieldOffset(28)]
        internal byte RewritePartition;

        [FieldOffset(32)]
        internal global::LibuvSharp.PARTITION_INFORMATION_MBR.__Internal Mbr;

        [FieldOffset(32)]
        internal global::LibuvSharp.PARTITION_INFORMATION_GPT.__Internal Gpt;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PARTITION_INFORMATION_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PARTITION_INFORMATION_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PARTITION_INFORMATION_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PARTITION_INFORMATION_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PARTITION_INFORMATION_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PARTITION_INFORMATION_EX(native.ToPointer(), skipVTables);
    }

    internal static PARTITION_INFORMATION_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PARTITION_INFORMATION_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PARTITION_INFORMATION_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PARTITION_INFORMATION_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PARTITION_INFORMATION_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PARTITION_INFORMATION_EX(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.PARTITION_STYLE PartitionStyle
    {
        get => ((__Internal*)__Instance)->PartitionStyle;

        set => ((__Internal*)__Instance)->PartitionStyle = value;
    }

    public uint PartitionNumber
    {
        get => ((__Internal*)__Instance)->PartitionNumber;

        set => ((__Internal*)__Instance)->PartitionNumber = value;
    }

    public byte RewritePartition
    {
        get => ((__Internal*)__Instance)->RewritePartition;

        set => ((__Internal*)__Instance)->RewritePartition = value;
    }

    public global::LibuvSharp.PARTITION_INFORMATION_MBR Mbr
    {
        get => global::LibuvSharp.PARTITION_INFORMATION_MBR.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mbr));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mbr = *(global::LibuvSharp.PARTITION_INFORMATION_MBR.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.PARTITION_INFORMATION_GPT Gpt
    {
        get => global::LibuvSharp.PARTITION_INFORMATION_GPT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Gpt));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Gpt = *(global::LibuvSharp.PARTITION_INFORMATION_GPT.__Internal*) value.__Instance;
        }
    }
}