using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_CREATE_MINIVERSION_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct __Internal
    {
        internal ushort StructureVersion;
        internal ushort StructureLength;
        internal uint   BaseVersion;
        internal ushort MiniVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TXFS_CREATE_MINIVERSION_INFO> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TXFS_CREATE_MINIVERSION_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TXFS_CREATE_MINIVERSION_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TXFS_CREATE_MINIVERSION_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_CREATE_MINIVERSION_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_CREATE_MINIVERSION_INFO(native.ToPointer(), skipVTables);
    }

    internal static TXFS_CREATE_MINIVERSION_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_CREATE_MINIVERSION_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_CREATE_MINIVERSION_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_CREATE_MINIVERSION_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_CREATE_MINIVERSION_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_CREATE_MINIVERSION_INFO(void* native, bool skipVTables = false)
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

    public ushort StructureVersion
    {
        get => ((__Internal*)__Instance)->StructureVersion;

        set => ((__Internal*)__Instance)->StructureVersion = value;
    }

    public ushort StructureLength
    {
        get => ((__Internal*)__Instance)->StructureLength;

        set => ((__Internal*)__Instance)->StructureLength = value;
    }

    public uint BaseVersion
    {
        get => ((__Internal*)__Instance)->BaseVersion;

        set => ((__Internal*)__Instance)->BaseVersion = value;
    }

    public ushort MiniVersion
    {
        get => ((__Internal*)__Instance)->MiniVersion;

        set => ((__Internal*)__Instance)->MiniVersion = value;
    }
}