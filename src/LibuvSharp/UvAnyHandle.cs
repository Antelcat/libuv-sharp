using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial struct UvAnyHandle
{
    [StructLayout(LayoutKind.Explicit, Size = 576)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::LibuvSharp.UvAsyncS.__Internal async;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvCheckS.__Internal check;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvFsEventS.__Internal fs_event;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvFsPollS.__Internal fs_poll;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvHandleS.__Internal handle;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvIdleS.__Internal idle;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvPipeS.__Internal pipe;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvPollS.__Internal poll;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvPrepareS.__Internal prepare;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvProcessS.__Internal process;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvStreamS.__Internal stream;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvTcpS.__Internal tcp;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvTimerS.__Internal timer;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvTtyS.__Internal tty;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvUdpS.__Internal udp;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvSignalS.__Internal signal;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_any_handle@@QEAA@AEBT0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    private  UvAnyHandle.__Internal __instance;
    internal UvAnyHandle.__Internal __Instance => __instance;

    internal static UvAnyHandle __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return new UvAnyHandle(native.ToPointer(), skipVTables);
    }

    internal static UvAnyHandle __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvAnyHandle(native, skipVTables);
    }

    private UvAnyHandle(__Internal native, bool skipVTables = false)
        : this()
    {
        __instance = native;
    }

    private UvAnyHandle(void* native, bool skipVTables = false) : this()
    {
        __instance = *(global::LibuvSharp.UvAnyHandle.__Internal*) native;
    }

    public UvAnyHandle(global::LibuvSharp.UvAnyHandle _0)
        : this()
    {
        var ____arg0 = _0.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (__Internal* __instancePtr = &__instance)
        {
            __Internal.cctor(new IntPtr(__instancePtr), __arg0);
        }
    }

    public global::LibuvSharp.UvAsyncS Async
    {
        get => global::LibuvSharp.UvAsyncS.__CreateInstance(__instance.async);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.async = *(global::LibuvSharp.UvAsyncS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvCheckS Check
    {
        get => global::LibuvSharp.UvCheckS.__CreateInstance(__instance.check);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.check = *(global::LibuvSharp.UvCheckS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvFsEventS FsEvent
    {
        get => global::LibuvSharp.UvFsEventS.__CreateInstance(__instance.fs_event);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.fs_event = *(global::LibuvSharp.UvFsEventS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvFsPollS FsPoll
    {
        get => global::LibuvSharp.UvFsPollS.__CreateInstance(__instance.fs_poll);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.fs_poll = *(global::LibuvSharp.UvFsPollS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvHandleS Handle
    {
        get => global::LibuvSharp.UvHandleS.__CreateInstance(__instance.handle);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.handle = *(global::LibuvSharp.UvHandleS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvIdleS Idle
    {
        get => global::LibuvSharp.UvIdleS.__CreateInstance(__instance.idle);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.idle = *(global::LibuvSharp.UvIdleS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvPipeS Pipe
    {
        get => global::LibuvSharp.UvPipeS.__CreateInstance(__instance.pipe);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.pipe = *(global::LibuvSharp.UvPipeS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvPollS Poll
    {
        get => global::LibuvSharp.UvPollS.__CreateInstance(__instance.poll);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.poll = *(global::LibuvSharp.UvPollS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvPrepareS Prepare
    {
        get => global::LibuvSharp.UvPrepareS.__CreateInstance(__instance.prepare);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.prepare = *(global::LibuvSharp.UvPrepareS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvProcessS Process
    {
        get => global::LibuvSharp.UvProcessS.__CreateInstance(__instance.process);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.process = *(global::LibuvSharp.UvProcessS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvStreamS Stream
    {
        get => global::LibuvSharp.UvStreamS.__CreateInstance(__instance.stream);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.stream = *(global::LibuvSharp.UvStreamS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTcpS Tcp
    {
        get => global::LibuvSharp.UvTcpS.__CreateInstance(__instance.tcp);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.tcp = *(global::LibuvSharp.UvTcpS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTimerS Timer
    {
        get => global::LibuvSharp.UvTimerS.__CreateInstance(__instance.timer);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.timer = *(global::LibuvSharp.UvTimerS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTtyS Tty
    {
        get => global::LibuvSharp.UvTtyS.__CreateInstance(__instance.tty);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.tty = *(global::LibuvSharp.UvTtyS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvUdpS Udp
    {
        get => global::LibuvSharp.UvUdpS.__CreateInstance(__instance.udp);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.udp = *(global::LibuvSharp.UvUdpS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvSignalS Signal
    {
        get => global::LibuvSharp.UvSignalS.__CreateInstance(__instance.signal);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.signal = *(global::LibuvSharp.UvSignalS.__Internal*) value.__Instance;
        }
    }
}