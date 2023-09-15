using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial struct UvAnyReq
{
    [StructLayout(LayoutKind.Explicit, Size = 1368)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::LibuvSharp.UvReqS.__Internal req;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvConnectS.__Internal connect;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvWriteS.__Internal write;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvShutdownS.__Internal shutdown;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvUdpSendS.__Internal udp_send;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvFsS.__Internal fs;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvWorkS.__Internal work;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvGetaddrinfoS.__Internal getaddrinfo;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvGetnameinfoS.__Internal getnameinfo;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvRandomS.__Internal random;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_any_req@@QEAA@AEBT0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    private  UvAnyReq.__Internal __instance;
    internal UvAnyReq.__Internal __Instance => __instance;

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
        __instance = *(global::LibuvSharp.UvAnyReq.__Internal*) native;
    }

    public UvAnyReq(global::LibuvSharp.UvAnyReq _0)
        : this()
    {
        var ____arg0 = _0.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (__Internal* __instancePtr = &__instance)
        {
            __Internal.cctor(new IntPtr(__instancePtr), __arg0);
        }
    }

    public global::LibuvSharp.UvReqS Req
    {
        get => global::LibuvSharp.UvReqS.__CreateInstance(__instance.req);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.req = *(global::LibuvSharp.UvReqS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvConnectS Connect
    {
        get => global::LibuvSharp.UvConnectS.__CreateInstance(__instance.connect);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.connect = *(global::LibuvSharp.UvConnectS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvWriteS Write
    {
        get => global::LibuvSharp.UvWriteS.__CreateInstance(__instance.write);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.write = *(global::LibuvSharp.UvWriteS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvShutdownS Shutdown
    {
        get => global::LibuvSharp.UvShutdownS.__CreateInstance(__instance.shutdown);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.shutdown = *(global::LibuvSharp.UvShutdownS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvUdpSendS UdpSend
    {
        get => global::LibuvSharp.UvUdpSendS.__CreateInstance(__instance.udp_send);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.udp_send = *(global::LibuvSharp.UvUdpSendS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvFsS Fs
    {
        get => global::LibuvSharp.UvFsS.__CreateInstance(__instance.fs);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.fs = *(global::LibuvSharp.UvFsS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvWorkS Work
    {
        get => global::LibuvSharp.UvWorkS.__CreateInstance(__instance.work);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.work = *(global::LibuvSharp.UvWorkS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvGetaddrinfoS Getaddrinfo
    {
        get => global::LibuvSharp.UvGetaddrinfoS.__CreateInstance(__instance.getaddrinfo);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.getaddrinfo = *(global::LibuvSharp.UvGetaddrinfoS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvGetnameinfoS Getnameinfo
    {
        get => global::LibuvSharp.UvGetnameinfoS.__CreateInstance(__instance.getnameinfo);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.getnameinfo = *(global::LibuvSharp.UvGetnameinfoS.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvRandomS Random
    {
        get => global::LibuvSharp.UvRandomS.__CreateInstance(__instance.random);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.random = *(global::LibuvSharp.UvRandomS.__Internal*) value.__Instance;
        }
    }
}