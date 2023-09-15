using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class STARTING_VCN_INPUT_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public partial struct __Internal
    {
        internal global::LARGE_INTEGER.__Internal StartingVcn;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.STARTING_VCN_INPUT_BUFFER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.STARTING_VCN_INPUT_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.STARTING_VCN_INPUT_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.STARTING_VCN_INPUT_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static STARTING_VCN_INPUT_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new STARTING_VCN_INPUT_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static STARTING_VCN_INPUT_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (STARTING_VCN_INPUT_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static STARTING_VCN_INPUT_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new STARTING_VCN_INPUT_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private STARTING_VCN_INPUT_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected STARTING_VCN_INPUT_BUFFER(void* native, bool skipVTables = false)
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
}