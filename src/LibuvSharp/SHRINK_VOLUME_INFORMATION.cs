using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class SHRINK_VOLUME_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal global::LibuvSharp.SHRINK_VOLUME_REQUEST_TYPES ShrinkRequestType;
        internal ulong                                          Flags;
        internal long                                           NewNumberOfSectors;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.SHRINK_VOLUME_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.SHRINK_VOLUME_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.SHRINK_VOLUME_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.SHRINK_VOLUME_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SHRINK_VOLUME_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SHRINK_VOLUME_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static SHRINK_VOLUME_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SHRINK_VOLUME_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SHRINK_VOLUME_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SHRINK_VOLUME_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SHRINK_VOLUME_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SHRINK_VOLUME_INFORMATION(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.SHRINK_VOLUME_REQUEST_TYPES ShrinkRequestType
    {
        get => ((__Internal*)__Instance)->ShrinkRequestType;

        set => ((__Internal*)__Instance)->ShrinkRequestType = value;
    }

    public ulong Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public long NewNumberOfSectors
    {
        get => ((__Internal*)__Instance)->NewNumberOfSectors;

        set => ((__Internal*)__Instance)->NewNumberOfSectors = value;
    }
}