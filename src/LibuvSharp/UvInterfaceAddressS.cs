using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvInterfaceAddressS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 80)]
    public partial struct __Internal
    {
        internal       IntPtr                                                  name;
        internal fixed sbyte                                                     phys_addr[6];
        internal       int                                                       is_internal;
        internal       global::LibuvSharp.UvInterfaceAddressS.Address.__Internal address;
        internal       global::LibuvSharp.UvInterfaceAddressS.Netmask.__Internal netmask;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_interface_address_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public unsafe partial struct Address
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::SockaddrIn.__Internal address4;

            [FieldOffset(0)]
            internal global::SockaddrIn6.__Internal address6;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-address>@uv_interface_address_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  Address.__Internal __instance;
        internal Address.__Internal __Instance => __instance;

        internal static Address __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Address(native.ToPointer(), skipVTables);
        }

        internal static Address __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Address(native, skipVTables);
        }

        private Address(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Address(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvInterfaceAddressS.Address.__Internal*) native;
        }

        public Address(global::LibuvSharp.UvInterfaceAddressS.Address __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }
    }

    public unsafe partial struct Netmask
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::SockaddrIn.__Internal netmask4;

            [FieldOffset(0)]
            internal global::SockaddrIn6.__Internal netmask6;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-netmask>@uv_interface_address_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  Netmask.__Internal __instance;
        internal Netmask.__Internal __Instance => __instance;

        internal static Netmask __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Netmask(native.ToPointer(), skipVTables);
        }

        internal static Netmask __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Netmask(native, skipVTables);
        }

        private Netmask(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Netmask(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::LibuvSharp.UvInterfaceAddressS.Netmask.__Internal*) native;
        }

        public Netmask(global::LibuvSharp.UvInterfaceAddressS.Netmask __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvInterfaceAddressS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvInterfaceAddressS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvInterfaceAddressS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvInterfaceAddressS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvInterfaceAddressS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvInterfaceAddressS(native.ToPointer(), skipVTables);
    }

    internal static UvInterfaceAddressS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvInterfaceAddressS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvInterfaceAddressS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvInterfaceAddressS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvInterfaceAddressS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvInterfaceAddressS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvInterfaceAddressS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvInterfaceAddressS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvInterfaceAddressS(global::LibuvSharp.UvInterfaceAddressS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvInterfaceAddressS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvInterfaceAddressS.__Internal*) __Instance) = *((global::LibuvSharp.UvInterfaceAddressS.__Internal*) _0.__Instance);
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

    public sbyte* Name
    {
        get => (sbyte*) ((__Internal*)__Instance)->name;

        set => ((__Internal*)__Instance)->name = (IntPtr) value;
    }

    public sbyte[] PhysAddr
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->phys_addr, 6);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 6; i++)
                    ((__Internal*)__Instance)->phys_addr[i] = value[i];
            }
        }
    }

    public int IsInternal
    {
        get => ((__Internal*)__Instance)->is_internal;

        set => ((__Internal*)__Instance)->is_internal = value;
    }

    public global::LibuvSharp.UvInterfaceAddressS.Address address
    {
        get => global::LibuvSharp.UvInterfaceAddressS.Address.__CreateInstance(((__Internal*)__Instance)->address);

        set => ((__Internal*)__Instance)->address = value.__Instance;
    }

    public global::LibuvSharp.UvInterfaceAddressS.Netmask netmask
    {
        get => global::LibuvSharp.UvInterfaceAddressS.Netmask.__CreateInstance(((__Internal*)__Instance)->netmask);

        set => ((__Internal*)__Instance)->netmask = value.__Instance;
    }
}