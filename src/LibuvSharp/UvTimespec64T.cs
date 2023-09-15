using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvTimespec64T : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal long tv_sec;
        internal int  tv_nsec;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_timespec64_t@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvTimespec64T> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvTimespec64T>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvTimespec64T managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvTimespec64T managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvTimespec64T __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvTimespec64T(native.ToPointer(), skipVTables);
    }

    internal static UvTimespec64T __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvTimespec64T)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvTimespec64T __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvTimespec64T(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvTimespec64T(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvTimespec64T(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvTimespec64T()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvTimespec64T.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvTimespec64T(global::LibuvSharp.UvTimespec64T __0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvTimespec64T.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvTimespec64T.__Internal*) __Instance) = *((global::LibuvSharp.UvTimespec64T.__Internal*) __0.__Instance);
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

    public long TvSec
    {
        get => ((__Internal*)__Instance)->tv_sec;

        set => ((__Internal*)__Instance)->tv_sec = value;
    }

    public int TvNsec
    {
        get => ((__Internal*)__Instance)->tv_nsec;

        set => ((__Internal*)__Instance)->tv_nsec = value;
    }
}