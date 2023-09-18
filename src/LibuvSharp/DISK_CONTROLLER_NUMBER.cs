using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_CONTROLLER_NUMBER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal uint ControllerNumber;
        internal uint DiskNumber;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DISK_CONTROLLER_NUMBER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DISK_CONTROLLER_NUMBER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DISK_CONTROLLER_NUMBER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DISK_CONTROLLER_NUMBER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_CONTROLLER_NUMBER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_CONTROLLER_NUMBER(native.ToPointer(), skipVTables);
    }

    internal static DISK_CONTROLLER_NUMBER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_CONTROLLER_NUMBER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_CONTROLLER_NUMBER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_CONTROLLER_NUMBER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_CONTROLLER_NUMBER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_CONTROLLER_NUMBER(void* native, bool skipVTables = false)
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

    public uint ControllerNumber
    {
        get => ((__Internal*)__Instance)->ControllerNumber;

        set => ((__Internal*)__Instance)->ControllerNumber = value;
    }

    public uint DiskNumber
    {
        get => ((__Internal*)__Instance)->DiskNumber;

        set => ((__Internal*)__Instance)->DiskNumber = value;
    }
}