using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_INT13INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal ushort DriveSelect;
        internal uint   MaxCylinders;
        internal ushort SectorsPerTrack;
        internal ushort MaxHeads;
        internal ushort NumberDrives;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_INT13INFO> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_INT13INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_INT13INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_INT13INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_INT13INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_INT13INFO(native.ToPointer(), skipVTables);
    }

    internal static DISK_INT13INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_INT13INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_INT13INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_INT13INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_INT13INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_INT13INFO(void* native, bool skipVTables = false)
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

    public ushort DriveSelect
    {
        get => ((__Internal*)__Instance)->DriveSelect;

        set => ((__Internal*)__Instance)->DriveSelect = value;
    }

    public uint MaxCylinders
    {
        get => ((__Internal*)__Instance)->MaxCylinders;

        set => ((__Internal*)__Instance)->MaxCylinders = value;
    }

    public ushort SectorsPerTrack
    {
        get => ((__Internal*)__Instance)->SectorsPerTrack;

        set => ((__Internal*)__Instance)->SectorsPerTrack = value;
    }

    public ushort MaxHeads
    {
        get => ((__Internal*)__Instance)->MaxHeads;

        set => ((__Internal*)__Instance)->MaxHeads = value;
    }

    public ushort NumberDrives
    {
        get => ((__Internal*)__Instance)->NumberDrives;

        set => ((__Internal*)__Instance)->NumberDrives = value;
    }
}