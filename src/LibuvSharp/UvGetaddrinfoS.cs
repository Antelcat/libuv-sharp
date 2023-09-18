﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvGetaddrinfoS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 216)]
    public struct __Internal
    {
        internal IntPtr            data;
        internal UvReqType         type;
        internal void*             reserved;
        internal U.__Internal      u;
        internal IntPtr            next_req;
        internal IntPtr            loop;
        internal UvWork.__Internal work_req;
        internal IntPtr            getaddrinfo_cb;
        internal IntPtr            alloc;
        internal IntPtr            node;
        internal IntPtr            service;
        internal IntPtr            addrinfow;
        internal IntPtr            addrinfo;
        internal int               retcode;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_getaddrinfo_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct U
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal Connect.__Internal io;

            [FieldOffset(0)]
            internal Connect.__Internal connect;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-u>@uv_getaddrinfo_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        public partial class Connect : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 40)]
            public struct __Internal
            {
                internal OVERLAPPED.__Internal overlapped;
                internal ulong                 queued_bytes;

                [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-io>@<unnamed-type-u>@uv_getaddrinfo_s@@QEAA@AEBU012@@Z", CallingConvention = CallingConvention.Cdecl)]
                internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, Connect> NativeToManagedMap =
                new ConcurrentDictionary<IntPtr, Connect>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, Connect managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Connect managed)
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
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            public Connect(Connect __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
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

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

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
            __instance = *(__Internal*) native;
        }

        public U(U __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public Connect Io
        {
            get => Connect.__CreateInstance(__instance.io);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.io = *(Connect.__Internal*) value.__Instance;
            }
        }

        public Connect connect
        {
            get => Connect.__CreateInstance(__instance.connect);

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                __instance.connect = *(Connect.__Internal*) value.__Instance;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvGetaddrinfoS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvGetaddrinfoS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvGetaddrinfoS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvGetaddrinfoS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvGetaddrinfoS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvGetaddrinfoS(native.ToPointer(), skipVTables);
    }

    internal static UvGetaddrinfoS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvGetaddrinfoS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvGetaddrinfoS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvGetaddrinfoS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvGetaddrinfoS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvGetaddrinfoS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvGetaddrinfoS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvGetaddrinfoS(UvGetaddrinfoS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((__Internal*) __Instance) = *((__Internal*) _0.__Instance);
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

        set => ((__Internal*)__Instance)->data = value;
    }

    public UvReqType Type
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

    public U u
    {
        get => U.__CreateInstance(((__Internal*)__Instance)->u);

        set => ((__Internal*)__Instance)->u = value.__Instance;
    }

    public UvReqS NextReq
    {
        get
        {
            var __result0 = UvReqS.__GetOrCreateInstance(((__Internal*)__Instance)->next_req);
            return __result0;
        }

        set => ((__Internal*)__Instance)->next_req = value is null ? IntPtr.Zero : value.__Instance;
    }

    public UvLoopS Loop
    {
        get
        {
            var __result0 = UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public UvWork WorkReq
    {
        get => UvWork.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->work_req));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->work_req = *(UvWork.__Internal*) value.__Instance;
        }
    }

    public IntPtr Alloc
    {
        get => ((__Internal*)__Instance)->alloc;

        set => ((__Internal*)__Instance)->alloc = value;
    }

    public char* Node
    {
        get => (char*) ((__Internal*)__Instance)->node;

        set => ((__Internal*)__Instance)->node = (IntPtr) value;
    }

    public char* Service
    {
        get => (char*) ((__Internal*)__Instance)->service;

        set => ((__Internal*)__Instance)->service = (IntPtr) value;
    }

    public int Retcode
    {
        get => ((__Internal*)__Instance)->retcode;

        set => ((__Internal*)__Instance)->retcode = value;
    }
}