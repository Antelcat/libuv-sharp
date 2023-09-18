using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_RECORD : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal LARGE_INTEGER.__Internal ByteOffset;
        internal LARGE_INTEGER.__Internal StartTime;
        internal LARGE_INTEGER.__Internal EndTime;
        internal IntPtr                   VirtualAddress;
        internal uint                     NumberOfBytes;
        internal byte                     DeviceNumber;
        internal byte                     ReadRequest;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DISK_RECORD> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DISK_RECORD>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DISK_RECORD managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DISK_RECORD managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_RECORD __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_RECORD(native.ToPointer(), skipVTables);
    }

    internal static DISK_RECORD __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_RECORD)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_RECORD __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_RECORD(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_RECORD(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_RECORD(void* native, bool skipVTables = false)
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

    public IntPtr VirtualAddress
    {
        get => ((__Internal*)__Instance)->VirtualAddress;

        set => ((__Internal*)__Instance)->VirtualAddress = value;
    }

    public uint NumberOfBytes
    {
        get => ((__Internal*)__Instance)->NumberOfBytes;

        set => ((__Internal*)__Instance)->NumberOfBytes = value;
    }

    public byte DeviceNumber
    {
        get => ((__Internal*)__Instance)->DeviceNumber;

        set => ((__Internal*)__Instance)->DeviceNumber = value;
    }

    public byte ReadRequest
    {
        get => ((__Internal*)__Instance)->ReadRequest;

        set => ((__Internal*)__Instance)->ReadRequest = value;
    }
}