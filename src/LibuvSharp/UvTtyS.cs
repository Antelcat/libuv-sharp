using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class UvTtyS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 344)]
    public struct __Internal
    {
        internal IntPtr             data;
        internal IntPtr             loop;
        internal UvHandleType       type;
        internal IntPtr             close_cb;
        internal UvQueue.__Internal handle_queue;
        internal U.__Internal       u;
        internal IntPtr             endgame_next;
        internal uint               flags;
        internal ulong              write_queue_size;
        internal IntPtr             alloc_cb;
        internal IntPtr             read_cb;
        internal uint               reqs_pending;
        internal int                activecnt;
        internal UvReadS.__Internal read_req;
        internal Stream.__Internal  stream;
        internal IntPtr             handle;
        internal Tty.__Internal     tty;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_tty_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
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

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_tty_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
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

    public partial struct Stream
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal Serv.__Internal conn;

            [FieldOffset(0)]
            internal Serv.__Internal serv;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-stream>@uv_tty_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public partial class Serv : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal uint     write_reqs_pending;
                internal IntPtr shutdown_req;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-conn>@<unnamed-type-stream>@uv_tty_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, Serv> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr, Serv>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, Serv managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Serv managed)
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
                __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Serv(Serv __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
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

            public uint WriteReqsPending
            {
                get => ((__Internal*)__Instance)->write_reqs_pending;

                set => ((__Internal*)__Instance)->write_reqs_pending = value;
            }

            public UvShutdownS ShutdownReq
            {
                get
                {
                    var __result0 = UvShutdownS.__GetOrCreateInstance(((__Internal*)__Instance)->shutdown_req);
                    return __result0;
                }

                set => ((__Internal*)__Instance)->shutdown_req = value is null ? IntPtr.Zero : value.__Instance;
            }
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

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
            __instance = *(__Internal*) native;
        }

        public Stream(Stream __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public Serv Conn
        {
            get => Serv.__CreateInstance(__instance.conn);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.conn = *(Serv.__Internal*) value.__Instance;
            }
        }

        public Serv serv
        {
            get => Serv.__CreateInstance(__instance.serv);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.serv = *(Serv.__Internal*) value.__Instance;
            }
        }
    }

    public partial struct Tty
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal Wr.__Internal rd;

            [FieldOffset(0)]
            internal Wr.__Internal wr;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-tty>@uv_tty_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public partial class Wr : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 64)]
            public struct __Internal
            {
                internal       IntPtr                  unused_;
                internal       UvBufT.__Internal       read_line_buffer;
                internal       IntPtr                  read_raw_wait;
                internal fixed sbyte                   last_key[8];
                internal       byte                    last_key_offset;
                internal       byte                    last_key_len;
                internal       char                    last_utf16_high_surrogate;
                internal       INPUT_RECORD.__Internal last_input_record;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-rd>@<unnamed-type-tty>@uv_tty_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, Wr> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr, Wr>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, Wr managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Wr managed)
            {
    
                return NativeToManagedMap.TryGetValue(native, out managed);
            }

            protected bool __ownsNativeInstance;

            internal static Wr __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                return new Wr(native.ToPointer(), skipVTables);
            }

            internal static Wr __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (__TryGetNativeToManagedMapping(native, out var managed))
                    return (Wr)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    __RecordNativeToManagedMapping(native, result);
                return result;
            }

            internal static Wr __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new Wr(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private Wr(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            protected Wr(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public Wr()
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Wr(Wr __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
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

            public IntPtr Unused
            {
                get => ((__Internal*)__Instance)->unused_;

                set => ((__Internal*)__Instance)->unused_ = value;
            }

            public UvBufT ReadLineBuffer
            {
                get => UvBufT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->read_line_buffer));

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    ((__Internal*)__Instance)->read_line_buffer = *(UvBufT.__Internal*) value.__Instance;
                }
            }

            public IntPtr ReadRawWait
            {
                get => ((__Internal*)__Instance)->read_raw_wait;

                set => ((__Internal*)__Instance)->read_raw_wait = value;
            }

            public sbyte[] LastKey
            {
                get => MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->last_key, 8);

                set
                {
                    if (value != null)
                    {
                        for (var i = 0; i < 8; i++)
                            ((__Internal*)__Instance)->last_key[i] = value[i];
                    }
                }
            }

            public byte LastKeyOffset
            {
                get => ((__Internal*)__Instance)->last_key_offset;

                set => ((__Internal*)__Instance)->last_key_offset = value;
            }

            public byte LastKeyLen
            {
                get => ((__Internal*)__Instance)->last_key_len;

                set => ((__Internal*)__Instance)->last_key_len = value;
            }

            public char LastUtf16HighSurrogate
            {
                get => ((__Internal*)__Instance)->last_utf16_high_surrogate;

                set => ((__Internal*)__Instance)->last_utf16_high_surrogate = value;
            }
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

        internal static Tty __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Tty(native.ToPointer(), skipVTables);
        }

        internal static Tty __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Tty(native, skipVTables);
        }

        private Tty(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Tty(void* native, bool skipVTables = false) : this()
        {
            __instance = *(__Internal*) native;
        }

        public Tty(Tty __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public Wr Rd
        {
            get => Wr.__CreateInstance(__instance.rd);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.rd = *(Wr.__Internal*) value.__Instance;
            }
        }

        public Wr wr
        {
            get => Wr.__CreateInstance(__instance.wr);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.wr = *(Wr.__Internal*) value.__Instance;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvTtyS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvTtyS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvTtyS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvTtyS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvTtyS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvTtyS(native.ToPointer(), skipVTables);
    }

    internal static UvTtyS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvTtyS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvTtyS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvTtyS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvTtyS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvTtyS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvTtyS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvTtyS(UvTtyS _0)
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

    public IntPtr Data
    {
        get => ((__Internal*)__Instance)->data;

        set => ((__Internal*)__Instance)->data = value;
    }

    public UvLoop Loop
    {
        get
        {
            var __result0 = UvLoop.__GetOrCreateInstance(((__Internal*)__Instance)->loop);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public UvHandleType Type
    {
        get => ((__Internal*)__Instance)->type;

        set => ((__Internal*)__Instance)->type = value;
    }

    public UvCloseCb CloseCb
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
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->handle_queue = *(UvQueue.__Internal*) value.__Instance;
        }
    }

    public U u
    {
        get => U.__CreateInstance(((__Internal*)__Instance)->u);

        set => ((__Internal*)__Instance)->u = value.__Instance;
    }

    public UvHandleS EndgameNext
    {
        get
        {
            var __result0 = UvHandleS.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_next);
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

    public UvAllocCb AllocCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->alloc_cb;
            return __ptr0 == IntPtr.Zero? null : (UvAllocCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvAllocCb));
        }

        set => ((__Internal*)__Instance)->alloc_cb = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public UvReadCb ReadCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->read_cb;
            return __ptr0 == IntPtr.Zero? null : (UvReadCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvReadCb));
        }

        set => ((__Internal*)__Instance)->read_cb = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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

    public UvReadS ReadReq
    {
        get => UvReadS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->read_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->read_req = *(UvReadS.__Internal*) value.__Instance;
        }
    }

    public Stream stream
    {
        get => Stream.__CreateInstance(((__Internal*)__Instance)->stream);

        set => ((__Internal*)__Instance)->stream = value.__Instance;
    }

    public IntPtr Handle
    {
        get => ((__Internal*)__Instance)->handle;

        set => ((__Internal*)__Instance)->handle = value;
    }

    public Tty tty
    {
        get => Tty.__CreateInstance(((__Internal*)__Instance)->tty);

        set => ((__Internal*)__Instance)->tty = value.__Instance;
    }
}