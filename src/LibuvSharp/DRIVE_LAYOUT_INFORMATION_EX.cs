using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DRIVE_LAYOUT_INFORMATION_EX : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal uint PartitionStyle;

        [FieldOffset(4)]
        internal uint PartitionCount;

        [FieldOffset(8)]
        internal global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_MBR.__Internal Mbr;

        [FieldOffset(8)]
        internal global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT.__Internal Gpt;

        [FieldOffset(48)]
        internal fixed byte PartitionEntry[144];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DRIVE_LAYOUT_INFORMATION_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DRIVE_LAYOUT_INFORMATION_EX(native.ToPointer(), skipVTables);
    }

    internal static DRIVE_LAYOUT_INFORMATION_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DRIVE_LAYOUT_INFORMATION_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DRIVE_LAYOUT_INFORMATION_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DRIVE_LAYOUT_INFORMATION_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DRIVE_LAYOUT_INFORMATION_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DRIVE_LAYOUT_INFORMATION_EX(void* native, bool skipVTables = false)
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

    public uint PartitionStyle
    {
        get => ((__Internal*)__Instance)->PartitionStyle;

        set => ((__Internal*)__Instance)->PartitionStyle = value;
    }

    public uint PartitionCount
    {
        get => ((__Internal*)__Instance)->PartitionCount;

        set => ((__Internal*)__Instance)->PartitionCount = value;
    }

    public global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_MBR Mbr
    {
        get => global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_MBR.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mbr));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mbr = *(global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_MBR.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT Gpt
    {
        get => global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Gpt));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Gpt = *(global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.PARTITION_INFORMATION_EX[] PartitionEntry
    {
        get
        {
            global::LibuvSharp.PARTITION_INFORMATION_EX[] __value = null;
            if (((__Internal*)__Instance)->PartitionEntry != null)
            {
                __value = new global::LibuvSharp.PARTITION_INFORMATION_EX[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = global::LibuvSharp.PARTITION_INFORMATION_EX.__GetOrCreateInstance((IntPtr)((global::LibuvSharp.PARTITION_INFORMATION_EX.__Internal*)&(((__Internal*)__Instance)->PartitionEntry[i * sizeof(global::LibuvSharp.PARTITION_INFORMATION_EX.__Internal)])), true, true);
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
                    *(global::LibuvSharp.PARTITION_INFORMATION_EX.__Internal*) &((__Internal*)__Instance)->PartitionEntry[i * sizeof(global::LibuvSharp.PARTITION_INFORMATION_EX.__Internal)] = *(global::LibuvSharp.PARTITION_INFORMATION_EX.__Internal*)value[i].__Instance;
            }
        }
    }
}