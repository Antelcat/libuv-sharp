using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_RANGE_TRACK_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public partial struct __Internal
    {
        internal long Usn;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RANGE_TRACK_OUTPUT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RANGE_TRACK_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.USN_RANGE_TRACK_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.USN_RANGE_TRACK_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_RANGE_TRACK_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_RANGE_TRACK_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static USN_RANGE_TRACK_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_RANGE_TRACK_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_RANGE_TRACK_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RANGE_TRACK_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_RANGE_TRACK_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_RANGE_TRACK_OUTPUT(void* native, bool skipVTables = false)
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

    public long Usn
    {
        get => ((__Internal*)__Instance)->Usn;

        set => ((__Internal*)__Instance)->Usn = value;
    }
}