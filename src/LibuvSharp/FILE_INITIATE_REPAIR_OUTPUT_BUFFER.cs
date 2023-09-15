using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILE_INITIATE_REPAIR_OUTPUT_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal ulong Hint1;
        internal ulong Hint2;
        internal ulong Clsn;
        internal uint  Status;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_INITIATE_REPAIR_OUTPUT_BUFFER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_INITIATE_REPAIR_OUTPUT_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FILE_INITIATE_REPAIR_OUTPUT_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FILE_INITIATE_REPAIR_OUTPUT_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILE_INITIATE_REPAIR_OUTPUT_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILE_INITIATE_REPAIR_OUTPUT_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static FILE_INITIATE_REPAIR_OUTPUT_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILE_INITIATE_REPAIR_OUTPUT_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILE_INITIATE_REPAIR_OUTPUT_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILE_INITIATE_REPAIR_OUTPUT_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILE_INITIATE_REPAIR_OUTPUT_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILE_INITIATE_REPAIR_OUTPUT_BUFFER(void* native, bool skipVTables = false)
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

    public ulong Hint1
    {
        get => ((__Internal*)__Instance)->Hint1;

        set => ((__Internal*)__Instance)->Hint1 = value;
    }

    public ulong Hint2
    {
        get => ((__Internal*)__Instance)->Hint2;

        set => ((__Internal*)__Instance)->Hint2 = value;
    }

    public ulong Clsn
    {
        get => ((__Internal*)__Instance)->Clsn;

        set => ((__Internal*)__Instance)->Clsn = value;
    }

    public uint Status
    {
        get => ((__Internal*)__Instance)->Status;

        set => ((__Internal*)__Instance)->Status = value;
    }
}