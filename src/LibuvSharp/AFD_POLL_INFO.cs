using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class AFD_POLL_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal       global::LARGE_INTEGER.__Internal Timeout;
        internal       uint                             NumberOfHandles;
        internal       uint                             Exclusive;
        internal fixed byte                             Handles[16];

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0_AFD_POLL_INFO@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.AFD_POLL_INFO> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.AFD_POLL_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.AFD_POLL_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.AFD_POLL_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static AFD_POLL_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new AFD_POLL_INFO(native.ToPointer(), skipVTables);
    }

    internal static AFD_POLL_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (AFD_POLL_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static AFD_POLL_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new AFD_POLL_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private AFD_POLL_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected AFD_POLL_INFO(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public AFD_POLL_INFO()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.AFD_POLL_INFO.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public AFD_POLL_INFO(global::LibuvSharp.AFD_POLL_INFO _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.AFD_POLL_INFO.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.AFD_POLL_INFO.__Internal*) __Instance) = *((global::LibuvSharp.AFD_POLL_INFO.__Internal*) _0.__Instance);
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

    public uint NumberOfHandles
    {
        get => ((__Internal*)__Instance)->NumberOfHandles;

        set => ((__Internal*)__Instance)->NumberOfHandles = value;
    }

    public uint Exclusive
    {
        get => ((__Internal*)__Instance)->Exclusive;

        set => ((__Internal*)__Instance)->Exclusive = value;
    }

    public global::LibuvSharp.AFD_POLL_HANDLE_INFO[] Handles
    {
        get
        {
            global::LibuvSharp.AFD_POLL_HANDLE_INFO[] __value = null;
            if (((__Internal*)__Instance)->Handles != null)
            {
                __value = new global::LibuvSharp.AFD_POLL_HANDLE_INFO[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = global::LibuvSharp.AFD_POLL_HANDLE_INFO.__GetOrCreateInstance((IntPtr)((global::LibuvSharp.AFD_POLL_HANDLE_INFO.__Internal*)&(((__Internal*)__Instance)->Handles[i * sizeof(global::LibuvSharp.AFD_POLL_HANDLE_INFO.__Internal)])), true, true);
            }
            return __value;
        }

        set
        {
            if (value != null)
            {
                if (value.Length != 1)
                    throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                for (var i = 0; i < 1; i++)
                    *(global::LibuvSharp.AFD_POLL_HANDLE_INFO.__Internal*) &((__Internal*)__Instance)->Handles[i * sizeof(global::LibuvSharp.AFD_POLL_HANDLE_INFO.__Internal)] = *(global::LibuvSharp.AFD_POLL_HANDLE_INFO.__Internal*)value[i].__Instance;
            }
        }
    }
}