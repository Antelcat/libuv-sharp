using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvFsS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 456)]
    public partial struct __Internal
    {
        internal IntPtr                               data;
        internal global::LibuvSharp.UvReqType           type;
        internal void*                                  reserved;
        internal global::LibuvSharp.UvFsS.U.__Internal  u;
        internal IntPtr                               next_req;
        internal global::LibuvSharp.UvFsType            fs_type;
        internal IntPtr                               loop;
        internal IntPtr                               cb;
        internal long                                   result;
        internal IntPtr                               ptr;
        internal IntPtr                               path;
        internal global::LibuvSharp.UvStatT.__Internal  statbuf;
        internal global::LibuvSharp.UvWork.__Internal   work_req;
        internal int                                    flags;
        internal uint                                   sys_errno_;
        internal global::LibuvSharp.UvFsS.Fs.__Internal file;
        internal global::LibuvSharp.UvFsS.Fs.__Internal fs;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_fs_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::LibuvSharp.UvFsS.U.Connect.__Internal io;

            [FieldOffset(0)]
            internal global::LibuvSharp.UvFsS.U.Connect.__Internal connect;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_fs_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class Connect : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 40)]
            public partial struct __Internal
            {
                internal global::OVERLAPPED.__Internal overlapped;
                internal ulong                         queued_bytes;

                [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_fs_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsS.U.Connect> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsS.U.Connect>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvFsS.U.Connect managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvFsS.U.Connect managed)
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
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Connect(global::LibuvSharp.UvFsS.U.Connect __0)
            {
                __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsS.U.Connect.__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((global::LibuvSharp.UvFsS.U.Connect.__Internal*) __Instance) = *((global::LibuvSharp.UvFsS.U.Connect.__Internal*) __0.__Instance);
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
            __instance = *(global::LibuvSharp.UvFsS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvFsS.U __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public global::LibuvSharp.UvFsS.U.Connect Io
        {
            get => global::LibuvSharp.UvFsS.U.Connect.__CreateInstance(__instance.io);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.io = *(global::LibuvSharp.UvFsS.U.Connect.__Internal*) value.__Instance;
            }
        }

        public global::LibuvSharp.UvFsS.U.Connect connect
        {
            get => global::LibuvSharp.UvFsS.U.Connect.__CreateInstance(__instance.connect);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.connect = *(global::LibuvSharp.UvFsS.U.Connect.__Internal*) value.__Instance;
            }
        }
    }

    public unsafe partial struct Fs
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal IntPtr pathw;

            [FieldOffset(0)]
            internal int fd;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-file>@uv_fs_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  Fs.__Internal __instance;
        internal Fs.__Internal __Instance => __instance;

        internal static Fs __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Fs(native.ToPointer(), skipVTables);
        }

        internal static Fs __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Fs(native, skipVTables);
        }

        private Fs(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Fs(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvFsS.Fs.__Internal*) native;
        }

        public Fs(global::LibuvSharp.UvFsS.Fs __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public char* Pathw
        {
            get => (char*) __instance.pathw;

            set => __instance.pathw = (IntPtr) value;
        }

        public int Fd
        {
            get => __instance.fd;

            set => __instance.fd = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvFsS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvFsS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvFsS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __path_OwnsNativeMemory = false;
    protected bool __ownsNativeInstance;

    internal static UvFsS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvFsS(native.ToPointer(), skipVTables);
    }

    internal static UvFsS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvFsS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvFsS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvFsS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvFsS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvFsS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvFsS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvFsS(global::LibuvSharp.UvFsS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvFsS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvFsS.__Internal*) __Instance) = *((global::LibuvSharp.UvFsS.__Internal*) _0.__Instance);
        if (_0.__path_OwnsNativeMemory)
            this.Path = _0.Path;
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
        if (__path_OwnsNativeMemory)
            Marshal.FreeHGlobal(((__Internal*)__Instance)->path);
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

    public global::LibuvSharp.UvFsS.U u
    {
        get => global::LibuvSharp.UvFsS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    public global::LibuvSharp.UvFsType FsType
    {
        get => ((__Internal*)__Instance)->fs_type;

        set => ((__Internal*)__Instance)->fs_type = value;
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

    public global::LibuvSharp.UvFsCb Cb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvFsCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvFsCb));
        }

        set => ((__Internal*)__Instance)->cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public long Result
    {
        get => ((__Internal*)__Instance)->result;

        set => ((__Internal*)__Instance)->result = value;
    }

    public IntPtr Ptr
    {
        get => ((__Internal*)__Instance)->ptr;

        set => ((__Internal*)__Instance)->ptr = (IntPtr) value;
    }

    public string Path
    {
        get => CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->path);

        set
        {
            if (__path_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->path);
            __path_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->path = global::System.IntPtr.Zero;
                return;
            }
            var __bytes0   = global::System.Text.Encoding.UTF8.GetBytes(value);
            var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
            Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
            Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
            ((__Internal*)__Instance)->path = (IntPtr) __bytePtr0;
        }
    }

    public global::LibuvSharp.UvStatT Statbuf
    {
        get => global::LibuvSharp.UvStatT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->statbuf));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->statbuf = *(global::LibuvSharp.UvStatT.__Internal*) value.__Instance;
        }
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

    public int Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
    }

    public uint SysErrno
    {
        get => ((__Internal*)__Instance)->sys_errno_;

        set => ((__Internal*)__Instance)->sys_errno_ = value;
    }

    public global::LibuvSharp.UvFsS.Fs File
    {
        get => global::LibuvSharp.UvFsS.Fs.__CreateInstance(((__Internal*)__Instance)->file);

        set => ((__Internal*)__Instance)->file = value.__Instance;
    }

    public global::LibuvSharp.UvFsS.Fs fs
    {
        get => global::LibuvSharp.UvFsS.Fs.__CreateInstance(((__Internal*)__Instance)->fs);

        set => ((__Internal*)__Instance)->fs = value.__Instance;
    }
}