using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial struct UvCondT
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal global::RTL_CONDITION_VARIABLE.__Internal cond_var;

        [FieldOffset(0)]
        internal global::LibuvSharp.UvCondT.Unused.__Internal unused_;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_cond_t@@QEAA@AEBT0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
    }

    public unsafe partial class Unused : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 64)]
        public partial struct __Internal
        {
            internal uint                                    waiters_count;
            internal global::RTL_CRITICAL_SECTION.__Internal waiters_count_lock;
            internal IntPtr                                signal_event;
            internal IntPtr                                broadcast_event;

            [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0<unnamed-type-unused_>@uv_cond_t@@QEAA@AEBU01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public IntPtr __Instance { get; protected set; }

        internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvCondT.Unused> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvCondT.Unused>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvCondT.Unused managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvCondT.Unused managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Unused __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new Unused(native.ToPointer(), skipVTables);
        }

        internal static Unused __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Unused)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Unused __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Unused(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Unused(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Unused(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public Unused()
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvCondT.Unused.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public Unused(global::LibuvSharp.UvCondT.Unused __0)
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvCondT.Unused.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::LibuvSharp.UvCondT.Unused.__Internal*) __Instance) = *((global::LibuvSharp.UvCondT.Unused.__Internal*) __0.__Instance);
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

        public uint WaitersCount
        {
            get => ((__Internal*)__Instance)->waiters_count;

            set => ((__Internal*)__Instance)->waiters_count = value;
        }

        public IntPtr SignalEvent
        {
            get => ((__Internal*)__Instance)->signal_event;

            set => ((__Internal*)__Instance)->signal_event = (IntPtr) value;
        }

        public IntPtr BroadcastEvent
        {
            get => ((__Internal*)__Instance)->broadcast_event;

            set => ((__Internal*)__Instance)->broadcast_event = (IntPtr) value;
        }
    }

    private  UvCondT.__Internal __instance;
    internal UvCondT.__Internal __Instance => __instance;

    internal static UvCondT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return new UvCondT(native.ToPointer(), skipVTables);
    }

    internal static UvCondT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvCondT(native, skipVTables);
    }

    private UvCondT(__Internal native, bool skipVTables = false)
        : this()
    {
        __instance = native;
    }

    private UvCondT(void* native, bool skipVTables = false) : this()
    {
        __instance = *(global::LibuvSharp.UvCondT.__Internal*) native;
    }

    public UvCondT(global::LibuvSharp.UvCondT __0)
        : this()
    {
        var ____arg0 = __0.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (__Internal* __instancePtr = &__instance)
        {
            __Internal.cctor(new IntPtr(__instancePtr), __arg0);
        }
    }

    public global::LibuvSharp.UvCondT.Unused unused_
    {
        get => global::LibuvSharp.UvCondT.Unused.__CreateInstance(__instance.unused_);

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            __instance.unused_ = *(global::LibuvSharp.UvCondT.Unused.__Internal*) value.__Instance;
        }
    }
}