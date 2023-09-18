using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_CACHE_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal byte ParametersSavable;

        [FieldOffset(1)]
        internal byte ReadCacheEnabled;

        [FieldOffset(2)]
        internal byte WriteCacheEnabled;

        [FieldOffset(4)]
        internal DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;

        [FieldOffset(8)]
        internal DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;

        [FieldOffset(12)]
        internal ushort DisablePrefetchTransferLength;

        [FieldOffset(14)]
        internal byte PrefetchScalar;

        [FieldOffset(16)]
        internal _0.ScalarPrefetch.__Internal ScalarPrefetch;

        [FieldOffset(16)]
        internal _0.BlockPrefetch.__Internal BlockPrefetch;
    }

    public partial struct _0
    {
        [StructLayout(LayoutKind.Explicit, Size = 6)]
        public struct __Internal
        {
            [FieldOffset(0)]
            internal ScalarPrefetch.__Internal ScalarPrefetch;

            [FieldOffset(0)]
            internal BlockPrefetch.__Internal BlockPrefetch;
        }

        public partial class ScalarPrefetch
        {
            [StructLayout(LayoutKind.Sequential, Size = 6)]
            public struct __Internal
            {
                internal ushort Minimum;
                internal ushort Maximum;
                internal ushort MaximumBlocks;
            }
        }

        public partial class BlockPrefetch
        {
            [StructLayout(LayoutKind.Sequential, Size = 4)]
            public struct __Internal
            {
                internal ushort Minimum;
                internal ushort Maximum;
            }
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DISK_CACHE_INFORMATION> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DISK_CACHE_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DISK_CACHE_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DISK_CACHE_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_CACHE_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_CACHE_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static DISK_CACHE_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_CACHE_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_CACHE_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_CACHE_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_CACHE_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_CACHE_INFORMATION(void* native, bool skipVTables = false)
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

    public byte ParametersSavable
    {
        get => ((__Internal*)__Instance)->ParametersSavable;

        set => ((__Internal*)__Instance)->ParametersSavable = value;
    }

    public byte ReadCacheEnabled
    {
        get => ((__Internal*)__Instance)->ReadCacheEnabled;

        set => ((__Internal*)__Instance)->ReadCacheEnabled = value;
    }

    public byte WriteCacheEnabled
    {
        get => ((__Internal*)__Instance)->WriteCacheEnabled;

        set => ((__Internal*)__Instance)->WriteCacheEnabled = value;
    }

    public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority
    {
        get => ((__Internal*)__Instance)->ReadRetentionPriority;

        set => ((__Internal*)__Instance)->ReadRetentionPriority = value;
    }

    public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority
    {
        get => ((__Internal*)__Instance)->WriteRetentionPriority;

        set => ((__Internal*)__Instance)->WriteRetentionPriority = value;
    }

    public ushort DisablePrefetchTransferLength
    {
        get => ((__Internal*)__Instance)->DisablePrefetchTransferLength;

        set => ((__Internal*)__Instance)->DisablePrefetchTransferLength = value;
    }

    public byte PrefetchScalar
    {
        get => ((__Internal*)__Instance)->PrefetchScalar;

        set => ((__Internal*)__Instance)->PrefetchScalar = value;
    }
}