using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class NUMPARSE : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 8)]
    public partial struct __Internal
    {
        internal int  cDig;
        internal uint dwInFlags;
        internal uint dwOutFlags;
        internal int  cchUsed;
        internal int  nBaseShift;
        internal int  nPwr10;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.NUMPARSE> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.NUMPARSE>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.NUMPARSE managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.NUMPARSE managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static NUMPARSE __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new NUMPARSE(native.ToPointer(), skipVTables);
    }

    internal static NUMPARSE __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (NUMPARSE)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static NUMPARSE __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new NUMPARSE(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private NUMPARSE(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected NUMPARSE(void* native, bool skipVTables = false)
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

    public int CDig
    {
        get => ((__Internal*)__Instance)->cDig;

        set => ((__Internal*)__Instance)->cDig = value;
    }

    public uint DwInFlags
    {
        get => ((__Internal*)__Instance)->dwInFlags;

        set => ((__Internal*)__Instance)->dwInFlags = value;
    }

    public uint DwOutFlags
    {
        get => ((__Internal*)__Instance)->dwOutFlags;

        set => ((__Internal*)__Instance)->dwOutFlags = value;
    }

    public int CchUsed
    {
        get => ((__Internal*)__Instance)->cchUsed;

        set => ((__Internal*)__Instance)->cchUsed = value;
    }

    public int NBaseShift
    {
        get => ((__Internal*)__Instance)->nBaseShift;

        set => ((__Internal*)__Instance)->nBaseShift = value;
    }

    public int NPwr10
    {
        get => ((__Internal*)__Instance)->nPwr10;

        set => ((__Internal*)__Instance)->nPwr10 = value;
    }
}