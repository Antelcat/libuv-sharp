using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class AFD_POLL_HANDLE_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal IntPtr Handle;
        internal uint     Events;
        internal int      Status;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0_AFD_POLL_HANDLE_INFO@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, AFD_POLL_HANDLE_INFO> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, AFD_POLL_HANDLE_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, AFD_POLL_HANDLE_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out AFD_POLL_HANDLE_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static AFD_POLL_HANDLE_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new AFD_POLL_HANDLE_INFO(native.ToPointer(), skipVTables);
    }

    internal static AFD_POLL_HANDLE_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (AFD_POLL_HANDLE_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static AFD_POLL_HANDLE_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new AFD_POLL_HANDLE_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private AFD_POLL_HANDLE_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected AFD_POLL_HANDLE_INFO(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public AFD_POLL_HANDLE_INFO()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public AFD_POLL_HANDLE_INFO(AFD_POLL_HANDLE_INFO _0)
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

    public IntPtr Handle
    {
        get => ((__Internal*)__Instance)->Handle;

        set => ((__Internal*)__Instance)->Handle = value;
    }

    public uint Events
    {
        get => ((__Internal*)__Instance)->Events;

        set => ((__Internal*)__Instance)->Events = value;
    }

    public int Status
    {
        get => ((__Internal*)__Instance)->Status;

        set => ((__Internal*)__Instance)->Status = value;
    }
}