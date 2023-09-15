﻿using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvSignalS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 264)]
    public partial struct __Internal
    {
        internal IntPtr                                          data;
        internal IntPtr                                          loop;
        internal global::LibuvSharp.UvHandleType                   type;
        internal IntPtr                                          close_cb;
        internal global::LibuvSharp.UvQueue.__Internal             handle_queue;
        internal global::LibuvSharp.UvSignalS.U.__Internal         u;
        internal IntPtr                                          endgame_next;
        internal uint                                              flags;
        internal IntPtr                                          signal_cb;
        internal int                                               signum;
        internal global::LibuvSharp.UvSignalS.TreeEntry.__Internal tree_entry;
        internal global::LibuvSharp.UvReqS.__Internal              signal_req;
        internal uint                                              pending_signum;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_signal_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
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

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_signal_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
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
            __instance = *(global::LibuvSharp.UvSignalS.U.__Internal*) native;
        }

        public U(global::LibuvSharp.UvSignalS.U __0)
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

    public unsafe partial class TreeEntry : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public partial struct __Internal
        {
            internal IntPtr rbe_left;
            internal IntPtr rbe_right;
            internal IntPtr rbe_parent;
            internal int      rbe_color;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-tree_entry>@uv_signal_s@@QEAA@AEBU01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public IntPtr __Instance { get; protected set; }

        internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvSignalS.TreeEntry> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvSignalS.TreeEntry>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvSignalS.TreeEntry managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvSignalS.TreeEntry managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static TreeEntry __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new TreeEntry(native.ToPointer(), skipVTables);
        }

        internal static TreeEntry __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (TreeEntry)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static TreeEntry __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new TreeEntry(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private TreeEntry(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected TreeEntry(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public TreeEntry()
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvSignalS.TreeEntry.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        public TreeEntry(global::LibuvSharp.UvSignalS.TreeEntry __0)
        {
            __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvSignalS.TreeEntry.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::LibuvSharp.UvSignalS.TreeEntry.__Internal*) __Instance) = *((global::LibuvSharp.UvSignalS.TreeEntry.__Internal*) __0.__Instance);
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

        public global::LibuvSharp.UvSignalS RbeLeft
        {
            get
            {
                var __result0 = global::LibuvSharp.UvSignalS.__GetOrCreateInstance(((__Internal*)__Instance)->rbe_left, false);
                return __result0;
            }

            set => ((__Internal*)__Instance)->rbe_left = value is null ? IntPtr.Zero : value.__Instance;
        }

        public global::LibuvSharp.UvSignalS RbeRight
        {
            get
            {
                var __result0 = global::LibuvSharp.UvSignalS.__GetOrCreateInstance(((__Internal*)__Instance)->rbe_right, false);
                return __result0;
            }

            set => ((__Internal*)__Instance)->rbe_right = value is null ? IntPtr.Zero : value.__Instance;
        }

        public global::LibuvSharp.UvSignalS RbeParent
        {
            get
            {
                var __result0 = global::LibuvSharp.UvSignalS.__GetOrCreateInstance(((__Internal*)__Instance)->rbe_parent, false);
                return __result0;
            }

            set => ((__Internal*)__Instance)->rbe_parent = value is null ? IntPtr.Zero : value.__Instance;
        }

        public int RbeColor
        {
            get => ((__Internal*)__Instance)->rbe_color;

            set => ((__Internal*)__Instance)->rbe_color = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvSignalS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvSignalS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvSignalS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvSignalS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvSignalS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvSignalS(native.ToPointer(), skipVTables);
    }

    internal static UvSignalS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvSignalS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvSignalS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvSignalS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvSignalS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvSignalS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvSignalS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvSignalS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvSignalS(global::LibuvSharp.UvSignalS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvSignalS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvSignalS.__Internal*) __Instance) = *((global::LibuvSharp.UvSignalS.__Internal*) _0.__Instance);
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

    public global::LibuvSharp.UvSignalS.U u
    {
        get => global::LibuvSharp.UvSignalS.U.__CreateInstance(((__Internal*)__Instance)->u);

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

    public global::LibuvSharp.UvSignalCb SignalCb
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->signal_cb;
            return __ptr0 == IntPtr.Zero? null : (global::LibuvSharp.UvSignalCb) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::LibuvSharp.UvSignalCb));
        }

        set => ((__Internal*)__Instance)->signal_cb = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public int Signum
    {
        get => ((__Internal*)__Instance)->signum;

        set => ((__Internal*)__Instance)->signum = value;
    }

    public global::LibuvSharp.UvSignalS.TreeEntry tree_entry
    {
        get => global::LibuvSharp.UvSignalS.TreeEntry.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->tree_entry));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->tree_entry = *(global::LibuvSharp.UvSignalS.TreeEntry.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvReqS SignalReq
    {
        get => global::LibuvSharp.UvReqS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->signal_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->signal_req = *(global::LibuvSharp.UvReqS.__Internal*) value.__Instance;
        }
    }

    public uint PendingSignum
    {
        get => ((__Internal*)__Instance)->pending_signum;

        set => ((__Internal*)__Instance)->pending_signum = value;
    }
}