using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagNC_ADDRESS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal IntPtr pAddrInfo;
        internal ushort   PortNumber;
        internal byte     PrefixLength;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TagNC_ADDRESS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TagNC_ADDRESS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TagNC_ADDRESS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TagNC_ADDRESS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TagNC_ADDRESS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagNC_ADDRESS(native.ToPointer(), skipVTables);
    }

    internal static TagNC_ADDRESS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagNC_ADDRESS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagNC_ADDRESS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagNC_ADDRESS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagNC_ADDRESS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagNC_ADDRESS(void* native, bool skipVTables = false)
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

    public ushort PortNumber
    {
        get => ((__Internal*)__Instance)->PortNumber;

        set => ((__Internal*)__Instance)->PortNumber = value;
    }

    public byte PrefixLength
    {
        get => ((__Internal*)__Instance)->PrefixLength;

        set => ((__Internal*)__Instance)->PrefixLength = value;
    }
}