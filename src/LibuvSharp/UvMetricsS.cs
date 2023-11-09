using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvMetricsS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 128)]
    public struct __Internal
    {
        internal ulong    loop_count;
        internal ulong    events;
        internal ulong    events_waiting;
        internal IntPtr reserved;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_metrics_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvMetricsS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvMetricsS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvMetricsS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvMetricsS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvMetricsS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvMetricsS(native.ToPointer(), skipVTables);
    }

    internal static UvMetricsS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvMetricsS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvMetricsS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvMetricsS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvMetricsS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvMetricsS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvMetricsS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvMetricsS(UvMetricsS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*) __Instance = *(__Internal*) _0.__Instance;
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

    public ulong LoopCount
    {
        get => ((__Internal*)__Instance)->loop_count;

        set => ((__Internal*)__Instance)->loop_count = value;
    }

    public ulong Events
    {
        get => ((__Internal*)__Instance)->events;

        set => ((__Internal*)__Instance)->events = value;
    }

    public ulong EventsWaiting
    {
        get => ((__Internal*)__Instance)->events_waiting;

        set => ((__Internal*)__Instance)->events_waiting = value;
    }

    private ulong*[] __reserved;

    private bool __reservedInitialised;
    public ulong*[] Reserved
    {
        get
        {
            if (!__reservedInitialised)
            {
                __reserved            = null;
                __reservedInitialised = true;
            }
            return __reserved;
        }

        set
        {
            __reserved = value;
            if (!__reservedInitialised)
            {
                __reservedInitialised = true;
            }
        }
    }
}