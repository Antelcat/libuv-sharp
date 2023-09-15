using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagCRGB : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal byte bRed;
        internal byte bGreen;
        internal byte bBlue;
        internal byte bExtra;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagCRGB> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagCRGB>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TagCRGB managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TagCRGB managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TagCRGB __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagCRGB(native.ToPointer(), skipVTables);
    }

    internal static TagCRGB __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagCRGB)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagCRGB __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagCRGB(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagCRGB(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagCRGB(void* native, bool skipVTables = false)
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

    public byte BRed
    {
        get => ((__Internal*)__Instance)->bRed;

        set => ((__Internal*)__Instance)->bRed = value;
    }

    public byte BGreen
    {
        get => ((__Internal*)__Instance)->bGreen;

        set => ((__Internal*)__Instance)->bGreen = value;
    }

    public byte BBlue
    {
        get => ((__Internal*)__Instance)->bBlue;

        set => ((__Internal*)__Instance)->bBlue = value;
    }

    public byte BExtra
    {
        get => ((__Internal*)__Instance)->bExtra;

        set => ((__Internal*)__Instance)->bExtra = value;
    }
}