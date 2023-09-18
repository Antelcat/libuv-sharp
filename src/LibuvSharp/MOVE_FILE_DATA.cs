using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class MOVE_FILE_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal IntPtr                   FileHandle;
        internal LARGE_INTEGER.__Internal StartingVcn;
        internal LARGE_INTEGER.__Internal StartingLcn;
        internal uint                     ClusterCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, MOVE_FILE_DATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, MOVE_FILE_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, MOVE_FILE_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MOVE_FILE_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MOVE_FILE_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MOVE_FILE_DATA(native.ToPointer(), skipVTables);
    }

    internal static MOVE_FILE_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MOVE_FILE_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MOVE_FILE_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MOVE_FILE_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MOVE_FILE_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MOVE_FILE_DATA(void* native, bool skipVTables = false)
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

    public IntPtr FileHandle
    {
        get => ((__Internal*)__Instance)->FileHandle;

        set => ((__Internal*)__Instance)->FileHandle = value;
    }

    public uint ClusterCount
    {
        get => ((__Internal*)__Instance)->ClusterCount;

        set => ((__Internal*)__Instance)->ClusterCount = value;
    }
}