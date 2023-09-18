using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using CppSharp.Runtime;
using LibuvSharp.Extensions;

namespace LibuvSharp;

public unsafe partial class UvProcessOptionsS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 64)]
    public struct __Internal
    {
        internal IntPtr exit_cb;
        internal IntPtr file;
        internal IntPtr args;
        internal IntPtr env;
        internal IntPtr cwd;
        internal uint   flags;
        internal int    stdio_count;
        internal IntPtr stdio;
        internal byte   uid;
        internal byte   gid;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_process_options_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvProcessOptionsS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvProcessOptionsS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvProcessOptionsS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvProcessOptionsS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __file_OwnsNativeMemory;
    private   bool __cwd_OwnsNativeMemory;
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
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvProcessOptionsS(UvProcessOptionsS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((__Internal*) __Instance) = *((__Internal*) _0.__Instance);
        if (_0.__file_OwnsNativeMemory)
            File = _0.File;
        if (_0.__cwd_OwnsNativeMemory)
            Cwd = _0.Cwd;
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

    public UvExitCb? ExitCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->exit_cb;
            return __ptr0 == IntPtr.Zero? null : (UvExitCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvExitCb));
        }

        set => ((__Internal*)__Instance)->exit_cb = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public string File
    {
        get => MarshalUtil.GetString(Encoding.UTF8, ((__Internal*)__Instance)->file);

        set
        {
            if (__file_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->file);
            __file_OwnsNativeMemory = true;
            ((__Internal*)__Instance)->file = value.CopyToPointer();
        }
    }

    public string[]? Args
    {
        get => __internalArgs;

        set => ((__Internal*)__Instance)->args = value.CopyToPointer();
    }

    private string[]? __internalArgs;
        
    public string[]? Env
    {
        get => __internalEnv;

        set
        {
            __internalEnv                  = value;
            ((__Internal*)__Instance)->env = value.CopyToPointer();
        }
    }

    private string[]? __internalEnv;

    public string Cwd
    {
        get => MarshalUtil.GetString(Encoding.UTF8, ((__Internal*)__Instance)->cwd);

        set
        {
            if (__cwd_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->cwd);
            __cwd_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->cwd = IntPtr.Zero;
                return;
            }
            var __bytes0   = Encoding.UTF8.GetBytes(value);
            var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
            Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
            Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
            ((__Internal*)__Instance)->cwd = __bytePtr0;
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

        private set => ((__Internal*)__Instance)->stdio_count = value;
    }

    public UvStdioContainerS?[]? Stdio
    {
        get
        {
            var ret     = new UvStdioContainerS[StdioCount];
            var pointer = (UvStdioContainerS.__Internal*)((__Internal*)__Instance)->stdio;
            for (var i = 0; i < StdioCount; i++)
            {
                ret[StdioCount] = UvStdioContainerS.__GetOrCreateInstance((nint)pointer);
                pointer++;
            }
        
            return ret;
        }
        
        set
        {
            if (value is null || value.Length == 0) return;
            var start  = Marshal.AllocHGlobal(value.Length * sizeof(IntPtr));
            var handle = start;
            foreach (var containerS in value)
            {
                Marshal.WriteIntPtr(handle, containerS?.__Instance ?? new UvStdioContainerS
                {
                    Flags = UvStdioFlags.UV_IGNORE
                }.__Instance);
                handle = IntPtr.Add(handle, 1);
            }
            ((__Internal*)__Instance)->stdio = start;
            StdioCount                       = value.Length;
        }
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