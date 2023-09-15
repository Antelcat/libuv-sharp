using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvReqS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 112)]
    public partial struct __Internal
    {
        internal IntPtr                               data;
        internal global::LibuvSharp.UvReqType           type;
        internal void*                                  reserved;
        internal global::LibuvSharp.UvReqS.U.__Internal u;
        internal IntPtr                               next_req;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_req_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.UvReqS.U.Connect.__Internal io;

            [FieldOffset(0)]
            internal global::LibuvSharp.UvReqS.U.Connect.__Internal connect;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_req_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class Connect : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 40)]
            public partial struct __Internal
            {
                internal global::OVERLAPPED.__Internal overlapped;
                internal ulong                         queued_bytes;

                [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_req_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvReqS.U.Connect> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvReqS.U.Connect>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvReqS.U.Connect managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvReqS.U.Connect managed)
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
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvReqS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Connect(global::LibuvSharp.UvReqS.U.Connect __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvReqS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((global::LibuvSharp.UvReqS.U.Connect.__Internal*) __Instance) = *((global::LibuvSharp.UvReqS.U.Connect.__Internal*) __0.__Instance);
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
            __instance = *(global::LibuvSharp.UvReqS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvReqS.U __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public global::LibuvSharp.UvReqS.U.Connect Io
        {
            get => global::LibuvSharp.UvReqS.U.Connect.__CreateInstance(__instance.io);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.io = *(global::LibuvSharp.UvReqS.U.Connect.__Internal*) value.__Instance;
            }
        }

        public global::LibuvSharp.UvReqS.U.Connect connect
        {
            get => global::LibuvSharp.UvReqS.U.Connect.__CreateInstance(__instance.connect);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.connect = *(global::LibuvSharp.UvReqS.U.Connect.__Internal*) value.__Instance;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvReqS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvReqS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvReqS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvReqS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvReqS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvReqS(native.ToPointer(), skipVTables);
    }

    internal static UvReqS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvReqS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvReqS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvReqS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvReqS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvReqS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvReqS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvReqS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvReqS(global::LibuvSharp.UvReqS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvReqS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvReqS.__Internal*) __Instance) = *((global::LibuvSharp.UvReqS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvReqS.U u
    {
        get => global::LibuvSharp.UvReqS.U.__CreateInstance(((__Internal*)__Instance)->u);

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