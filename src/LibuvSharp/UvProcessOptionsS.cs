using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvProcessOptionsS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 64)]
    public partial struct __Internal
    {
        internal IntPtr exit_cb;
        internal IntPtr file;
        internal IntPtr args;
        internal IntPtr env;
        internal IntPtr cwd;
        internal uint     flags;
        internal int      stdio_count;
        internal IntPtr stdio;
        internal byte     uid;
        internal byte     gid;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_process_options_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessOptionsS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessOptionsS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvProcessOptionsS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvProcessOptionsS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __file_OwnsNativeMemory = false;
    private   bool __cwd_OwnsNativeMemory  = false;
    protected bool __ownsNativeInstance;

    internal static UvProcessOptionsS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvProcessOptionsS(native.ToPointer(), skipVTables);
    }

    internal static UvProcessOptionsS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvProcessOptionsS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvProcessOptionsS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvProcessOptionsS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvProcessOptionsS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvProcessOptionsS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvProcessOptionsS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessOptionsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvProcessOptionsS(global::LibuvSharp.UvProcessOptionsS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessOptionsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvProcessOptionsS.__Internal*) __Instance) = *((global::LibuvSharp.UvProcessOptionsS.__Internal*) _0.__Instance);
        if (_0.__file_OwnsNativeMemory)
            this.File = _0.File;
        if (_0.__cwd_OwnsNativeMemory)
            this.Cwd = _0.Cwd;
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
        if (__file_OwnsNativeMemory)
            Marshal.FreeHGlobal(((__Internal*)__Instance)->file);
        if (__cwd_OwnsNativeMemory)
            Marshal.FreeHGlobal(((__Internal*)__Instance)->cwd);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public global::LibuvSharp.UvExitCb ExitCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->exit_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvExitCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvExitCb));
        }

        set => ((__Internal*)__Instance)->exit_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public string File
    {
        get => CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->file);

        set
        {
            if (__file_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->file);
            __file_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->file = global::System.IntPtr.Zero;
                return;
            }
            var __bytes0   = global::System.Text.Encoding.UTF8.GetBytes(value);
            var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
            Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
            Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
            ((__Internal*)__Instance)->file = (IntPtr) __bytePtr0;
        }
    }

    public sbyte** Args
    {
        get => (sbyte**) ((__Internal*)__Instance)->args;

        set => ((__Internal*)__Instance)->args = (IntPtr) value;
    }

    public sbyte** Env
    {
        get => (sbyte**) ((__Internal*)__Instance)->env;

        set => ((__Internal*)__Instance)->env = (IntPtr) value;
    }

    public string Cwd
    {
        get => CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->cwd);

        set
        {
            if (__cwd_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->cwd);
            __cwd_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->cwd = global::System.IntPtr.Zero;
                return;
            }
            var __bytes0   = global::System.Text.Encoding.UTF8.GetBytes(value);
            var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
            Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
            Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
            ((__Internal*)__Instance)->cwd = (IntPtr) __bytePtr0;
        }
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
    }

    public int StdioCount
    {
        get => ((__Internal*)__Instance)->stdio_count;

        set => ((__Internal*)__Instance)->stdio_count = value;
    }

    public global::LibuvSharp.UvStdioContainerS Stdio
    {
        get
        {
            var __result0 = global::LibuvSharp.UvStdioContainerS.__GetOrCreateInstance(((__Internal*)__Instance)->stdio, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->stdio = value is null ? IntPtr.Zero : value.__Instance;
    }

    public byte Uid
    {
        get => ((__Internal*)__Instance)->uid;

        set => ((__Internal*)__Instance)->uid = value;
    }

    public byte Gid
    {
        get => ((__Internal*)__Instance)->gid;

        set => ((__Internal*)__Instance)->gid = value;
    }
}