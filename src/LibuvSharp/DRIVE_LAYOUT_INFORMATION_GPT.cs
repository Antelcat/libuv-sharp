using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DRIVE_LAYOUT_INFORMATION_GPT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public partial struct __Internal
    {
        internal global::GUID.__Internal          DiskId;
        internal global::LARGE_INTEGER.__Internal StartingUsableOffset;
        internal global::LARGE_INTEGER.__Internal UsableLength;
        internal uint                             MaxPartitionCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DRIVE_LAYOUT_INFORMATION_GPT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DRIVE_LAYOUT_INFORMATION_GPT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DRIVE_LAYOUT_INFORMATION_GPT(native.ToPointer(), skipVTables);
    }

    internal static DRIVE_LAYOUT_INFORMATION_GPT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DRIVE_LAYOUT_INFORMATION_GPT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DRIVE_LAYOUT_INFORMATION_GPT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DRIVE_LAYOUT_INFORMATION_GPT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DRIVE_LAYOUT_INFORMATION_GPT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DRIVE_LAYOUT_INFORMATION_GPT(void* native, bool skipVTables = false)
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

    public uint MaxPartitionCount
    {
        get => ((__Internal*)__Instance)->MaxPartitionCount;

        set => ((__Internal*)__Instance)->MaxPartitionCount = value;
    }
}