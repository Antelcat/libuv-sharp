using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal uint                                             Size;
        internal VIRTUAL_STORAGE_BEHAVIOR_CODE BehaviorCode;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT(native.ToPointer(), skipVTables);
    }

    internal static VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected VIRTUAL_STORAGE_SET_BEHAVIOR_INPUT(void* native, bool skipVTables = false)
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

    public uint Size
    {
        get => ((__Internal*)__Instance)->Size;

        set => ((__Internal*)__Instance)->Size = value;
    }

    public VIRTUAL_STORAGE_BEHAVIOR_CODE BehaviorCode
    {
        get => ((__Internal*)__Instance)->BehaviorCode;

        set => ((__Internal*)__Instance)->BehaviorCode = value;
    }
}