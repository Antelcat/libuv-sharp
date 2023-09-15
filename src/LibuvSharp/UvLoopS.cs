using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvLoopS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 472)]
    public partial struct __Internal
    {
        internal       IntPtr                                         data;
        internal       uint                                             active_handles;
        internal       global::LibuvSharp.UvQueue.__Internal            handle_queue;
        internal       global::LibuvSharp.UvLoopS.ActiveReqs.__Internal active_reqs;
        internal       IntPtr                                         internal_fields;
        internal       uint                                             stop_flag;
        internal       IntPtr                                         iocp;
        internal       ulong                                            time;
        internal       IntPtr                                         pending_reqs_tail;
        internal       IntPtr                                         endgame_handles;
        internal       IntPtr                                         timer_heap;
        internal       IntPtr                                         prepare_handles;
        internal       IntPtr                                         check_handles;
        internal       IntPtr                                         idle_handles;
        internal       IntPtr                                         next_prepare_handle;
        internal       IntPtr                                         next_check_handle;
        internal       IntPtr                                         next_idle_handle;
        internal fixed ulong                                            poll_peer_sockets[4];
        internal       uint                                             active_tcp_streams;
        internal       uint                                             active_udp_streams;
        internal       ulong                                            timer_counter;
        internal       global::LibuvSharp.UvQueue.__Internal            wq;
        internal       global::RTL_CRITICAL_SECTION.__Internal          wq_mutex;
        internal       global::LibuvSharp.UvAsyncS.__Internal           wq_async;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_loop_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct ActiveReqs
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal IntPtr unused;

            [FieldOffset(0)]
            internal uint count;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-active_reqs>@uv_loop_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  ActiveReqs.__Internal __instance;
        internal ActiveReqs.__Internal __Instance => __instance;

        internal static ActiveReqs __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new ActiveReqs(native.ToPointer(), skipVTables);
        }

        internal static ActiveReqs __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new ActiveReqs(native, skipVTables);
        }

        private ActiveReqs(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private ActiveReqs(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvLoopS.ActiveReqs.__Internal*) native;
        }

        public ActiveReqs(global::LibuvSharp.UvLoopS.ActiveReqs __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public IntPtr Unused
        {
            get => __instance.unused;

            set => __instance.unused = (IntPtr) value;
        }

        public uint Count
        {
            get => __instance.count;

            set => __instance.count = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvLoopS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvLoopS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvLoopS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvLoopS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvLoopS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvLoopS(native.ToPointer(), skipVTables);
    }

    internal static UvLoopS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvLoopS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvLoopS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvLoopS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvLoopS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvLoopS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvLoopS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvLoopS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvLoopS(global::LibuvSharp.UvLoopS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvLoopS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvLoopS.__Internal*) __Instance) = *((global::LibuvSharp.UvLoopS.__Internal*) _0.__Instance);
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

    public uint ActiveHandles
    {
        get => ((__Internal*)__Instance)->active_handles;

        set => ((__Internal*)__Instance)->active_handles = value;
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

    public global::LibuvSharp.UvLoopS.ActiveReqs active_reqs
    {
        get => global::LibuvSharp.UvLoopS.ActiveReqs.__CreateInstance(((__Internal*)__Instance)->active_reqs);

        set => ((__Internal*)__Instance)->active_reqs = value.__Instance;
    }

    public IntPtr InternalFields
    {
        get => ((__Internal*)__Instance)->internal_fields;

        set => ((__Internal*)__Instance)->internal_fields = (IntPtr) value;
    }

    public uint StopFlag
    {
        get => ((__Internal*)__Instance)->stop_flag;

        set => ((__Internal*)__Instance)->stop_flag = value;
    }

    public IntPtr Iocp
    {
        get => ((__Internal*)__Instance)->iocp;

        set => ((__Internal*)__Instance)->iocp = (IntPtr) value;
    }

    public ulong Time
    {
        get => ((__Internal*)__Instance)->time;

        set => ((__Internal*)__Instance)->time = value;
    }

    public global::LibuvSharp.UvReqS PendingReqsTail
    {
        get
        {
            var __result0 = global::LibuvSharp.UvReqS.__GetOrCreateInstance(((__Internal*)__Instance)->pending_reqs_tail, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->pending_reqs_tail = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvHandleS EndgameHandles
    {
        get
        {
            var __result0 = global::LibuvSharp.UvHandleS.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_handles, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->endgame_handles = value is null ? IntPtr.Zero : value.__Instance;
    }

    public IntPtr TimerHeap
    {
        get => ((__Internal*)__Instance)->timer_heap;

        set => ((__Internal*)__Instance)->timer_heap = (IntPtr) value;
    }

    public global::LibuvSharp.UvPrepareS PrepareHandles
    {
        get
        {
            var __result0 = global::LibuvSharp.UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->prepare_handles, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->prepare_handles = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvCheckS CheckHandles
    {
        get
        {
            var __result0 = global::LibuvSharp.UvCheckS.__GetOrCreateInstance(((__Internal*)__Instance)->check_handles, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->check_handles = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvIdleS IdleHandles
    {
        get
        {
            var __result0 = global::LibuvSharp.UvIdleS.__GetOrCreateInstance(((__Internal*)__Instance)->idle_handles, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->idle_handles = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvPrepareS NextPrepareHandle
    {
        get
        {
            var __result0 = global::LibuvSharp.UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->next_prepare_handle, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_prepare_handle = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvCheckS NextCheckHandle
    {
        get
        {
            var __result0 = global::LibuvSharp.UvCheckS.__GetOrCreateInstance(((__Internal*)__Instance)->next_check_handle, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_check_handle = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvIdleS NextIdleHandle
    {
        get
        {
            var __result0 = global::LibuvSharp.UvIdleS.__GetOrCreateInstance(((__Internal*)__Instance)->next_idle_handle, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_idle_handle = value is null ? IntPtr.Zero : value.__Instance;
    }

    public ulong[] PollPeerSockets
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->poll_peer_sockets, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->poll_peer_sockets[i] = value[i];
            }
        }
    }

    public uint ActiveTcpStreams
    {
        get => ((__Internal*)__Instance)->active_tcp_streams;

        set => ((__Internal*)__Instance)->active_tcp_streams = value;
    }

    public uint ActiveUdpStreams
    {
        get => ((__Internal*)__Instance)->active_udp_streams;

        set => ((__Internal*)__Instance)->active_udp_streams = value;
    }

    public ulong TimerCounter
    {
        get => ((__Internal*)__Instance)->timer_counter;

        set => ((__Internal*)__Instance)->timer_counter = value;
    }

    public global::LibuvSharp.UvQueue Wq
    {
        get => global::LibuvSharp.UvQueue.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->wq));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->wq = *(global::LibuvSharp.UvQueue.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvAsyncS WqAsync
    {
        get => global::LibuvSharp.UvAsyncS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->wq_async));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->wq_async = *(global::LibuvSharp.UvAsyncS.__Internal*) value.__Instance;
        }
    }
}