using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvProcessS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 264)]
    public partial struct __Internal
    {
        internal IntPtr                                                data;
        internal IntPtr                                                loop;
        internal global::LibuvSharp.UvHandleType                         type;
        internal IntPtr                                                close_cb;
        internal global::LibuvSharp.UvQueue.__Internal                   handle_queue;
        internal global::LibuvSharp.UvProcessS.U.__Internal              u;
        internal IntPtr                                                endgame_next;
        internal uint                                                    flags;
        internal IntPtr                                                exit_cb;
        internal int                                                     pid;
        internal global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal exit_req;
        internal IntPtr                                                unused;
        internal int                                                     exit_signal;
        internal IntPtr                                                wait_handle;
        internal IntPtr                                                process_handle;
        internal sbyte                                                   exit_cb_pending;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_process_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int fd;

            [FieldOffset(0)]
            internal void* reserved;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_process_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  U.__Internal __instance;
        internal U.__Internal __Instance => __instance;

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
            __instance = *(global::LibuvSharp.UvProcessS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvProcessS.U __0)
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

    public unsafe partial class UvProcessExitS : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 112)]
        public partial struct __Internal
        {
            internal IntPtr                                                  data;
            internal global::LibuvSharp.UvReqType                              type;
            internal void*                                                     reserved;
            internal global::LibuvSharp.UvProcessS.UvProcessExitS.U.__Internal u;
            internal IntPtr                                                  next_req;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_process_exit_s@uv_process_s@@QEAA@AEBU01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
        }

        public unsafe partial struct U
        {
            [StructLayout(LayoutKind.Explicit, Size = 40)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal io;

                [FieldOffset(0)]
                internal global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal connect;

                [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_process_exit_s@uv_process_s@@QEAA@AEBT012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public unsafe partial class Connect : IDisposable
            {
                [StructLayout(LayoutKind.Sequential, Size = 40)]
                public partial struct __Internal
                {
                    internal global::OVERLAPPED.__Internal overlapped;
                    internal ulong                         queued_bytes;

                    [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_process_exit_s@uv_process_s@@QEAA@AEBU0123@@Z", CallingConvention = CallingConvention.Cdecl)]
                    internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
                }

                public IntPtr __Instance { get; protected set; }

                internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect> NativeToManagedMap =
                    new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect>();

                internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect managed)
                {
                    NativeToManagedMap[native] = managed;
                }

                internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect managed)
                {
    
                    return NativeToManagedMap.TryGetValue(native, out managed);
                }

                protected bool __ownsNativeInstance;

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
                    __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                }

                public Connect(global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect __0)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                    *((global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal*) __Instance) = *((global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal*) __0.__Instance);
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

            private  U.__Internal __instance;
            internal U.__Internal __Instance => __instance;

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
                __instance = *(global::LibuvSharp.UvProcessS.UvProcessExitS.U.__Internal*) native;
            }

            public U(global::LibuvSharp.UvProcessS.UvProcessExitS.U __0)
                : this()
            {
                var ____arg0 = __0.__Instance;
                var __arg0   = new IntPtr(&____arg0);
                fixed (__Internal* __instancePtr = &__instance)
                {
                    __Internal.cctor(new IntPtr(__instancePtr), __arg0);
                }
            }

            public global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect Io
            {
                get => global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__CreateInstance(__instance.io);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    __instance.io = *(global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal*) value.__Instance;
                }
            }

            public global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect connect
            {
                get => global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__CreateInstance(__instance.connect);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    __instance.connect = *(global::LibuvSharp.UvProcessS.UvProcessExitS.U.Connect.__Internal*) value.__Instance;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS.UvProcessExitS> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS.UvProcessExitS>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvProcessS.UvProcessExitS managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvProcessS.UvProcessExitS managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static UvProcessExitS __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new UvProcessExitS(native.ToPointer(), skipVTables);
        }

        internal static UvProcessExitS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (UvProcessExitS)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static UvProcessExitS __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new UvProcessExitS(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private UvProcessExitS(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected UvProcessExitS(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public UvProcessExitS()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public UvProcessExitS(global::LibuvSharp.UvProcessS.UvProcessExitS _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal*) __Instance) = *((global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal*) _0.__Instance);
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

            set => ((__Internal*)__Instance)->data = (IntPtr) value;
        }

        public global::LibuvSharp.UvReqType Type
        {
            get => ((__Internal*)__Instance)->type;

            set => ((__Internal*)__Instance)->type = value;
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

        public global::LibuvSharp.UvProcessS.UvProcessExitS.U u
        {
            get => global::LibuvSharp.UvProcessS.UvProcessExitS.U.__CreateInstance(((__Internal*)__Instance)->u);

            set => ((__Internal*)__Instance)->u = value.__Instance;
        }

        public global::LibuvSharp.UvReqS NextReq
        {
            get
            {
                var __result0 = global::LibuvSharp.UvReqS.__GetOrCreateInstance(((__Internal*)__Instance)->next_req, false);
                return __result0;
            }

            set => ((__Internal*)__Instance)->next_req = value is null ? IntPtr.Zero : value.__Instance;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvProcessS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvProcessS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvProcessS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvProcessS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvProcessS(native.ToPointer(), skipVTables);
    }

    internal static UvProcessS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvProcessS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvProcessS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvProcessS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvProcessS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvProcessS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvProcessS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvProcessS(global::LibuvSharp.UvProcessS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvProcessS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvProcessS.__Internal*) __Instance) = *((global::LibuvSharp.UvProcessS.__Internal*) _0.__Instance);
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

        set => ((__Internal*)__Instance)->data = (IntPtr) value;
    }

    public global::LibuvSharp.UvLoopS Loop
    {
        get
        {
            var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvHandleType Type
    {
        get => ((__Internal*)__Instance)->type;

        set => ((__Internal*)__Instance)->type = value;
    }

    public global::LibuvSharp.UvCloseCb CloseCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->close_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvCloseCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvCloseCb));
        }

        set => ((__Internal*)__Instance)->close_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public global::LibuvSharp.UvQueue HandleQueue
    {
        get => global::LibuvSharp.UvQueue.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->handle_queue));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->handle_queue = *(global::LibuvSharp.UvQueue.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvProcessS.U u
    {
        get => global::LibuvSharp.UvProcessS.U.__CreateInstance(((__Internal*)__Instance)->u);

        set => ((__Internal*)__Instance)->u = value.__Instance;
    }

    public global::LibuvSharp.UvHandleS EndgameNext
    {
        get
        {
            var __result0 = global::LibuvSharp.UvHandleS.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_next, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->endgame_next = value is null ? IntPtr.Zero : value.__Instance;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
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

    public int Pid
    {
        get => ((__Internal*)__Instance)->pid;

        set => ((__Internal*)__Instance)->pid = value;
    }

    public global::LibuvSharp.UvProcessS.UvProcessExitS ExitReq
    {
        get => global::LibuvSharp.UvProcessS.UvProcessExitS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->exit_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->exit_req = *(global::LibuvSharp.UvProcessS.UvProcessExitS.__Internal*) value.__Instance;
        }
    }

    public IntPtr Unused
    {
        get => ((__Internal*)__Instance)->unused;

        set => ((__Internal*)__Instance)->unused = (IntPtr) value;
    }

    public int ExitSignal
    {
        get => ((__Internal*)__Instance)->exit_signal;

        set => ((__Internal*)__Instance)->exit_signal = value;
    }

    public IntPtr WaitHandle
    {
        get => ((__Internal*)__Instance)->wait_handle;

        set => ((__Internal*)__Instance)->wait_handle = (IntPtr) value;
    }

    public IntPtr ProcessHandle
    {
        get => ((__Internal*)__Instance)->process_handle;

        set => ((__Internal*)__Instance)->process_handle = (IntPtr) value;
    }

    public sbyte ExitCbPending
    {
        get => ((__Internal*)__Instance)->exit_cb_pending;

        set => ((__Internal*)__Instance)->exit_cb_pending = value;
    }
}