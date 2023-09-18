using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_LOGGING : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public struct __Internal
    {
        internal byte     Function;
        internal IntPtr BufferAddress;
        internal uint     BufferSize;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DISK_LOGGING> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DISK_LOGGING>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DISK_LOGGING managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DISK_LOGGING managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_LOGGING __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_LOGGING(native.ToPointer(), skipVTables);
    }

    internal static DISK_LOGGING __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_LOGGING)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_LOGGING __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_LOGGING(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_LOGGING(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_LOGGING(void* native, bool skipVTables = false)
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

    public byte Function
    {
        get => ((__Internal*)__Instance)->Function;

        set => ((__Internal*)__Instance)->Function = value;
    }

    public IntPtr BufferAddress
    {
        get => ((__Internal*)__Instance)->BufferAddress;

        set => ((__Internal*)__Instance)->BufferAddress = value;
    }

    public uint BufferSize
    {
        get => ((__Internal*)__Instance)->BufferSize;

        set => ((__Internal*)__Instance)->BufferSize = value;
    }
}