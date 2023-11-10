using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvProcess : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 264)]
    public struct __Internal
    {
        internal IntPtr                    data;
        internal IntPtr                    loop;
        internal UvHandleType              type;
        internal IntPtr                    close_cb;
        internal UvQueue.__Internal        handle_queue;
        internal U.__Internal              u;
        internal IntPtr                    endgame_next;
        internal uint                      flags;
        internal IntPtr                    exit_cb;
        internal int                       pid;
        internal UvProcessExit.__Internal exit_req;
        internal IntPtr                    unused;
        internal int                       exit_signal;
        internal IntPtr                    wait_handle;
        internal IntPtr                    process_handle;
        internal sbyte                     exit_cb_pending;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_process_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal int fd;

            [FieldOffset(0)]
            internal void* reserved;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_process_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

        internal static U __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new U(native.ToPointer(), skipVTables);
        }

        internal static U __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new U(native, skipVTables);
        }

        private U(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private U(void* native, bool skipVTables = false) : this()
        {
            __instance = *(__Internal*) native;
        }

        public U(U __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public int Fd
        {
            get => __instance.fd;

            set => __instance.fd = value;
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
    }

    public partial class UvProcessExit : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 112)]
        public struct __Internal
        {
            internal IntPtr       data;
            internal UvReqType    type;
            internal void*        reserved;
            internal U.__Internal u;
            internal IntPtr       next_req;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_process_exit_s@uv_process_s@@QEAA@AEBU01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
        }

        public partial struct U
        {
            [StructLayout(LayoutKind.Explicit, Size = 40)]
            public struct __Internal
            {
                [FieldOffset(0)]
                internal Connect.__Internal io;

                [FieldOffset(0)]
                internal Connect.__Internal connect;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_process_exit_s@uv_process_s@@QEAA@AEBT012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public partial class Connect : IDisposable
            {
                [StructLayout(LayoutKind.Sequential, Size = 40)]
                public struct __Internal
                {
                    internal OVERLAPPED.__Internal overlapped;
                    internal ulong                 queued_bytes;

                    [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_process_exit_s@uv_process_s@@QEAA@AEBU0123@@Z", CallingConvention = CallingConvention.Cdecl)]
                    internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
                }

                public IntPtr __Instance { get; protected set; }

                internal static readonly ConcurrentDictionary<IntPtr, Connect> NativeToManagedMap =
                    new ConcurrentDictionary<IntPtr, Connect>();

                internal static void __RecordNativeToManagedMapping(IntPtr native, Connect managed)
                {
                    NativeToManagedMap[native] = managed;
                }

                internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Connect managed)
                {
    
                    return NativeToManagedMap.TryGetValue(native, out managed);
                }

                protected readonly bool __ownsNativeInstance;

                internal static Connect __CreateInstance(IntPtr native, bool skipVTables = false)
                {
                    if (native == IntPtr.Zero)
                        return null;
                    return new Connect(native.ToPointer(), skipVTables);
                }

                internal static Connect __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
                {
                    if (native == IntPtr.Zero)
                        return null;
                    if (__TryGetNativeToManagedMapping(native, out var managed))
                        return (Connect)managed;
                    var result = __CreateInstance(native, skipVTables);
                    if (saveInstance)
                        __RecordNativeToManagedMapping(native, result);
                    return result;
                }

                internal static Connect __CreateInstance(__Internal native, bool skipVTables = false)
                {
                    return new Connect(native, skipVTables);
                }

                private static void* __CopyValue(__Internal native)
                {
                    var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                    *(__Internal*) ret = native;
                    return ret.ToPointer();
                }

                private Connect(__Internal native, bool skipVTables = false)
                    : this(__CopyValue(native), skipVTables)
                {
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                }

                protected Connect(void* native, bool skipVTables = false)
                {
                    if (native == null)
                        return;
                    __Instance = new IntPtr(native);
                }

                public Connect()
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                }

                public Connect(Connect __0)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
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

                public ulong QueuedBytes
                {
                    get => ((__Internal*)__Instance)->queued_bytes;

                    set => ((__Internal*)__Instance)->queued_bytes = value;
                }
            }

            private  __Internal __instance;
            internal __Internal __Instance => __instance;

            internal static U __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new U(native.ToPointer(), skipVTables);
            }

            internal static U __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new U(native, skipVTables);
            }

            private U(__Internal native, bool skipVTables = false)
                : this()
            {
                __instance = native;
            }

            private U(void* native, bool skipVTables = false) : this()
            {
                __instance = *(__Internal*) native;
            }

            public U(U __0)
                : this()
            {
                var ____arg0 = __0.__Instance;
                var __arg0   = new IntPtr(&____arg0);
                fixed (__Internal* __instancePtr = &__instance)
                {
                    __Internal.cctor(new IntPtr(__instancePtr), __arg0);
                }
            }

            public Connect Io
            {
                get => Connect.__CreateInstance(__instance.io);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
                    __instance.io = *(Connect.__Internal*) value.__Instance;
                }
            }

            public Connect connect
            {
                get => Connect.__CreateInstance(__instance.connect);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
                    __instance.connect = *(Connect.__Internal*) value.__Instance;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, UvProcessExit> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, UvProcessExit>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, UvProcessExit managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvProcessExit managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected readonly bool __ownsNativeInstance;

        internal static UvProcessExit __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new UvProcessExit(native.ToPointer(), skipVTables);
        }

        internal static UvProcessExit __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (UvProcessExit)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static UvProcessExit __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new UvProcessExit(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private UvProcessExit(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected UvProcessExit(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public UvProcessExit()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public UvProcessExit(UvProcessExit _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
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

        public IntPtr Data
        {
            get => ((__Internal*)__Instance)->data;

            set => ((__Internal*)__Instance)->data = value;
        }

        public UvReqType Type
        {
            get => ((__Internal*)__Instance)->type;

            set => ((__Internal*)__Instance)->type = value;
        }

        private IntPtr[]? __reserved;

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

        public U u
        {
            get => U.__CreateInstance(((__Internal*)__Instance)->u);

            set => ((__Internal*)__Instance)->u = value.__Instance;
        }

        public UvReqS? NextReq
        {
            get
            {
                var __result0 = UvReqS.__GetOrCreateInstance(((__Internal*)__Instance)->next_req);
                return __result0;
            }

            set => ((__Internal*)__Instance)->next_req = value?.__Instance ?? IntPtr.Zero;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvProcess> NativeToManagedMap = new();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvProcess managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvProcess managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvProcess? __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return native == IntPtr.Zero 
            ? null 
            : new UvProcess(native.ToPointer(), skipVTables);
    }

    internal static UvProcess? __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvProcess)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvProcess __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvProcess(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal((int)Uv.UvHandleSize(UvHandleType.UV_PROCESS));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvProcess(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvProcess(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvProcess()
    {
        __Instance           = Marshal.AllocHGlobal((int)Uv.UvHandleSize(UvHandleType.UV_PROCESS));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvProcess(UvProcess _0)
    {
        __Instance = Marshal.AllocHGlobal((int)Uv.UvHandleSize(UvHandleType.UV_PROCESS));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*) __Instance = *(__Internal*) _0.__Instance;
    }

    internal UvProcess(IntPtr instance)
    {
        __Instance           = Marshal.AllocHGlobal((int)Uv.UvHandleSize(UvHandleType.UV_PROCESS));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*) __Instance = *(__Internal*) instance;
    }
    
    public void Dispose()
    {
        if(killed)return;
        killed = true;
        CloseStdioPipes();
        Uv.UvRun(Loop, UvRunMode.UV_RUN_DEFAULT).Check();
        Loop?.Dispose();
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

    public IntPtr Data
    {
        get => ((__Internal*)__Instance)->data;

        set => ((__Internal*)__Instance)->data = value;
    }

    public UvLoop? Loop
    {
        get
        {
            var __result0 = UvLoop.__GetOrCreateInstance(((__Internal*)__Instance)->loop);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value?.__Instance ?? IntPtr.Zero;
    }

    public UvHandleType Type
    {
        get => ((__Internal*)__Instance)->type;

        set => ((__Internal*)__Instance)->type = value;
    }

    public UvCloseCb? CloseCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->close_cb;
            return __ptr0 == IntPtr.Zero? null : (UvCloseCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvCloseCb));
        }

        set => ((__Internal*)__Instance)->close_cb = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public UvQueue HandleQueue
    {
        get => UvQueue.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->handle_queue));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->handle_queue = *(UvQueue.__Internal*) value.__Instance;
        }
    }

    public U u
    {
        get => U.__CreateInstance(((__Internal*)__Instance)->u);

        set => ((__Internal*)__Instance)->u = value.__Instance;
    }

    public UvHandle? EndgameNext
    {
        get
        {
            var __result0 = UvHandle.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_next);
            return __result0;
        }

        set => ((__Internal*)__Instance)->endgame_next = value?.__Instance ?? IntPtr.Zero;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
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

    public int Pid
    {
        get => ((__Internal*)__Instance)->pid;

        set => ((__Internal*)__Instance)->pid = value;
    }

    public UvProcessExit ExitReq
    {
        get => UvProcessExit.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->exit_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->exit_req = *(UvProcessExit.__Internal*) value.__Instance;
        }
    }

    public IntPtr Unused
    {
        get => ((__Internal*)__Instance)->unused;

        set => ((__Internal*)__Instance)->unused = value;
    }

    public int ExitSignal
    {
        get => ((__Internal*)__Instance)->exit_signal;

        set => ((__Internal*)__Instance)->exit_signal = value;
    }

    public IntPtr WaitHandle
    {
        get => ((__Internal*)__Instance)->wait_handle;

        set => ((__Internal*)__Instance)->wait_handle = value;
    }

    public IntPtr ProcessHandle
    {
        get => ((__Internal*)__Instance)->process_handle;

        set => ((__Internal*)__Instance)->process_handle = value;
    }

    public sbyte ExitCbPending
    {
        get => ((__Internal*)__Instance)->exit_cb_pending;

        set => ((__Internal*)__Instance)->exit_cb_pending = value;
    }

    public void Kill(int sigNum = 0)
    {
        if(killed)return;
        killed = true;
        if (exitStatus < 0)
        {
            var r = Uv.__Internal.UvProcessKill(__Instance, sigNum);
            if (r < 0 && r != (int)UvErrno.UV_ESRCH) {
                SetError((UvErrno)r);

                // Deliberately ignore the return value, we might not have
                // sufficient privileges to signal the child process.
                Uv.UvProcessKill(this, 9);
            }
        }
        
        // Close all stdio pipes.
        CloseStdioPipes();
    }
    internal UvPipe[]? Stdios { get; set; }
    private  bool      killed;
    private  long      exitStatus = -1;
    
    private void CloseStdioPipes()
    {
        if (Stdios != null)
        {
            foreach (var pipe in Stdios)
            {
                pipe.Close();
            }
        }

        Stdios = null;
    }

    internal void SetError(UvErrno error)
    {
        if (this.error == 0)
        {
            this.error = error;
        }
    }
    internal void SetPipeError(UvErrno pipeError)
    {
        if (this.pipeError == 0)
        {
            this.pipeError = pipeError;
        }
    }

    internal void IncrementBufferSizeAndCheckOverflow(ulong length)
    {
        bufferedOutputSize += length;
        if (!(MaxBuffer > 0) || !(bufferedOutputSize > MaxBuffer)) return;
        SetError(UvErrno.UV_ENOBUFS);
        Kill();
    }

    internal void OnExit(IntPtr handle,long exitStatus,int signal)
    {
        Uv.__Internal.UvClose(handle, default);
    }

    public  double  MaxBuffer { get; init; } = 0;
    private ulong   bufferedOutputSize;
    private UvErrno pipeError;
    private UvErrno error;


    public static UvProcess Spawn(UvProcessOptions options) => Uv.UvSpawn(options);
}