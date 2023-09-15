using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvPrepareS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 120)]
    public partial struct __Internal
    {
        internal IntPtr                                   data;
        internal IntPtr                                   loop;
        internal global::LibuvSharp.UvHandleType            type;
        internal IntPtr                                   close_cb;
        internal global::LibuvSharp.UvQueue.__Internal      handle_queue;
        internal global::LibuvSharp.UvPrepareS.U.__Internal u;
        internal IntPtr                                   endgame_next;
        internal uint                                       flags;
        internal IntPtr                                   prepare_prev;
        internal IntPtr                                   prepare_next;
        internal IntPtr                                   prepare_cb;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_prepare_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int fd;

            [FieldOffset(0)]
            internal void* reserved;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-u>@uv_prepare_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
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
            __instance = *(global::LibuvSharp.UvPrepareS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvPrepareS.U __0)
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

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPrepareS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvPrepareS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvPrepareS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvPrepareS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvPrepareS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvPrepareS(native.ToPointer(), skipVTables);
    }

    internal static UvPrepareS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvPrepareS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvPrepareS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvPrepareS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvPrepareS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvPrepareS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvPrepareS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPrepareS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvPrepareS(global::LibuvSharp.UvPrepareS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvPrepareS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvPrepareS.__Internal*) __Instance) = *((global::LibuvSharp.UvPrepareS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvLoopS Loop
    {
        get
        {
            var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvHandleType Type
    {
        get => ((__Internal*)__Instance)->type;

        set => ((__Internal*)__Instance)->type = value;
    }

    public global::LibuvSharp.UvCloseCb CloseCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->close_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvCloseCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvCloseCb));
        }

        set => ((__Internal*)__Instance)->close_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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

    public global::LibuvSharp.UvPrepareS.U u
    {
        get => global::LibuvSharp.UvPrepareS.U.__CreateInstance(((__Internal*)__Instance)->u);

        set => ((__Internal*)__Instance)->u = value.__Instance;
    }

    public global::LibuvSharp.UvHandleS EndgameNext
    {
        get
        {
            var __result0 = global::LibuvSharp.UvHandleS.__GetOrCreateInstance(((__Internal*)__Instance)->endgame_next, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->endgame_next = value is null ? IntPtr.Zero : value.__Instance;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
    }

    public global::LibuvSharp.UvPrepareS PreparePrev
    {
        get
        {
            var __result0 = global::LibuvSharp.UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->prepare_prev, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->prepare_prev = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvPrepareS PrepareNext
    {
        get
        {
            var __result0 = global::LibuvSharp.UvPrepareS.__GetOrCreateInstance(((__Internal*)__Instance)->prepare_next, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->prepare_next = value is null ? IntPtr.Zero : value.__Instance;
    }

    public global::LibuvSharp.UvPrepareCb PrepareCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->prepare_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvPrepareCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvPrepareCb));
        }

        set => ((__Internal*)__Instance)->prepare_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }
}