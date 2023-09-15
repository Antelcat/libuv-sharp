using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvStatfsS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 88)]
    public partial struct __Internal
    {
        internal       ulong f_type;
        internal       ulong f_bsize;
        internal       ulong f_blocks;
        internal       ulong f_bfree;
        internal       ulong f_bavail;
        internal       ulong f_files;
        internal       ulong f_ffree;
        internal fixed ulong f_spare[4];

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_statfs_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvStatfsS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvStatfsS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvStatfsS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvStatfsS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvStatfsS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvStatfsS(native.ToPointer(), skipVTables);
    }

    internal static UvStatfsS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvStatfsS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvStatfsS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvStatfsS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvStatfsS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvStatfsS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvStatfsS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvStatfsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvStatfsS(global::LibuvSharp.UvStatfsS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvStatfsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvStatfsS.__Internal*) __Instance) = *((global::LibuvSharp.UvStatfsS.__Internal*) _0.__Instance);
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

    public ulong FType
    {
        get => ((__Internal*)__Instance)->f_type;

        set => ((__Internal*)__Instance)->f_type = value;
    }

    public ulong FBsize
    {
        get => ((__Internal*)__Instance)->f_bsize;

        set => ((__Internal*)__Instance)->f_bsize = value;
    }

    public ulong FBlocks
    {
        get => ((__Internal*)__Instance)->f_blocks;

        set => ((__Internal*)__Instance)->f_blocks = value;
    }

    public ulong FBfree
    {
        get => ((__Internal*)__Instance)->f_bfree;

        set => ((__Internal*)__Instance)->f_bfree = value;
    }

    public ulong FBavail
    {
        get => ((__Internal*)__Instance)->f_bavail;

        set => ((__Internal*)__Instance)->f_bavail = value;
    }

    public ulong FFiles
    {
        get => ((__Internal*)__Instance)->f_files;

        set => ((__Internal*)__Instance)->f_files = value;
    }

    public ulong FFfree
    {
        get => ((__Internal*)__Instance)->f_ffree;

        set => ((__Internal*)__Instance)->f_ffree = value;
    }

    public ulong[] FSpare
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->f_spare, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->f_spare[i] = value[i];
            }
        }
    }
}