using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvPasswdS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal IntPtr username;
        internal uint     uid;
        internal uint     gid;
        internal IntPtr shell;
        internal IntPtr homedir;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_passwd_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvPasswdS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvPasswdS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvPasswdS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvPasswdS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvPasswdS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvPasswdS(native.ToPointer(), skipVTables);
    }

    internal static UvPasswdS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvPasswdS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvPasswdS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvPasswdS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvPasswdS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvPasswdS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvPasswdS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvPasswdS(UvPasswdS _0)
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

    public sbyte* Username
    {
        get => (sbyte*) ((__Internal*)__Instance)->username;

        set => ((__Internal*)__Instance)->username = (IntPtr) value;
    }

    public uint Uid
    {
        get => ((__Internal*)__Instance)->uid;

        set => ((__Internal*)__Instance)->uid = value;
    }

    public uint Gid
    {
        get => ((__Internal*)__Instance)->gid;

        set => ((__Internal*)__Instance)->gid = value;
    }

    public sbyte* Shell
    {
        get => (sbyte*) ((__Internal*)__Instance)->shell;

        set => ((__Internal*)__Instance)->shell = (IntPtr) value;
    }

    public sbyte* Homedir
    {
        get => (sbyte*) ((__Internal*)__Instance)->homedir;

        set => ((__Internal*)__Instance)->homedir = (IntPtr) value;
    }
}