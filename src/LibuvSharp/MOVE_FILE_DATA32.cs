using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class MOVE_FILE_DATA32 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal uint                             FileHandle;
        internal global::LARGE_INTEGER.__Internal StartingVcn;
        internal global::LARGE_INTEGER.__Internal StartingLcn;
        internal uint                             ClusterCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MOVE_FILE_DATA32> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MOVE_FILE_DATA32>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.MOVE_FILE_DATA32 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.MOVE_FILE_DATA32 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MOVE_FILE_DATA32 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MOVE_FILE_DATA32(native.ToPointer(), skipVTables);
    }

    internal static MOVE_FILE_DATA32 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MOVE_FILE_DATA32)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MOVE_FILE_DATA32 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MOVE_FILE_DATA32(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MOVE_FILE_DATA32(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MOVE_FILE_DATA32(void* native, bool skipVTables = false)
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

    public uint FileHandle
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