using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using LibuvSharp.Extensions;

namespace LibuvSharp;

public unsafe partial class UvProcessOptions : IDisposable
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

        [SuppressUnmanagedCodeSecurity,
         DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_process_options_s@@QEAA@AEBU0@@Z",
             CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr      __Instance { get; protected set; }
    public __Internal* Instance   => (__Internal*)__Instance;

    internal static readonly ConcurrentDictionary<IntPtr, UvProcessOptions> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvProcessOptions>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvProcessOptions managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvProcessOptions managed)
    {
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __file_OwnsNativeMemory;
    private   bool __cwd_OwnsNativeMemory;
    protected bool __ownsNativeInstance;

    internal static UvProcessOptions __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvProcessOptions(native.ToPointer(), skipVTables);
    }

    internal static UvProcessOptions __GetOrCreateInstance(IntPtr native, bool saveInstance = false,
        bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvProcessOptions)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvProcessOptions __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvProcessOptions(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*)ret = native;
        return ret.ToPointer();
    }

    private UvProcessOptions(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvProcessOptions(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvProcessOptions()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        Flags      = 0;
        Uid        = 0;
        Gid        = 0;
        StdioCount = 0;
    }

    public UvProcessOptions(UvProcessOptions _0) : this()
    {
        *(__Internal*)__Instance = *(__Internal*)_0.__Instance;
        if (_0.__file_OwnsNativeMemory)
            File = _0.File;
        if (_0.__cwd_OwnsNativeMemory)
            Cwd = _0.Cwd;
    }

    public void Dispose()
    {
        Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
    }

    partial void DisposePartial(bool disposing);

    protected internal virtual void Dispose(bool disposing, bool callNativeDtor)
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

    public Action<UvProcess, long, int>? ExitCb
    {
        get => exitCb;
        init
        {
            Instance->exit_cb = value == null
                ? IntPtr.Zero
                : Marshal.GetFunctionPointerForDelegate((UvExitCb)((ptr, status, signal) =>
                {
                    value.Invoke(new UvProcess(ptr), status, signal);
                }));
            exitCb = value;
        }
    }

    internal IntPtr exit_cb => Instance->exit_cb;
    
    private Action<UvProcess, long, int>? exitCb;

    public string? File
    {
        get => __file_OwnsNativeMemory
            ? Marshal.PtrToStringAnsi(Instance->file)
            : null;

        init
        {
            if (__file_OwnsNativeMemory)
                Marshal.FreeHGlobal(Instance->file);
            __file_OwnsNativeMemory = true;

            Instance->file = value != null ? Marshal.StringToHGlobalAnsi(value) : IntPtr.Zero;
        }
    }

    public string?[]? Args
    {
        get => Instance->args.CopyToStrings();

        init => Instance->args = value.SafeCopyToPointer();
    }


    public string?[]? Env
    {
        get => Instance->env.CopyToStrings();

        init => Instance->env = value.SafeCopyToPointer();
    }


    public string? Cwd
    {
        get => __cwd_OwnsNativeMemory ? Marshal.PtrToStringAnsi(Instance->cwd) : null;

        init
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

        private set => Instance->flags = value;
    }

    public int StdioCount
    {
        get => Instance->stdio_count;

        private set => Instance->stdio_count = value;
    }

    private bool __stdio_hasNativeMemory;

    public UvPipe?[]? Stdio { get; init; }

    internal void PreProcessStdio(UvLoop loop, UvProcess process)
    {
        StdioCount = Stdio?.Length ?? 0;
        if (Stdio is null || Stdio.Length == 0)
        {
            Instance->stdio = IntPtr.Zero;
            return;
        }

        __stdio_hasNativeMemory = true;
        Instance->stdio         = Marshal.AllocHGlobal(StdioCount * sizeof(UvPipe.__Internal));
        var stdio = (UvPipe.__Internal*)Instance->stdio;
        for (var i = 0; i < Stdio.Length; i++)
        {
            var curr = Stdio[i];
            if (curr == null) stdio[i].flags = UvStdioFlags.UV_IGNORE;
            else
            {
                var buf = Uv.__Internal.UvBufInit(null, 0);
                curr.NewAndInit(loop, process, buf);
                var pointer = (UvPipe.__Internal*)curr.__Instance;
                stdio[i].flags       = pointer->flags;
                stdio[i].data.stream = curr.stream!.__Instance;
            }
        }
    }


    public byte Uid
    {
        get => Instance->uid;

        init
        {
            Instance->uid = value;
            if (value != 0)
            {
                Flags |= (uint)UvProcessFlags.UV_PROCESS_SETGID;
            }
        }
    }

    public byte Gid
    {
        get => Instance->gid;

        init
        {
            Instance->gid = value;
            if (value != 0)
            {
                Flags |= (uint)UvProcessFlags.UV_PROCESS_SETUID;
            }
        }
    }

    public bool Detached
    {
        get => (Flags & (uint)UvProcessFlags.UV_PROCESS_DETACHED) > 0;

        init
        {
            if (value)
                Flags |= (uint)UvProcessFlags.UV_PROCESS_DETACHED;
        }
    }

    public bool WindowsVerbatimArguments
    {
        get => (Flags & (uint)UvProcessFlags.UV_PROCESS_WINDOWS_VERBATIM_ARGUMENTS) > 0;

        init
        {
            if (value)
                Flags |= (uint)UvProcessFlags.UV_PROCESS_WINDOWS_VERBATIM_ARGUMENTS;
        }
    }
}