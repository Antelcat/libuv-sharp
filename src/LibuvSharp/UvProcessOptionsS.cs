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

    public IntPtr     __Instance { get; protected set; }
    public __Internal* Instance   => (__Internal*)__Instance;
    
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
        Flags      = 0;
        Uid        = 0;
        Gid        = 0;
        StdioCount = 0;
    }

    public UvProcessOptionsS(UvProcessOptionsS _0) : this()
    {
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
            Marshal.FreeHGlobal(Instance->file);
        if (__cwd_OwnsNativeMemory)
            Marshal.FreeHGlobal(Instance->cwd);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public UvExitCb? ExitCb
    {
        get
        {
            var __ptr0 = Instance->exit_cb;
            return __ptr0 == IntPtr.Zero
                ? null
                : (UvExitCb)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvExitCb));
        }

        set => Instance->exit_cb = value == null 
            ? IntPtr.Zero 
            : Marshal.GetFunctionPointerForDelegate(value);
    }

    public string? File
    {
        get => __file_OwnsNativeMemory
            ? Marshal.PtrToStringAnsi(Instance->file)
            : null;

        set
        {
            if (__file_OwnsNativeMemory)
                Marshal.FreeHGlobal(Instance->file);
            __file_OwnsNativeMemory = true;

            Instance->file = value != null ? Marshal.StringToHGlobalAnsi(value) : IntPtr.Zero;
        }
    }
    
    public string[]? Args
    {
        get => Instance->args.CopyToStrings();

        set => Instance->args = value.CopyToPointer();
    }

        
    public string[]? Env
    {
        get => Instance->env.CopyToStrings();

        set => Instance->env = value.CopyToPointer();
    }


    public string? Cwd
    {
        get => __cwd_OwnsNativeMemory ? Marshal.PtrToStringAnsi(Instance->cwd) : null;

        set
        {
            if (__cwd_OwnsNativeMemory)
                Marshal.FreeHGlobal(Instance->cwd);
            __cwd_OwnsNativeMemory = true;
            Instance->cwd = value == null
                ? IntPtr.Zero
                : Marshal.StringToHGlobalAnsi(value);
        }
    }

    public uint Flags
    {
        get => Instance->flags;

        set => Instance->flags = value;
    }

    public int StdioCount
    {
        get => Instance->stdio_count;

        private set => Instance->stdio_count = value;
    }

    private bool __stdio_hasNativeMemory;
    
    
    /// <summary>
    /// 如果改动，需要重新set
    /// </summary>
    public UvStdioContainerS?[]? Stdio
    {
        get
        {
            if (!__stdio_hasNativeMemory) return null;
            var ret     = new UvStdioContainerS[StdioCount];
            for (var i = 0; i < StdioCount; i++)
            {
                var native = &((UvStdioContainerS.__Internal*)Instance->stdio)[i];
                ret[StdioCount] = UvStdioContainerS.__GetOrCreateInstance((IntPtr)native)!;
            }

            return ret;
        }

        set
        {
            if (__stdio_hasNativeMemory) Marshal.FreeHGlobal(__Instance);
            if (value is null || value.Length == 0)
            {
                __stdio_hasNativeMemory = false;
                StdioCount              = 0;
                return;
            }

            __stdio_hasNativeMemory = true;
            StdioCount              = value.Length;
            Instance->stdio         = Marshal.AllocHGlobal(StdioCount * sizeof(UvStdioContainerS.__Internal));
            var stdio = (UvStdioContainerS.__Internal*)Instance->stdio;
            for (var i = 0; i < value.Length; i++)
            {
                var curr = value[i];
                if (curr == null)
                {
                    stdio[i].flags = UvStdioFlags.UV_IGNORE;
                }
                else
                {
                    var pointer = (UvStdioContainerS.__Internal*)curr.__Instance;
                    stdio[i].flags = pointer->flags;
                    stdio[i].data  = pointer->data;
                }
            }
        }
    }

    public byte Uid
    {
        get => Instance->uid;

        set
        {
            Instance->uid = value;
            if (value != 0)
            {
                Flags |= (uint)UvProcessFlags.UV_PROCESS_SETGID;
            }
            else
            {
                Flags -= (uint)UvProcessFlags.UV_PROCESS_SETGID;
            }
        }
    }

    public byte Gid
    {
        get => Instance->gid;

        set
        {
            Instance->gid = value;
            if (value != 0)
            {
                Flags |= (uint)UvProcessFlags.UV_PROCESS_SETUID;
            }
            else
            {
                Flags -= (uint)UvProcessFlags.UV_PROCESS_SETUID;
            }
        }
    }

    public bool Detached
    {
        get => (Flags & (uint)UvProcessFlags.UV_PROCESS_DETACHED) > 0;
        
        set => Flags |= (uint)UvProcessFlags.UV_PROCESS_DETACHED;
    }

    public bool WindowsVerbatimArguments
    {
        get => (Flags & (uint)UvProcessFlags.UV_PROCESS_WINDOWS_VERBATIM_ARGUMENTS) > 0;
        
        set => Flags |= (uint)UvProcessFlags.UV_PROCESS_WINDOWS_VERBATIM_ARGUMENTS;
    }
}