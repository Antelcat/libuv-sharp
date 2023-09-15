using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class REQUEST_RAW_ENCRYPTED_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal long FileOffset;
        internal uint Length;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REQUEST_RAW_ENCRYPTED_DATA> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REQUEST_RAW_ENCRYPTED_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.REQUEST_RAW_ENCRYPTED_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.REQUEST_RAW_ENCRYPTED_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static REQUEST_RAW_ENCRYPTED_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new REQUEST_RAW_ENCRYPTED_DATA(native.ToPointer(), skipVTables);
    }

    internal static REQUEST_RAW_ENCRYPTED_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (REQUEST_RAW_ENCRYPTED_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static REQUEST_RAW_ENCRYPTED_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new REQUEST_RAW_ENCRYPTED_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private REQUEST_RAW_ENCRYPTED_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected REQUEST_RAW_ENCRYPTED_DATA(void* native, bool skipVTables = false)
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

    public long FileOffset
    {
        get => ((__Internal*)__Instance)->FileOffset;

        set => ((__Internal*)__Instance)->FileOffset = value;
    }

    public uint Length
    {
        get => ((__Internal*)__Instance)->Length;

        set => ((__Internal*)__Instance)->Length = value;
    }
}