using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvStdioContainerS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal UvStdioFlags    flags;
        internal Data.__Internal data;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_stdio_container_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct Data
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal IntPtr stream;

            [FieldOffset(0)]
            internal int fd;

            [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-data>@uv_stdio_container_s@@QEAA@AEBT01@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

        internal static Data __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Data(native.ToPointer(), skipVTables);
        }

        internal static Data __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Data(native, skipVTables);
        }

        private Data(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Data(void* native, bool skipVTables = false) : this()
        {
            __instance = *(__Internal*) native;
        }

        public Data(Data __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public UvStreamS Stream
        {
            get
            {
                var __result0 = UvStreamS.__GetOrCreateInstance(__instance.stream);
                return __result0;
            }

            set => __instance.stream = value is null ? IntPtr.Zero : value.__Instance;
        }

        public int Fd
        {
            get => __instance.fd;

            set => __instance.fd = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvStdioContainerS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvStdioContainerS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvStdioContainerS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvStdioContainerS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvStdioContainerS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvStdioContainerS(native.ToPointer(), skipVTables);
    }

    internal static UvStdioContainerS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvStdioContainerS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvStdioContainerS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvStdioContainerS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvStdioContainerS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvStdioContainerS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvStdioContainerS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvStdioContainerS(UvStdioContainerS _0)
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

    public UvStdioFlags Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
    }

    public Data data
    {
        get => Data.__CreateInstance(((__Internal*)__Instance)->data);

        set => ((__Internal*)__Instance)->data = value.__Instance;
    }
}