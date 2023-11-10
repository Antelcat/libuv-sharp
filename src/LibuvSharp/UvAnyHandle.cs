using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial struct UvAnyHandle
{
    [StructLayout(LayoutKind.Explicit, Size = 576)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal UvAsyncS.__Internal async;

        [FieldOffset(0)]
        internal UvCheckS.__Internal check;

        [FieldOffset(0)]
        internal UvFsEventS.__Internal fs_event;

        [FieldOffset(0)]
        internal UvFsPollS.__Internal fs_poll;

        [FieldOffset(0)]
        internal UvHandle.__Internal handle;

        [FieldOffset(0)]
        internal UvIdleS.__Internal idle;

        [FieldOffset(0)]
        internal UvPipeS.__Internal pipe;

        [FieldOffset(0)]
        internal UvPollS.__Internal poll;

        [FieldOffset(0)]
        internal UvPrepareS.__Internal prepare;

        [FieldOffset(0)]
        internal UvProcess.__Internal process;

        [FieldOffset(0)]
        internal UvStream.__Internal stream;

        [FieldOffset(0)]
        internal UvTcpS.__Internal tcp;

        [FieldOffset(0)]
        internal UvTimerS.__Internal timer;

        [FieldOffset(0)]
        internal UvTtyS.__Internal tty;

        [FieldOffset(0)]
        internal UvUdpS.__Internal udp;

        [FieldOffset(0)]
        internal UvSignalS.__Internal signal;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_any_handle@@QEAA@AEBT0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    private  __Internal __instance;
    internal __Internal __Instance => __instance;

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
        __instance = *(__Internal*) native;
    }

    public UvAnyHandle(UvAnyHandle _0)
        : this()
    {
        var ____arg0 = _0.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (__Internal* __instancePtr = &__instance)
        {
            __Internal.cctor(new IntPtr(__instancePtr), __arg0);
        }
    }

    public UvAsyncS Async
    {
        get => UvAsyncS.__CreateInstance(__instance.async);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.async = *(UvAsyncS.__Internal*) value.__Instance;
        }
    }

    public UvCheckS Check
    {
        get => UvCheckS.__CreateInstance(__instance.check);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.check = *(UvCheckS.__Internal*) value.__Instance;
        }
    }

    public UvFsEventS FsEvent
    {
        get => UvFsEventS.__CreateInstance(__instance.fs_event);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.fs_event = *(UvFsEventS.__Internal*) value.__Instance;
        }
    }

    public UvFsPollS FsPoll
    {
        get => UvFsPollS.__CreateInstance(__instance.fs_poll);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.fs_poll = *(UvFsPollS.__Internal*) value.__Instance;
        }
    }

    public UvHandle Handle
    {
        get => UvHandle.__CreateInstance(__instance.handle);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.handle = *(UvHandle.__Internal*) value.__Instance;
        }
    }

    public UvIdleS Idle
    {
        get => UvIdleS.__CreateInstance(__instance.idle);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.idle = *(UvIdleS.__Internal*) value.__Instance;
        }
    }

    public UvPipeS Pipe
    {
        get => UvPipeS.__CreateInstance(__instance.pipe);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.pipe = *(UvPipeS.__Internal*) value.__Instance;
        }
    }

    public UvPollS Poll
    {
        get => UvPollS.__CreateInstance(__instance.poll);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.poll = *(UvPollS.__Internal*) value.__Instance;
        }
    }

    public UvPrepareS Prepare
    {
        get => UvPrepareS.__CreateInstance(__instance.prepare);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.prepare = *(UvPrepareS.__Internal*) value.__Instance;
        }
    }

    public UvProcess Process
    {
        get => UvProcess.__CreateInstance(__instance.process);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.process = *(UvProcess.__Internal*) value.__Instance;
        }
    }

    public UvStream Stream
    {
        get => UvStream.__CreateInstance(__instance.stream);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.stream = *(UvStream.__Internal*) value.__Instance;
        }
    }

    public UvTcpS Tcp
    {
        get => UvTcpS.__CreateInstance(__instance.tcp);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.tcp = *(UvTcpS.__Internal*) value.__Instance;
        }
    }

    public UvTimerS Timer
    {
        get => UvTimerS.__CreateInstance(__instance.timer);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.timer = *(UvTimerS.__Internal*) value.__Instance;
        }
    }

    public UvTtyS Tty
    {
        get => UvTtyS.__CreateInstance(__instance.tty);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.tty = *(UvTtyS.__Internal*) value.__Instance;
        }
    }

    public UvUdpS Udp
    {
        get => UvUdpS.__CreateInstance(__instance.udp);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.udp = *(UvUdpS.__Internal*) value.__Instance;
        }
    }

    public UvSignalS Signal
    {
        get => UvSignalS.__CreateInstance(__instance.signal);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.signal = *(UvSignalS.__Internal*) value.__Instance;
        }
    }
}