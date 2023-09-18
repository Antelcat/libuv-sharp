using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DECRYPTION_STATUS_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct __Internal
    {
        internal byte NoEncryptedStreams;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DECRYPTION_STATUS_BUFFER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DECRYPTION_STATUS_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DECRYPTION_STATUS_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DECRYPTION_STATUS_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DECRYPTION_STATUS_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DECRYPTION_STATUS_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static DECRYPTION_STATUS_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DECRYPTION_STATUS_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DECRYPTION_STATUS_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DECRYPTION_STATUS_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DECRYPTION_STATUS_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DECRYPTION_STATUS_BUFFER(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
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

    public byte NoEncryptedStreams
    {
        get => ((__Internal*)__Instance)->NoEncryptedStreams;

        set => ((__Internal*)__Instance)->NoEncryptedStreams = value;
    }
}