using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class RETRIEVAL_POINTER_COUNT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal uint ExtentCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, RETRIEVAL_POINTER_COUNT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, RETRIEVAL_POINTER_COUNT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, RETRIEVAL_POINTER_COUNT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out RETRIEVAL_POINTER_COUNT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static RETRIEVAL_POINTER_COUNT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new RETRIEVAL_POINTER_COUNT(native.ToPointer(), skipVTables);
    }

    internal static RETRIEVAL_POINTER_COUNT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (RETRIEVAL_POINTER_COUNT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static RETRIEVAL_POINTER_COUNT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new RETRIEVAL_POINTER_COUNT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private RETRIEVAL_POINTER_COUNT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected RETRIEVAL_POINTER_COUNT(void* native, bool skipVTables = false)
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

    public uint ExtentCount
    {
        get => ((__Internal*)__Instance)->ExtentCount;

        set => ((__Internal*)__Instance)->ExtentCount = value;
    }
}