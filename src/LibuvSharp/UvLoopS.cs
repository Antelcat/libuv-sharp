using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class UvLoopS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 472)]
    public struct __Internal
    {
        internal       IntPtr                          data;
        internal       uint                            active_handles;
        internal       UvQueue.__Internal              handle_queue;
        internal       ActiveReqs.__Internal           active_reqs;
        internal       IntPtr                          internal_fields;
        internal       uint                            stop_flag;
        internal       IntPtr                          iocp;
        internal       ulong                           time;
        internal       IntPtr                          pending_reqs_tail;
        internal       IntPtr                          endgame_handles;
        internal       IntPtr                          timer_heap;
        internal       IntPtr                          prepare_handles;
        internal       IntPtr                          check_handles;
        internal       IntPtr                          idle_handles;
        internal       IntPtr                          next_prepare_handle;
        internal       IntPtr                          next_check_handle;
        internal       IntPtr                          next_idle_handle;
        internal fixed ulong                           poll_peer_sockets[4];
        internal       uint                            active_tcp_streams;
        internal       uint                            active_udp_streams;
        internal       ulong                           timer_counter;
        internal       UvQueue.__Internal              wq;
        internal       RTL_CRITICAL_SECTION.__Internal wq_mutex;
        internal       UvAsyncS.__Internal             wq_async;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_loop_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct ActiveReqs
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal IntPtr unused;

            [FieldOffset(0)]
            internal uint count;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-active_reqs>@uv_loop_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

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
            __instance = *(__Internal*) native;
        }

        public ActiveReqs(ActiveReqs __0)
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

            set => __instance.unused = value;
        }

        public uint Count
        {
            get => __instance.count;

            set => __instance.count = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvLoopS> NativeToManagedMap = new();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvLoopS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvLoopS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvLoopS? __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return native == IntPtr.Zero 
            ? null 
            : new UvLoopS(native.ToPointer(), skipVTables);
    }

    internal static UvLoopS? __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return managed;
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
        var ret = Marshal.AllocHGlobal((int)Uv.UvLoopSize());
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
        __Instance           = Uv.UvDefaultLoop().__Instance;
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        
    }

    public UvLoopS(UvLoopS _0)
    {
        __Instance           = Marshal.AllocHGlobal((int)Uv.UvLoopSize());
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

    public uint ActiveHandles
    {
        get => ((__Internal*)__Instance)->active_handles;

        set => ((__Internal*)__Instance)->active_handles = value;
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

    public ActiveReqs active_reqs
    {
        get => ActiveReqs.__CreateInstance(((__Internal*)__Instance)->active_reqs);

        set => ((__Internal*)__Instance)->active_reqs = value.__Instance;
    }

    public IntPtr InternalFields
    {
        get => ((__Internal*)__Instance)->internal_fields;

        set => ((__Internal*)__Instance)->internal_fields = value;
    }

    public uint StopFlag
    {
        get => ((__Internal*)__Instance)->stop_flag;

        set => ((__Internal*)__Instance)->stop_flag = value;
    }

    public IntPtr Iocp
    {
        get => ((__Internal*)__Instance)->iocp;

        set => ((__Internal*)__Instance)->iocp = value;
    }

    public ulong Time
    {
        get => ((__Internal*)__Instance)->time;

        set => ((__Internal*)__Instance)->time = value;
    }

    public UvReqS? PendingReqsTail
    {
        get
        {
            var __result0 = UvReqS.__GetOrCreateInstance(((__Internal*)__Instance)->pending_reqs_tail);
            return __result0;
        }

        set => ((__Internal*)__Instance)->pending_reqs_tail = value?.__Instance ?? IntPtr.Zero;
    }

    public UvHandleS? EndgameHandles
    {
        get
        {
            var __result0 = UvHandleS.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_handles);
            return __result0;
        }

        set => ((__Internal*)__Instance)->endgame_handles = value?.__Instance ?? IntPtr.Zero;
    }

    public IntPtr TimerHeap
    {
        get => ((__Internal*)__Instance)->timer_heap;

        set => ((__Internal*)__Instance)->timer_heap = value;
    }

    public UvPrepareS? PrepareHandles
    {
        get
        {
            var __result0 = UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->prepare_handles);
            return __result0;
        }

        set => ((__Internal*)__Instance)->prepare_handles = value?.__Instance ?? IntPtr.Zero;
    }

    public UvCheckS? CheckHandles
    {
        get
        {
            var __result0 = UvCheckS.__GetOrCreateInstance(((__Internal*)__Instance)->check_handles);
            return __result0;
        }

        set => ((__Internal*)__Instance)->check_handles = value?.__Instance ?? IntPtr.Zero;
    }

    public UvIdleS? IdleHandles
    {
        get
        {
            var __result0 = UvIdleS.__GetOrCreateInstance(((__Internal*)__Instance)->idle_handles);
            return __result0;
        }

        set => ((__Internal*)__Instance)->idle_handles = value?.__Instance ?? IntPtr.Zero;
    }

    public UvPrepareS? NextPrepareHandle
    {
        get
        {
            var __result0 = UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->next_prepare_handle);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_prepare_handle = value?.__Instance ?? IntPtr.Zero;
    }

    public UvCheckS? NextCheckHandle
    {
        get
        {
            var __result0 = UvCheckS.__GetOrCreateInstance(((__Internal*)__Instance)->next_check_handle);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_check_handle = value?.__Instance ?? IntPtr.Zero;
    }

    public UvIdleS? NextIdleHandle
    {
        get
        {
            var __result0 = UvIdleS.__GetOrCreateInstance(((__Internal*)__Instance)->next_idle_handle);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_idle_handle = value?.__Instance ?? IntPtr.Zero;
    }

    public ulong[]? PollPeerSockets
    {
        get => MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->poll_peer_sockets, 4);

        set
        {
            if (value == null) return;
            for (var i = 0; i < 4; i++)
                ((__Internal*)__Instance)->poll_peer_sockets[i] = value[i];
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

    public UvQueue Wq
    {
        get => UvQueue.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->wq));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->wq = *(UvQueue.__Internal*) value.__Instance;
        }
    }

    public UvAsyncS WqAsync
    {
        get => UvAsyncS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->wq_async));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->wq_async = *(UvAsyncS.__Internal*) value.__Instance;
        }
    }
}