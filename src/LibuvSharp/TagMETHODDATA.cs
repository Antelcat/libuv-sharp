using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagMETHODDATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40, Pack = 8)]
    public struct __Internal
    {
        internal IntPtr            szName;
        internal IntPtr            ppdata;
        internal int                 dispid;
        internal uint                iMeth;
        internal TagCALLCONV cc;
        internal uint                cArgs;
        internal ushort              wFlags;
        internal ushort              vtReturn;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TagMETHODDATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TagMETHODDATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TagMETHODDATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TagMETHODDATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TagMETHODDATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagMETHODDATA(native.ToPointer(), skipVTables);
    }

    internal static TagMETHODDATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagMETHODDATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagMETHODDATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagMETHODDATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagMETHODDATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagMETHODDATA(void* native, bool skipVTables = false)
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

    public TagPARAMDATA Ppdata
    {
        get
        {
            var __result0 = TagPARAMDATA.__GetOrCreateInstance(((__Internal*)__Instance)->ppdata);
            return __result0;
        }

        set => ((__Internal*)__Instance)->ppdata = value is null ? IntPtr.Zero : value.__Instance;
    }

    public int Dispid
    {
        get => ((__Internal*)__Instance)->dispid;

        set => ((__Internal*)__Instance)->dispid = value;
    }

    public uint IMeth
    {
        get => ((__Internal*)__Instance)->iMeth;

        set => ((__Internal*)__Instance)->iMeth = value;
    }

    public uint CArgs
    {
        get => ((__Internal*)__Instance)->cArgs;

        set => ((__Internal*)__Instance)->cArgs = value;
    }

    public ushort WFlags
    {
        get => ((__Internal*)__Instance)->wFlags;

        set => ((__Internal*)__Instance)->wFlags = value;
    }

    public ushort VtReturn
    {
        get => ((__Internal*)__Instance)->vtReturn;

        set => ((__Internal*)__Instance)->vtReturn = value;
    }
}