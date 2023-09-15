using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvFsEventS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 272)]
    public partial struct __Internal
    {
        internal IntPtr                                               data;
        internal IntPtr                                               loop;
        internal global::LibuvSharp.UvHandleType                        type;
        internal IntPtr                                               close_cb;
        internal global::LibuvSharp.UvQueue.__Internal                  handle_queue;
        internal global::LibuvSharp.UvFsEventS.U.__Internal             u;
        internal IntPtr                                               endgame_next;
        internal uint                                                   flags;
        internal IntPtr                                               path;
        internal global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal req;
        internal IntPtr                                               dir_handle;
        internal int                                                    req_pending;
        internal IntPtr                                               cb;
        internal IntPtr                                               filew;
        internal IntPtr                                               short_filew;
        internal IntPtr                                               dirw;
        internal IntPtr                                               buffer;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_fs_event_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
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

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_fs_event_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
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
            __instance = *(global::LibuvSharp.UvFsEventS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvFsEventS.U __0)
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

    public unsafe partial class UvFsEventReqS : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 112)]
        public partial struct __Internal
        {
            internal IntPtr                                                 data;
            internal global::LibuvSharp.UvReqType                             type;
            internal void*                                                    reserved;
            internal global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.__Internal u;
            internal IntPtr                                                 next_req;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_fs_event_req_s@uv_fs_event_s@@QEAA@AEBU01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
        }

        public unsafe partial struct U
        {
            [StructLayout(LayoutKind.Explicit, Size = 40)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal io;

                [FieldOffset(0)]
                internal global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal connect;

                [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_fs_event_req_s@uv_fs_event_s@@QEAA@AEBT012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public unsafe partial class Connect : IDisposable
            {
                [StructLayout(LayoutKind.Sequential, Size = 40)]
                public partial struct __Internal
                {
                    internal global::OVERLAPPED.__Internal overlapped;
                    internal ulong                         queued_bytes;

                    [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_fs_event_req_s@uv_fs_event_s@@QEAA@AEBU0123@@Z", CallingConvention = CallingConvention.Cdecl)]
                    internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
                }

                public IntPtr __Instance { get; protected set; }

                internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect> NativeToManagedMap =
                    new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect>();

                internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect managed)
                {
                    NativeToManagedMap[native] = managed;
                }

                internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect managed)
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
                    __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                }

                public Connect(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect __0)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                    *((global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal*) __Instance) = *((global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal*) __0.__Instance);
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
                __instance = *(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.__Internal*) native;
            }

            public U(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U __0)
                : this()
            {
                var ____arg0 = __0.__Instance;
                var __arg0   = new IntPtr(&____arg0);
                fixed (__Internal* __instancePtr = &__instance)
                {
                    __Internal.cctor(new IntPtr(__instancePtr), __arg0);
                }
            }

            public global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect Io
            {
                get => global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__CreateInstance(__instance.io);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    __instance.io = *(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal*) value.__Instance;
                }
            }

            public global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect connect
            {
                get => global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__CreateInstance(__instance.connect);

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    __instance.connect = *(global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.Connect.__Internal*) value.__Instance;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS.UvFsEventReqS> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS.UvFsEventReqS>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvFsEventS.UvFsEventReqS managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvFsEventS.UvFsEventReqS managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static UvFsEventReqS __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new UvFsEventReqS(native.ToPointer(), skipVTables);
        }

        internal static UvFsEventReqS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (UvFsEventReqS)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static UvFsEventReqS __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new UvFsEventReqS(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private UvFsEventReqS(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected UvFsEventReqS(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public UvFsEventReqS()
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public UvFsEventReqS(global::LibuvSharp.UvFsEventS.UvFsEventReqS _0)
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal*) __Instance) = *((global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal*) _0.__Instance);
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

        public global::LibuvSharp.UvFsEventS.UvFsEventReqS.U u
        {
            get => global::LibuvSharp.UvFsEventS.UvFsEventReqS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsEventS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvFsEventS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvFsEventS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvFsEventS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvFsEventS(native.ToPointer(), skipVTables);
    }

    internal static UvFsEventS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvFsEventS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvFsEventS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvFsEventS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvFsEventS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvFsEventS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvFsEventS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvFsEventS(global::LibuvSharp.UvFsEventS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsEventS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvFsEventS.__Internal*) __Instance) = *((global::LibuvSharp.UvFsEventS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvFsEventS.U u
    {
        get => global::LibuvSharp.UvFsEventS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    public sbyte* Path
    {
        get => (sbyte*) ((__Internal*)__Instance)->path;

        set => ((__Internal*)__Instance)->path = (IntPtr) value;
    }

    public global::LibuvSharp.UvFsEventS.UvFsEventReqS Req
    {
        get => global::LibuvSharp.UvFsEventS.UvFsEventReqS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->req = *(global::LibuvSharp.UvFsEventS.UvFsEventReqS.__Internal*) value.__Instance;
        }
    }

    public IntPtr DirHandle
    {
        get => ((__Internal*)__Instance)->dir_handle;

        set => ((__Internal*)__Instance)->dir_handle = (IntPtr) value;
    }

    public int ReqPending
    {
        get => ((__Internal*)__Instance)->req_pending;

        set => ((__Internal*)__Instance)->req_pending = value;
    }

    public global::LibuvSharp.UvFsEventCb Cb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvFsEventCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvFsEventCb));
        }

        set => ((__Internal*)__Instance)->cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public char* Filew
    {
        get => (char*) ((__Internal*)__Instance)->filew;

        set => ((__Internal*)__Instance)->filew = (IntPtr) value;
    }

    public char* ShortFilew
    {
        get => (char*) ((__Internal*)__Instance)->short_filew;

        set => ((__Internal*)__Instance)->short_filew = (IntPtr) value;
    }

    public char* Dirw
    {
        get => (char*) ((__Internal*)__Instance)->dirw;

        set => ((__Internal*)__Instance)->dirw = (IntPtr) value;
    }

    public sbyte* Buffer
    {
        get => (sbyte*) ((__Internal*)__Instance)->buffer;

        set => ((__Internal*)__Instance)->buffer = (IntPtr) value;
    }
}