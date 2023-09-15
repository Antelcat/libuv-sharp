using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_LIST_TRANSACTION_LOCKED_FILES : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public partial struct __Internal
    {
        internal global::GUID.__Internal KtmTransaction;
        internal ulong                   NumberOfFiles;
        internal ulong                   BufferSizeRequired;
        internal ulong                   Offset;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTION_LOCKED_FILES> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTION_LOCKED_FILES>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_LIST_TRANSACTION_LOCKED_FILES managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_LIST_TRANSACTION_LOCKED_FILES managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_LIST_TRANSACTION_LOCKED_FILES __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_LIST_TRANSACTION_LOCKED_FILES(native.ToPointer(), skipVTables);
    }

    internal static TXFS_LIST_TRANSACTION_LOCKED_FILES __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_LIST_TRANSACTION_LOCKED_FILES)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_LIST_TRANSACTION_LOCKED_FILES __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_LIST_TRANSACTION_LOCKED_FILES(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_LIST_TRANSACTION_LOCKED_FILES(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_LIST_TRANSACTION_LOCKED_FILES(void* native, bool skipVTables = false)
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

    public ulong NumberOfFiles
    {
        get => ((__Internal*)__Instance)->NumberOfFiles;

        set => ((__Internal*)__Instance)->NumberOfFiles = value;
    }

    public ulong BufferSizeRequired
    {
        get => ((__Internal*)__Instance)->BufferSizeRequired;

        set => ((__Internal*)__Instance)->BufferSizeRequired = value;
    }

    public ulong Offset
    {
        get => ((__Internal*)__Instance)->Offset;

        set => ((__Internal*)__Instance)->Offset = value;
    }
}