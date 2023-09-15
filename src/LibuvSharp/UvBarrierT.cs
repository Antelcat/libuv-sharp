using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvBarrierT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 64)]
    public partial struct __Internal
    {
        internal uint                                      threshold;
        internal uint                                      @in;
        internal global::RTL_CRITICAL_SECTION.__Internal   mutex;
        internal global::RTL_CONDITION_VARIABLE.__Internal cond;
        internal uint                                      @out;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_barrier_t@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvBarrierT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvBarrierT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvBarrierT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvBarrierT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvBarrierT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvBarrierT(native.ToPointer(), skipVTables);
    }

    internal static UvBarrierT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvBarrierT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvBarrierT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvBarrierT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvBarrierT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvBarrierT(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvBarrierT()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvBarrierT.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvBarrierT(global::LibuvSharp.UvBarrierT __0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvBarrierT.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvBarrierT.__Internal*) __Instance) = *((global::LibuvSharp.UvBarrierT.__Internal*) __0.__Instance);
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

    public uint Threshold
    {
        get => ((__Internal*)__Instance)->threshold;

        set => ((__Internal*)__Instance)->threshold = value;
    }

    public uint In
    {
        get => ((__Internal*)__Instance)->@in;

        set => ((__Internal*)__Instance)->@in = value;
    }

    public uint Out
    {
        get => ((__Internal*)__Instance)->@out;

        set => ((__Internal*)__Instance)->@out = value;
    }
}