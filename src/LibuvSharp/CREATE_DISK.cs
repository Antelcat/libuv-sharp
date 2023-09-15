using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CREATE_DISK : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::LibuvSharp.PARTITION_STYLE PartitionStyle;

        [FieldOffset(4)]
        internal global::LibuvSharp.CREATE_DISK_MBR.__Internal Mbr;

        [FieldOffset(4)]
        internal global::LibuvSharp.CREATE_DISK_GPT.__Internal Gpt;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_DISK> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_DISK>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CREATE_DISK managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CREATE_DISK managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CREATE_DISK __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CREATE_DISK(native.ToPointer(), skipVTables);
    }

    internal static CREATE_DISK __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CREATE_DISK)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CREATE_DISK __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CREATE_DISK(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CREATE_DISK(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CREATE_DISK(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.CREATE_DISK_MBR Mbr
    {
        get => global::LibuvSharp.CREATE_DISK_MBR.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mbr));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mbr = *(global::LibuvSharp.CREATE_DISK_MBR.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.CREATE_DISK_GPT Gpt
    {
        get => global::LibuvSharp.CREATE_DISK_GPT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Gpt));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Gpt = *(global::LibuvSharp.CREATE_DISK_GPT.__Internal*) value.__Instance;
        }
    }
}