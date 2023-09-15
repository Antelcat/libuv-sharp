using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_GET_TRANSACTED_VERSION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal uint   ThisBaseVersion;
        internal uint   LatestVersion;
        internal ushort ThisMiniVersion;
        internal ushort FirstMiniVersion;
        internal ushort LatestMiniVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_GET_TRANSACTED_VERSION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_GET_TRANSACTED_VERSION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_GET_TRANSACTED_VERSION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_GET_TRANSACTED_VERSION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_GET_TRANSACTED_VERSION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_GET_TRANSACTED_VERSION(native.ToPointer(), skipVTables);
    }

    internal static TXFS_GET_TRANSACTED_VERSION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_GET_TRANSACTED_VERSION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_GET_TRANSACTED_VERSION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_GET_TRANSACTED_VERSION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_GET_TRANSACTED_VERSION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_GET_TRANSACTED_VERSION(void* native, bool skipVTables = false)
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

    public uint ThisBaseVersion
    {
        get => ((__Internal*)__Instance)->ThisBaseVersion;

        set => ((__Internal*)__Instance)->ThisBaseVersion = value;
    }

    public uint LatestVersion
    {
        get => ((__Internal*)__Instance)->LatestVersion;

        set => ((__Internal*)__Instance)->LatestVersion = value;
    }

    public ushort ThisMiniVersion
    {
        get => ((__Internal*)__Instance)->ThisMiniVersion;

        set => ((__Internal*)__Instance)->ThisMiniVersion = value;
    }

    public ushort FirstMiniVersion
    {
        get => ((__Internal*)__Instance)->FirstMiniVersion;

        set => ((__Internal*)__Instance)->FirstMiniVersion = value;
    }

    public ushort LatestMiniVersion
    {
        get => ((__Internal*)__Instance)->LatestMiniVersion;

        set => ((__Internal*)__Instance)->LatestMiniVersion = value;
    }
}