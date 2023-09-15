using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_LIST_TRANSACTIONS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal ulong NumberOfTransactions;
        internal ulong BufferSizeRequired;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTIONS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTIONS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_LIST_TRANSACTIONS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_LIST_TRANSACTIONS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_LIST_TRANSACTIONS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_LIST_TRANSACTIONS(native.ToPointer(), skipVTables);
    }

    internal static TXFS_LIST_TRANSACTIONS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_LIST_TRANSACTIONS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_LIST_TRANSACTIONS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_LIST_TRANSACTIONS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_LIST_TRANSACTIONS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_LIST_TRANSACTIONS(void* native, bool skipVTables = false)
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

    public ulong NumberOfTransactions
    {
        get => ((__Internal*)__Instance)->NumberOfTransactions;

        set => ((__Internal*)__Instance)->NumberOfTransactions = value;
    }

    public ulong BufferSizeRequired
    {
        get => ((__Internal*)__Instance)->BufferSizeRequired;

        set => ((__Internal*)__Instance)->BufferSizeRequired = value;
    }
}