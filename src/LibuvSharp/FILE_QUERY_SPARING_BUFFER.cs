using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILE_QUERY_SPARING_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal uint SparingUnitBytes;
        internal byte SoftwareSparing;
        internal uint TotalSpareBlocks;
        internal uint FreeSpareBlocks;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_QUERY_SPARING_BUFFER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_QUERY_SPARING_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FILE_QUERY_SPARING_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FILE_QUERY_SPARING_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILE_QUERY_SPARING_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILE_QUERY_SPARING_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static FILE_QUERY_SPARING_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILE_QUERY_SPARING_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILE_QUERY_SPARING_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILE_QUERY_SPARING_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILE_QUERY_SPARING_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILE_QUERY_SPARING_BUFFER(void* native, bool skipVTables = false)
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

    public uint SparingUnitBytes
    {
        get => ((__Internal*)__Instance)->SparingUnitBytes;

        set => ((__Internal*)__Instance)->SparingUnitBytes = value;
    }

    public byte SoftwareSparing
    {
        get => ((__Internal*)__Instance)->SoftwareSparing;

        set => ((__Internal*)__Instance)->SoftwareSparing = value;
    }

    public uint TotalSpareBlocks
    {
        get => ((__Internal*)__Instance)->TotalSpareBlocks;

        set => ((__Internal*)__Instance)->TotalSpareBlocks = value;
    }

    public uint FreeSpareBlocks
    {
        get => ((__Internal*)__Instance)->FreeSpareBlocks;

        set => ((__Internal*)__Instance)->FreeSpareBlocks = value;
    }
}