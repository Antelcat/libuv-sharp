using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PERF_INSTANCE_DEFINITION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 8)]
    public partial struct __Internal
    {
        internal uint ByteLength;
        internal uint ParentObjectTitleIndex;
        internal uint ParentObjectInstance;
        internal int  UniqueID;
        internal uint NameOffset;
        internal uint NameLength;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_INSTANCE_DEFINITION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PERF_INSTANCE_DEFINITION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PERF_INSTANCE_DEFINITION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PERF_INSTANCE_DEFINITION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_INSTANCE_DEFINITION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_INSTANCE_DEFINITION(native.ToPointer(), skipVTables);
    }

    internal static PERF_INSTANCE_DEFINITION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_INSTANCE_DEFINITION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_INSTANCE_DEFINITION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_INSTANCE_DEFINITION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_INSTANCE_DEFINITION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_INSTANCE_DEFINITION(void* native, bool skipVTables = false)
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

    public uint ByteLength
    {
        get => ((__Internal*)__Instance)->ByteLength;

        set => ((__Internal*)__Instance)->ByteLength = value;
    }

    public uint ParentObjectTitleIndex
    {
        get => ((__Internal*)__Instance)->ParentObjectTitleIndex;

        set => ((__Internal*)__Instance)->ParentObjectTitleIndex = value;
    }

    public uint ParentObjectInstance
    {
        get => ((__Internal*)__Instance)->ParentObjectInstance;

        set => ((__Internal*)__Instance)->ParentObjectInstance = value;
    }

    public int UniqueID
    {
        get => ((__Internal*)__Instance)->UniqueID;

        set => ((__Internal*)__Instance)->UniqueID = value;
    }

    public uint NameOffset
    {
        get => ((__Internal*)__Instance)->NameOffset;

        set => ((__Internal*)__Instance)->NameOffset = value;
    }

    public uint NameLength
    {
        get => ((__Internal*)__Instance)->NameLength;

        set => ((__Internal*)__Instance)->NameLength = value;
    }
}