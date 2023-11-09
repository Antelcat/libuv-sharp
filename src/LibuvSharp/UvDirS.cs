using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvDirS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 656)]
    public struct __Internal
    {
        internal IntPtr                     dirents;
        internal ulong                      nentries;
        internal void*                      reserved;
        internal IntPtr                     dir_handle;
        internal WIN32FIND_DATAW.__Internal find_data;
        internal int                        need_find_call;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_dir_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvDirS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvDirS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvDirS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvDirS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvDirS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvDirS(native.ToPointer(), skipVTables);
    }

    internal static UvDirS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvDirS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvDirS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvDirS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvDirS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvDirS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvDirS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvDirS(UvDirS _0)
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

    public uv_dirent_s Dirents
    {
        get
        {
            var __result0 = uv_dirent_s.__GetOrCreateInstance(((__Internal*)__Instance)->dirents);
            return __result0;
        }

        set => ((__Internal*)__Instance)->dirents = value is null ? IntPtr.Zero : value.__Instance;
    }

    public ulong Nentries
    {
        get => ((__Internal*)__Instance)->nentries;

        set => ((__Internal*)__Instance)->nentries = value;
    }

    private IntPtr[] __reserved;

    private bool __reservedInitialised;
    public IntPtr[] Reserved
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

    public IntPtr DirHandle
    {
        get => ((__Internal*)__Instance)->dir_handle;

        set => ((__Internal*)__Instance)->dir_handle = value;
    }

    public int NeedFindCall
    {
        get => ((__Internal*)__Instance)->need_find_call;

        set => ((__Internal*)__Instance)->need_find_call = value;
    }
}