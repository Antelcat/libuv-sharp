using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagPARAMDATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16, Pack = 8)]
    public struct __Internal
    {
        internal IntPtr szName;
        internal ushort   vt;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TagPARAMDATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TagPARAMDATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TagPARAMDATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TagPARAMDATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TagPARAMDATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagPARAMDATA(native.ToPointer(), skipVTables);
    }

    internal static TagPARAMDATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagPARAMDATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagPARAMDATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagPARAMDATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagPARAMDATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagPARAMDATA(void* native, bool skipVTables = false)
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

    public char* SzName
    {
        get => (char*) ((__Internal*)__Instance)->szName;

        set => ((__Internal*)__Instance)->szName = (IntPtr) value;
    }

    public ushort Vt
    {
        get => ((__Internal*)__Instance)->vt;

        set => ((__Internal*)__Instance)->vt = value;
    }
}