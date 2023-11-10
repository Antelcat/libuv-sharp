using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvRusageT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 128)]
    public struct __Internal
    {
        internal UvTimevalT.__Internal ru_utime;
        internal UvTimevalT.__Internal ru_stime;
        internal ulong                 ru_maxrss;
        internal ulong                 ru_ixrss;
        internal ulong                 ru_idrss;
        internal ulong                 ru_isrss;
        internal ulong                 ru_minflt;
        internal ulong                 ru_majflt;
        internal ulong                 ru_nswap;
        internal ulong                 ru_inblock;
        internal ulong                 ru_oublock;
        internal ulong                 ru_msgsnd;
        internal ulong                 ru_msgrcv;
        internal ulong                 ru_nsignals;
        internal ulong                 ru_nvcsw;
        internal ulong                 ru_nivcsw;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_rusage_t@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvRusageT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvRusageT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvRusageT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvRusageT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvRusageT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvRusageT(native.ToPointer(), skipVTables);
    }

    internal static UvRusageT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvRusageT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvRusageT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvRusageT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvRusageT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvRusageT(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvRusageT()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvRusageT(UvRusageT __0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*) __Instance = *(__Internal*) __0.__Instance;
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

    public UvTimevalT RuUtime
    {
        get => UvTimevalT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->ru_utime));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->ru_utime = *(UvTimevalT.__Internal*) value.__Instance;
        }
    }

    public UvTimevalT RuStime
    {
        get => UvTimevalT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->ru_stime));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->ru_stime = *(UvTimevalT.__Internal*) value.__Instance;
        }
    }

    public ulong RuMaxrss
    {
        get => ((__Internal*)__Instance)->ru_maxrss;

        set => ((__Internal*)__Instance)->ru_maxrss = value;
    }

    public ulong RuIxrss
    {
        get => ((__Internal*)__Instance)->ru_ixrss;

        set => ((__Internal*)__Instance)->ru_ixrss = value;
    }

    public ulong RuIdrss
    {
        get => ((__Internal*)__Instance)->ru_idrss;

        set => ((__Internal*)__Instance)->ru_idrss = value;
    }

    public ulong RuIsrss
    {
        get => ((__Internal*)__Instance)->ru_isrss;

        set => ((__Internal*)__Instance)->ru_isrss = value;
    }

    public ulong RuMinflt
    {
        get => ((__Internal*)__Instance)->ru_minflt;

        set => ((__Internal*)__Instance)->ru_minflt = value;
    }

    public ulong RuMajflt
    {
        get => ((__Internal*)__Instance)->ru_majflt;

        set => ((__Internal*)__Instance)->ru_majflt = value;
    }

    public ulong RuNswap
    {
        get => ((__Internal*)__Instance)->ru_nswap;

        set => ((__Internal*)__Instance)->ru_nswap = value;
    }

    public ulong RuInblock
    {
        get => ((__Internal*)__Instance)->ru_inblock;

        set => ((__Internal*)__Instance)->ru_inblock = value;
    }

    public ulong RuOublock
    {
        get => ((__Internal*)__Instance)->ru_oublock;

        set => ((__Internal*)__Instance)->ru_oublock = value;
    }

    public ulong RuMsgsnd
    {
        get => ((__Internal*)__Instance)->ru_msgsnd;

        set => ((__Internal*)__Instance)->ru_msgsnd = value;
    }

    public ulong RuMsgrcv
    {
        get => ((__Internal*)__Instance)->ru_msgrcv;

        set => ((__Internal*)__Instance)->ru_msgrcv = value;
    }

    public ulong RuNsignals
    {
        get => ((__Internal*)__Instance)->ru_nsignals;

        set => ((__Internal*)__Instance)->ru_nsignals = value;
    }

    public ulong RuNvcsw
    {
        get => ((__Internal*)__Instance)->ru_nvcsw;

        set => ((__Internal*)__Instance)->ru_nvcsw = value;
    }

    public ulong RuNivcsw
    {
        get => ((__Internal*)__Instance)->ru_nivcsw;

        set => ((__Internal*)__Instance)->ru_nivcsw = value;
    }
}