using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvPipeS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 576)]
    public partial struct __Internal
    {
        internal IntPtr                                     data;
        internal IntPtr                                     loop;
        internal global::LibuvSharp.UvHandleType              type;
        internal IntPtr                                     close_cb;
        internal global::LibuvSharp.UvQueue.__Internal        handle_queue;
        internal global::LibuvSharp.UvPipeS.U.__Internal      u;
        internal IntPtr                                     endgame_next;
        internal uint                                         flags;
        internal ulong                                        write_queue_size;
        internal IntPtr                                     alloc_cb;
        internal IntPtr                                     read_cb;
        internal uint                                         reqs_pending;
        internal int                                          activecnt;
        internal global::LibuvSharp.UvReadS.__Internal        read_req;
        internal global::LibuvSharp.UvPipeS.Stream.__Internal stream;
        internal int                                          ipc;
        internal IntPtr                                     handle;
        internal IntPtr                                     name;
        internal global::LibuvSharp.UvPipeS.Pipe.__Internal   pipe;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_pipe_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
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

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_pipe_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
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
            __instance = *(global::LibuvSharp.UvPipeS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvPipeS.U __0)
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

    public unsafe partial struct Stream
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.UvPipeS.Stream.Serv.__Internal conn;

            [FieldOffset(0)]
            internal global::LibuvSharp.UvPipeS.Stream.Serv.__Internal serv;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-stream>@uv_pipe_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class Serv : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal uint     write_reqs_pending;
                internal IntPtr shutdown_req;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-conn>@<unnamed-type-stream>@uv_pipe_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS.Stream.Serv> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS.Stream.Serv>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvPipeS.Stream.Serv managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvPipeS.Stream.Serv managed)
            {
    
                return NativeToManagedMap.TryGetValue(native, out managed);
            }

            protected bool __ownsNativeInstance;

            internal static Serv __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                return new Serv(native.ToPointer(), skipVTables);
            }

            internal static Serv __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (__TryGetNativeToManagedMapping(native, out var managed))
                    return (Serv)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    __RecordNativeToManagedMapping(native, result);
                return result;
            }

            internal static Serv __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new Serv(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private Serv(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            protected Serv(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public Serv()
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.Stream.Serv.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Serv(global::LibuvSharp.UvPipeS.Stream.Serv __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.Stream.Serv.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((global::LibuvSharp.UvPipeS.Stream.Serv.__Internal*) __Instance) = *((global::LibuvSharp.UvPipeS.Stream.Serv.__Internal*) __0.__Instance);
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

            public uint WriteReqsPending
            {
                get => ((__Internal*)__Instance)->write_reqs_pending;

                set => ((__Internal*)__Instance)->write_reqs_pending = value;
            }

            public global::LibuvSharp.UvShutdownS ShutdownReq
            {
                get
                {
                    var __result0 = global::LibuvSharp.UvShutdownS.__GetOrCreateInstance(((__Internal*)__Instance)->shutdown_req, false);
                    return __result0;
                }

                set => ((__Internal*)__Instance)->shutdown_req = value is null ? IntPtr.Zero : value.__Instance;
            }
        }

        private  Stream.__Internal __instance;
        internal Stream.__Internal __Instance => __instance;

        internal static Stream __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Stream(native.ToPointer(), skipVTables);
        }

        internal static Stream __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Stream(native, skipVTables);
        }

        private Stream(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Stream(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvPipeS.Stream.__Internal*) native;
        }

        public Stream(global::LibuvSharp.UvPipeS.Stream __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public global::LibuvSharp.UvPipeS.Stream.Serv Conn
        {
            get => global::LibuvSharp.UvPipeS.Stream.Serv.__CreateInstance(__instance.conn);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.conn = *(global::LibuvSharp.UvPipeS.Stream.Serv.__Internal*) value.__Instance;
            }
        }

        public global::LibuvSharp.UvPipeS.Stream.Serv serv
        {
            get => global::LibuvSharp.UvPipeS.Stream.Serv.__CreateInstance(__instance.serv);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.serv = *(global::LibuvSharp.UvPipeS.Stream.Serv.__Internal*) value.__Instance;
            }
        }
    }

    public unsafe partial struct Pipe
    {
        [StructLayout(LayoutKind.Explicit, Size = 280)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal serv;

            [FieldOffset(0)]
            internal global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal conn;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-pipe>@uv_pipe_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class Conn : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 24)]
            public partial struct __Internal
            {
                internal int      pending_instances;
                internal IntPtr accept_reqs;
                internal IntPtr pending_accepts;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-serv>@<unnamed-type-pipe>@uv_pipe_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS.Pipe.Conn> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS.Pipe.Conn>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvPipeS.Pipe.Conn managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvPipeS.Pipe.Conn managed)
            {
    
                return NativeToManagedMap.TryGetValue(native, out managed);
            }

            protected bool __ownsNativeInstance;

            internal static Conn __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                return new Conn(native.ToPointer(), skipVTables);
            }

            internal static Conn __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (__TryGetNativeToManagedMapping(native, out var managed))
                    return (Conn)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    __RecordNativeToManagedMapping(native, result);
                return result;
            }

            internal static Conn __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new Conn(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private Conn(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            protected Conn(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public Conn()
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Conn(global::LibuvSharp.UvPipeS.Pipe.Conn __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal*) __Instance) = *((global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal*) __0.__Instance);
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

            public int PendingInstances
            {
                get => ((__Internal*)__Instance)->pending_instances;

                set => ((__Internal*)__Instance)->pending_instances = value;
            }

            public global::LibuvSharp.UvPipeAcceptS AcceptReqs
            {
                get
                {
                    var __result0 = global::LibuvSharp.UvPipeAcceptS.__GetOrCreateInstance(((__Internal*)__Instance)->accept_reqs, false);
                    return __result0;
                }

                set => ((__Internal*)__Instance)->accept_reqs = value is null ? IntPtr.Zero : value.__Instance;
            }

            public global::LibuvSharp.UvPipeAcceptS PendingAccepts
            {
                get
                {
                    var __result0 = global::LibuvSharp.UvPipeAcceptS.__GetOrCreateInstance(((__Internal*)__Instance)->pending_accepts, false);
                    return __result0;
                }

                set => ((__Internal*)__Instance)->pending_accepts = value is null ? IntPtr.Zero : value.__Instance;
            }
        }

        private  Pipe.__Internal __instance;
        internal Pipe.__Internal __Instance => __instance;

        internal static Pipe __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Pipe(native.ToPointer(), skipVTables);
        }

        internal static Pipe __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Pipe(native, skipVTables);
        }

        private Pipe(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Pipe(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvPipeS.Pipe.__Internal*) native;
        }

        public Pipe(global::LibuvSharp.UvPipeS.Pipe __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public global::LibuvSharp.UvPipeS.Pipe.Conn Serv
        {
            get => global::LibuvSharp.UvPipeS.Pipe.Conn.__CreateInstance(__instance.serv);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.serv = *(global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal*) value.__Instance;
            }
        }

        public global::LibuvSharp.UvPipeS.Pipe.Conn conn
        {
            get => global::LibuvSharp.UvPipeS.Pipe.Conn.__CreateInstance(__instance.conn);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.conn = *(global::LibuvSharp.UvPipeS.Pipe.Conn.__Internal*) value.__Instance;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPipeS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvPipeS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvPipeS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvPipeS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvPipeS(native.ToPointer(), skipVTables);
    }

    internal static UvPipeS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvPipeS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvPipeS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvPipeS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvPipeS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvPipeS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvPipeS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvPipeS(global::LibuvSharp.UvPipeS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPipeS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvPipeS.__Internal*) __Instance) = *((global::LibuvSharp.UvPipeS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvPipeS.U u
    {
        get => global::LibuvSharp.UvPipeS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    public ulong WriteQueueSize
    {
        get => ((__Internal*)__Instance)->write_queue_size;

        set => ((__Internal*)__Instance)->write_queue_size = value;
    }

    public global::LibuvSharp.UvAllocCb AllocCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->alloc_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvAllocCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvAllocCb));
        }

        set => ((__Internal*)__Instance)->alloc_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public global::LibuvSharp.UvReadCb ReadCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->read_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvReadCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvReadCb));
        }

        set => ((__Internal*)__Instance)->read_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public uint ReqsPending
    {
        get => ((__Internal*)__Instance)->reqs_pending;

        set => ((__Internal*)__Instance)->reqs_pending = value;
    }

    public int Activecnt
    {
        get => ((__Internal*)__Instance)->activecnt;

        set => ((__Internal*)__Instance)->activecnt = value;
    }

    public global::LibuvSharp.UvReadS ReadReq
    {
        get => global::LibuvSharp.UvReadS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->read_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->read_req = *(global::LibuvSharp.UvReadS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvPipeS.Stream stream
    {
        get => global::LibuvSharp.UvPipeS.Stream.__CreateInstance(((__Internal*)__Instance)->stream);

        set => ((__Internal*)__Instance)->stream = value.__Instance;
    }

    public int Ipc
    {
        get => ((__Internal*)__Instance)->ipc;

        set => ((__Internal*)__Instance)->ipc = value;
    }

    public IntPtr Handle
    {
        get => ((__Internal*)__Instance)->handle;

        set => ((__Internal*)__Instance)->handle = (IntPtr) value;
    }

    public char* Name
    {
        get => (char*) ((__Internal*)__Instance)->name;

        set => ((__Internal*)__Instance)->name = (IntPtr) value;
    }

    public global::LibuvSharp.UvPipeS.Pipe pipe
    {
        get => global::LibuvSharp.UvPipeS.Pipe.__CreateInstance(((__Internal*)__Instance)->pipe);

        set => ((__Internal*)__Instance)->pipe = value.__Instance;
    }
}