using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CREATE_DISK : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal PARTITION_STYLE PartitionStyle;

        [FieldOffset(4)]
        internal CREATE_DISK_MBR.__Internal Mbr;

        [FieldOffset(4)]
        internal CREATE_DISK_GPT.__Internal Gpt;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, CREATE_DISK> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, CREATE_DISK>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, CREATE_DISK managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out CREATE_DISK managed)
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

    public PARTITION_STYLE PartitionStyle
    {
        get => ((__Internal*)__Instance)->PartitionStyle;

        set => ((__Internal*)__Instance)->PartitionStyle = value;
    }

    public CREATE_DISK_MBR Mbr
    {
        get => CREATE_DISK_MBR.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mbr));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mbr = *(CREATE_DISK_MBR.__Internal*) value.__Instance;
        }
    }

    public CREATE_DISK_GPT Gpt
    {
        get => CREATE_DISK_GPT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Gpt));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Gpt = *(CREATE_DISK_GPT.__Internal*) value.__Instance;
        }
    }
}