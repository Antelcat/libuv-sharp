using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_ROLLFORWARD_REDO_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal LARGE_INTEGER.__Internal LastVirtualClock;
        internal ulong                    LastRedoLsn;
        internal ulong                    HighestRecoveryLsn;
        internal uint                     Flags;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TXFS_ROLLFORWARD_REDO_INFORMATION> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TXFS_ROLLFORWARD_REDO_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TXFS_ROLLFORWARD_REDO_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TXFS_ROLLFORWARD_REDO_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_ROLLFORWARD_REDO_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_ROLLFORWARD_REDO_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static TXFS_ROLLFORWARD_REDO_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_ROLLFORWARD_REDO_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_ROLLFORWARD_REDO_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_ROLLFORWARD_REDO_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_ROLLFORWARD_REDO_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_ROLLFORWARD_REDO_INFORMATION(void* native, bool skipVTables = false)
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

    public ulong LastRedoLsn
    {
        get => ((__Internal*)__Instance)->LastRedoLsn;

        set => ((__Internal*)__Instance)->LastRedoLsn = value;
    }

    public ulong HighestRecoveryLsn
    {
        get => ((__Internal*)__Instance)->HighestRecoveryLsn;

        set => ((__Internal*)__Instance)->HighestRecoveryLsn = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }
}