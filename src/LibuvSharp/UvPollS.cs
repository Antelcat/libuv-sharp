﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvPollS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 416)]
    public struct __Internal
    {
        internal IntPtr                   data;
        internal IntPtr                   loop;
        internal UvHandleType             type;
        internal IntPtr                   close_cb;
        internal UvQueue.__Internal       handle_queue;
        internal U.__Internal             u;
        internal IntPtr                   endgame_next;
        internal uint                     flags;
        internal IntPtr                   poll_cb;
        internal ulong                    socket;
        internal ulong                    peer_socket;
        internal AFD_POLL_INFO.__Internal afd_poll_info_1;
        internal AFD_POLL_INFO.__Internal afd_poll_info_2;
        internal UvReqS.__Internal        poll_req_1;
        internal UvReqS.__Internal        poll_req_2;
        internal byte                     submitted_events_1;
        internal byte                     submitted_events_2;
        internal byte                     mask_events_1;
        internal byte                     mask_events_2;
        internal byte                     events;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_poll_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
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

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_poll_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
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

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvPollS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvPollS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvPollS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvPollS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvPollS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvPollS(native.ToPointer(), skipVTables);
    }

    internal static UvPollS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvPollS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvPollS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvPollS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvPollS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvPollS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvPollS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvPollS(UvPollS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((__Internal*) __Instance) = *((__Internal*) _0.__Instance);
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

    public UvLoopS Loop
    {
        get
        {
            var __result0 = UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop);
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

    public UvPollCb PollCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->poll_cb;
            return __ptr0 == IntPtr.Zero? null : (UvPollCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(UvPollCb));
        }

        set => ((__Internal*)__Instance)->poll_cb = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public ulong Socket
    {
        get => ((__Internal*)__Instance)->socket;

        set => ((__Internal*)__Instance)->socket = value;
    }

    public ulong PeerSocket
    {
        get => ((__Internal*)__Instance)->peer_socket;

        set => ((__Internal*)__Instance)->peer_socket = value;
    }

    public AFD_POLL_INFO AfdPollInfo1
    {
        get => AFD_POLL_INFO.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->afd_poll_info_1));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->afd_poll_info_1 = *(AFD_POLL_INFO.__Internal*) value.__Instance;
        }
    }

    public AFD_POLL_INFO AfdPollInfo2
    {
        get => AFD_POLL_INFO.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->afd_poll_info_2));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->afd_poll_info_2 = *(AFD_POLL_INFO.__Internal*) value.__Instance;
        }
    }

    public UvReqS PollReq1
    {
        get => UvReqS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->poll_req_1));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->poll_req_1 = *(UvReqS.__Internal*) value.__Instance;
        }
    }

    public UvReqS PollReq2
    {
        get => UvReqS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->poll_req_2));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->poll_req_2 = *(UvReqS.__Internal*) value.__Instance;
        }
    }

    public byte SubmittedEvents1
    {
        get => ((__Internal*)__Instance)->submitted_events_1;

        set => ((__Internal*)__Instance)->submitted_events_1 = value;
    }

    public byte SubmittedEvents2
    {
        get => ((__Internal*)__Instance)->submitted_events_2;

        set => ((__Internal*)__Instance)->submitted_events_2 = value;
    }

    public byte MaskEvents1
    {
        get => ((__Internal*)__Instance)->mask_events_1;

        set => ((__Internal*)__Instance)->mask_events_1 = value;
    }

    public byte MaskEvents2
    {
        get => ((__Internal*)__Instance)->mask_events_2;

        set => ((__Internal*)__Instance)->mask_events_2 = value;
    }

    public byte Events
    {
        get => ((__Internal*)__Instance)->events;

        set => ((__Internal*)__Instance)->events = value;
    }
}