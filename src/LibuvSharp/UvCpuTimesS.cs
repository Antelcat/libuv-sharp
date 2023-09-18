using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvCpuTimesS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal ulong user;
        internal ulong nice;
        internal ulong sys;
        internal ulong idle;
        internal ulong irq;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_cpu_times_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvCpuTimesS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvCpuTimesS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvCpuTimesS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvCpuTimesS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvCpuTimesS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvCpuTimesS(native.ToPointer(), skipVTables);
    }

    internal static UvCpuTimesS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvCpuTimesS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvCpuTimesS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvCpuTimesS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvCpuTimesS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvCpuTimesS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvCpuTimesS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvCpuTimesS(UvCpuTimesS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((__Internal*) __Instance) = *((__Internal*) _0.__Instance);
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

    public ulong User
    {
        get => ((__Internal*)__Instance)->user;

        set => ((__Internal*)__Instance)->user = value;
    }

    public ulong Nice
    {
        get => ((__Internal*)__Instance)->nice;

        set => ((__Internal*)__Instance)->nice = value;
    }

    public ulong Sys
    {
        get => ((__Internal*)__Instance)->sys;

        set => ((__Internal*)__Instance)->sys = value;
    }

    public ulong Idle
    {
        get => ((__Internal*)__Instance)->idle;

        set => ((__Internal*)__Instance)->idle = value;
    }

    public ulong Irq
    {
        get => ((__Internal*)__Instance)->irq;

        set => ((__Internal*)__Instance)->irq = value;
    }
}