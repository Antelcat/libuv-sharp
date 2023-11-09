using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DRIVE_LAYOUT_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal       uint PartitionCount;
        internal       uint Signature;
        internal fixed byte PartitionEntry[32];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DRIVE_LAYOUT_INFORMATION> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DRIVE_LAYOUT_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DRIVE_LAYOUT_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DRIVE_LAYOUT_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DRIVE_LAYOUT_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DRIVE_LAYOUT_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static DRIVE_LAYOUT_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DRIVE_LAYOUT_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DRIVE_LAYOUT_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DRIVE_LAYOUT_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DRIVE_LAYOUT_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DRIVE_LAYOUT_INFORMATION(void* native, bool skipVTables = false)
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

    public uint PartitionCount
    {
        get => ((__Internal*)__Instance)->PartitionCount;

        set => ((__Internal*)__Instance)->PartitionCount = value;
    }

    public uint Signature
    {
        get => ((__Internal*)__Instance)->Signature;

        set => ((__Internal*)__Instance)->Signature = value;
    }

    public PARTITION_INFORMATION[] PartitionEntry
    {
        get
        {
            PARTITION_INFORMATION[] __value = null;
            if (((__Internal*)__Instance)->PartitionEntry != null)
            {
                __value = new PARTITION_INFORMATION[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = PARTITION_INFORMATION.__GetOrCreateInstance((IntPtr)(PARTITION_INFORMATION.__Internal*)&((__Internal*)__Instance)->PartitionEntry[i * sizeof(PARTITION_INFORMATION.__Internal)], true, true);
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
                    *(PARTITION_INFORMATION.__Internal*) &((__Internal*)__Instance)->PartitionEntry[i * sizeof(PARTITION_INFORMATION.__Internal)] = *(PARTITION_INFORMATION.__Internal*)value[i].__Instance;
            }
        }
    }
}