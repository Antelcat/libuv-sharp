using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvCpuInfoS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 56)]
    public partial struct __Internal
    {
        internal IntPtr                                  model;
        internal int                                       speed;
        internal global::LibuvSharp.UvCpuTimesS.__Internal cpu_times;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_cpu_info_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvCpuInfoS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvCpuInfoS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvCpuInfoS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvCpuInfoS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvCpuInfoS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvCpuInfoS(native.ToPointer(), skipVTables);
    }

    internal static UvCpuInfoS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvCpuInfoS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvCpuInfoS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvCpuInfoS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvCpuInfoS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvCpuInfoS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvCpuInfoS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvCpuInfoS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvCpuInfoS(global::LibuvSharp.UvCpuInfoS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvCpuInfoS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvCpuInfoS.__Internal*) __Instance) = *((global::LibuvSharp.UvCpuInfoS.__Internal*) _0.__Instance);
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

    public sbyte* Model
    {
        get => (sbyte*) ((__Internal*)__Instance)->model;

        set => ((__Internal*)__Instance)->model = (IntPtr) value;
    }

    public int Speed
    {
        get => ((__Internal*)__Instance)->speed;

        set => ((__Internal*)__Instance)->speed = value;
    }

    public global::LibuvSharp.UvCpuTimesS CpuTimes
    {
        get => global::LibuvSharp.UvCpuTimesS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->cpu_times));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->cpu_times = *(global::LibuvSharp.UvCpuTimesS.__Internal*) value.__Instance;
        }
    }
}