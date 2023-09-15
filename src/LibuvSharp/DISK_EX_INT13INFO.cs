using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_EX_INT13INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal ushort ExBufferSize;
        internal ushort ExFlags;
        internal uint   ExCylinders;
        internal uint   ExHeads;
        internal uint   ExSectorsPerTrack;
        internal ulong  ExSectorsPerDrive;
        internal ushort ExSectorSize;
        internal ushort ExReserved;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_EX_INT13INFO> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_EX_INT13INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_EX_INT13INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_EX_INT13INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_EX_INT13INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_EX_INT13INFO(native.ToPointer(), skipVTables);
    }

    internal static DISK_EX_INT13INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_EX_INT13INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_EX_INT13INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_EX_INT13INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_EX_INT13INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_EX_INT13INFO(void* native, bool skipVTables = false)
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

    public ushort ExBufferSize
    {
        get => ((__Internal*)__Instance)->ExBufferSize;

        set => ((__Internal*)__Instance)->ExBufferSize = value;
    }

    public ushort ExFlags
    {
        get => ((__Internal*)__Instance)->ExFlags;

        set => ((__Internal*)__Instance)->ExFlags = value;
    }

    public uint ExCylinders
    {
        get => ((__Internal*)__Instance)->ExCylinders;

        set => ((__Internal*)__Instance)->ExCylinders = value;
    }

    public uint ExHeads
    {
        get => ((__Internal*)__Instance)->ExHeads;

        set => ((__Internal*)__Instance)->ExHeads = value;
    }

    public uint ExSectorsPerTrack
    {
        get => ((__Internal*)__Instance)->ExSectorsPerTrack;

        set => ((__Internal*)__Instance)->ExSectorsPerTrack = value;
    }

    public ulong ExSectorsPerDrive
    {
        get => ((__Internal*)__Instance)->ExSectorsPerDrive;

        set => ((__Internal*)__Instance)->ExSectorsPerDrive = value;
    }

    public ushort ExSectorSize
    {
        get => ((__Internal*)__Instance)->ExSectorSize;

        set => ((__Internal*)__Instance)->ExSectorSize = value;
    }

    public ushort ExReserved
    {
        get => ((__Internal*)__Instance)->ExReserved;

        set => ((__Internal*)__Instance)->ExReserved = value;
    }
}