using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvRandomS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 192)]
    public partial struct __Internal
    {
        internal IntPtr                                  data;
        internal global::LibuvSharp.UvReqType              type;
        internal void*                                     reserved;
        internal global::LibuvSharp.UvRandomS.U.__Internal u;
        internal IntPtr                                  next_req;
        internal IntPtr                                  loop;
        internal int                                       status;
        internal IntPtr                                  buf;
        internal ulong                                     buflen;
        internal IntPtr                                  cb;
        internal global::LibuvSharp.UvWork.__Internal      work_req;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_random_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.UvRandomS.U.Connect.__Internal io;

            [FieldOffset(0)]
            internal global::LibuvSharp.UvRandomS.U.Connect.__Internal connect;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_random_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class Connect : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 40)]
            public partial struct __Internal
            {
                internal global::OVERLAPPED.__Internal overlapped;
                internal ulong                         queued_bytes;

                [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_random_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvRandomS.U.Connect> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvRandomS.U.Connect>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvRandomS.U.Connect managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvRandomS.U.Connect managed)
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
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvRandomS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Connect(global::LibuvSharp.UvRandomS.U.Connect __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvRandomS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((global::LibuvSharp.UvRandomS.U.Connect.__Internal*) __Instance) = *((global::LibuvSharp.UvRandomS.U.Connect.__Internal*) __0.__Instance);
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
            __instance = *(global::LibuvSharp.UvRandomS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvRandomS.U __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public global::LibuvSharp.UvRandomS.U.Connect Io
        {
            get => global::LibuvSharp.UvRandomS.U.Connect.__CreateInstance(__instance.io);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.io = *(global::LibuvSharp.UvRandomS.U.Connect.__Internal*) value.__Instance;
            }
        }

        public global::LibuvSharp.UvRandomS.U.Connect connect
        {
            get => global::LibuvSharp.UvRandomS.U.Connect.__CreateInstance(__instance.connect);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.connect = *(global::LibuvSharp.UvRandomS.U.Connect.__Internal*) value.__Instance;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvRandomS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvRandomS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvRandomS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvRandomS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvRandomS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvRandomS(native.ToPointer(), skipVTables);
    }

    internal static UvRandomS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvRandomS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvRandomS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvRandomS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvRandomS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvRandomS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvRandomS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvRandomS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvRandomS(global::LibuvSharp.UvRandomS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvRandomS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvRandomS.__Internal*) __Instance) = *((global::LibuvSharp.UvRandomS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvRandomS.U u
    {
        get => global::LibuvSharp.UvRandomS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    public global::LibuvSharp.UvLoopS Loop
    {
        get
        {
            var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public int Status
    {
        get => ((__Internal*)__Instance)->status;

        set => ((__Internal*)__Instance)->status = value;
    }

    public IntPtr Buf
    {
        get => ((__Internal*)__Instance)->buf;

        set => ((__Internal*)__Instance)->buf = (IntPtr) value;
    }

    public ulong Buflen
    {
        get => ((__Internal*)__Instance)->buflen;

        set => ((__Internal*)__Instance)->buflen = value;
    }

    public global::LibuvSharp.UvRandomCb Cb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvRandomCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvRandomCb));
        }

        set => ((__Internal*)__Instance)->cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public global::LibuvSharp.UvWork WorkReq
    {
        get => global::LibuvSharp.UvWork.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->work_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->work_req = *(global::LibuvSharp.UvWork.__Internal*) value.__Instance;
        }
    }
}