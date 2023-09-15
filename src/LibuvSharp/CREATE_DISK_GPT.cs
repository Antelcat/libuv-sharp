using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CREATE_DISK_GPT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 20)]
    public partial struct __Internal
    {
        internal global::GUID.__Internal DiskId;
        internal uint                    MaxPartitionCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_DISK_GPT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_DISK_GPT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CREATE_DISK_GPT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CREATE_DISK_GPT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CREATE_DISK_GPT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CREATE_DISK_GPT(native.ToPointer(), skipVTables);
    }

    internal static CREATE_DISK_GPT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CREATE_DISK_GPT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CREATE_DISK_GPT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CREATE_DISK_GPT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CREATE_DISK_GPT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CREATE_DISK_GPT(void* native, bool skipVTables = false)
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

    public uint MaxPartitionCount
    {
        get => ((__Internal*)__Instance)->MaxPartitionCount;

        set => ((__Internal*)__Instance)->MaxPartitionCount = value;
    }
}