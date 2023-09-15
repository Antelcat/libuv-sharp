using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class GET_DISK_ATTRIBUTES : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal uint  Version;
        internal uint  Reserved1;
        internal ulong Attributes;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_DISK_ATTRIBUTES> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_DISK_ATTRIBUTES>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.GET_DISK_ATTRIBUTES managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.GET_DISK_ATTRIBUTES managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static GET_DISK_ATTRIBUTES __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new GET_DISK_ATTRIBUTES(native.ToPointer(), skipVTables);
    }

    internal static GET_DISK_ATTRIBUTES __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (GET_DISK_ATTRIBUTES)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static GET_DISK_ATTRIBUTES __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new GET_DISK_ATTRIBUTES(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private GET_DISK_ATTRIBUTES(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected GET_DISK_ATTRIBUTES(void* native, bool skipVTables = false)
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

    public uint Version
    {
        get => ((__Internal*)__Instance)->Version;

        set => ((__Internal*)__Instance)->Version = value;
    }

    public uint Reserved1
    {
        get => ((__Internal*)__Instance)->Reserved1;

        set => ((__Internal*)__Instance)->Reserved1 = value;
    }

    public ulong Attributes
    {
        get => ((__Internal*)__Instance)->Attributes;

        set => ((__Internal*)__Instance)->Attributes = value;
    }
}