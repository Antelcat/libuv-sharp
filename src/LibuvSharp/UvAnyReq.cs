using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial struct UvAnyReq
{
    [StructLayout(LayoutKind.Explicit, Size = 1368)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal UvReqS.__Internal req;

        [FieldOffset(0)]
        internal UvConnectS.__Internal connect;

        [FieldOffset(0)]
        internal UvWriteS.__Internal write;

        [FieldOffset(0)]
        internal UvShutdownS.__Internal shutdown;

        [FieldOffset(0)]
        internal UvUdpSendS.__Internal udp_send;

        [FieldOffset(0)]
        internal UvFsS.__Internal fs;

        [FieldOffset(0)]
        internal UvWorkS.__Internal work;

        [FieldOffset(0)]
        internal UvGetaddrinfoS.__Internal getaddrinfo;

        [FieldOffset(0)]
        internal UvGetnameinfoS.__Internal getnameinfo;

        [FieldOffset(0)]
        internal UvRandomS.__Internal random;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_any_req@@QEAA@AEBT0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    private  __Internal __instance;
    internal __Internal __Instance => __instance;

    internal static UvAnyReq __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return new UvAnyReq(native.ToPointer(), skipVTables);
    }

    internal static UvAnyReq __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvAnyReq(native, skipVTables);
    }

    private UvAnyReq(__Internal native, bool skipVTables = false)
        : this()
    {
        __instance = native;
    }

    private UvAnyReq(void* native, bool skipVTables = false) : this()
    {
        __instance = *(__Internal*) native;
    }

    public UvAnyReq(UvAnyReq _0)
        : this()
    {
        var ____arg0 = _0.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (__Internal* __instancePtr = &__instance)
        {
            __Internal.cctor(new IntPtr(__instancePtr), __arg0);
        }
    }

    public UvReqS Req
    {
        get => UvReqS.__CreateInstance(__instance.req);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.req = *(UvReqS.__Internal*) value.__Instance;
        }
    }

    public UvConnectS Connect
    {
        get => UvConnectS.__CreateInstance(__instance.connect);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.connect = *(UvConnectS.__Internal*) value.__Instance;
        }
    }

    public UvWriteS Write
    {
        get => UvWriteS.__CreateInstance(__instance.write);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.write = *(UvWriteS.__Internal*) value.__Instance;
        }
    }

    public UvShutdownS Shutdown
    {
        get => UvShutdownS.__CreateInstance(__instance.shutdown);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.shutdown = *(UvShutdownS.__Internal*) value.__Instance;
        }
    }

    public UvUdpSendS UdpSend
    {
        get => UvUdpSendS.__CreateInstance(__instance.udp_send);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.udp_send = *(UvUdpSendS.__Internal*) value.__Instance;
        }
    }

    public UvFsS Fs
    {
        get => UvFsS.__CreateInstance(__instance.fs);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.fs = *(UvFsS.__Internal*) value.__Instance;
        }
    }

    public UvWorkS Work
    {
        get => UvWorkS.__CreateInstance(__instance.work);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.work = *(UvWorkS.__Internal*) value.__Instance;
        }
    }

    public UvGetaddrinfoS Getaddrinfo
    {
        get => UvGetaddrinfoS.__CreateInstance(__instance.getaddrinfo);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.getaddrinfo = *(UvGetaddrinfoS.__Internal*) value.__Instance;
        }
    }

    public UvGetnameinfoS Getnameinfo
    {
        get => UvGetnameinfoS.__CreateInstance(__instance.getnameinfo);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.getnameinfo = *(UvGetnameinfoS.__Internal*) value.__Instance;
        }
    }

    public UvRandomS Random
    {
        get => UvRandomS.__CreateInstance(__instance.random);

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            __instance.random = *(UvRandomS.__Internal*) value.__Instance;
        }
    }
}