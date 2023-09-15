using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class IDEREGS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 1)]
    public partial struct __Internal
    {
        internal byte bFeaturesReg;
        internal byte bSectorCountReg;
        internal byte bSectorNumberReg;
        internal byte bCylLowReg;
        internal byte bCylHighReg;
        internal byte bDriveHeadReg;
        internal byte bCommandReg;
        internal byte bReserved;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.IDEREGS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.IDEREGS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.IDEREGS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.IDEREGS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static IDEREGS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new IDEREGS(native.ToPointer(), skipVTables);
    }

    internal static IDEREGS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (IDEREGS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static IDEREGS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new IDEREGS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private IDEREGS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected IDEREGS(void* native, bool skipVTables = false)
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

    public byte BFeaturesReg
    {
        get => ((__Internal*)__Instance)->bFeaturesReg;

        set => ((__Internal*)__Instance)->bFeaturesReg = value;
    }

    public byte BSectorCountReg
    {
        get => ((__Internal*)__Instance)->bSectorCountReg;

        set => ((__Internal*)__Instance)->bSectorCountReg = value;
    }

    public byte BSectorNumberReg
    {
        get => ((__Internal*)__Instance)->bSectorNumberReg;

        set => ((__Internal*)__Instance)->bSectorNumberReg = value;
    }

    public byte BCylLowReg
    {
        get => ((__Internal*)__Instance)->bCylLowReg;

        set => ((__Internal*)__Instance)->bCylLowReg = value;
    }

    public byte BCylHighReg
    {
        get => ((__Internal*)__Instance)->bCylHighReg;

        set => ((__Internal*)__Instance)->bCylHighReg = value;
    }

    public byte BDriveHeadReg
    {
        get => ((__Internal*)__Instance)->bDriveHeadReg;

        set => ((__Internal*)__Instance)->bDriveHeadReg = value;
    }

    public byte BCommandReg
    {
        get => ((__Internal*)__Instance)->bCommandReg;

        set => ((__Internal*)__Instance)->bCommandReg = value;
    }

    public byte BReserved
    {
        get => ((__Internal*)__Instance)->bReserved;

        set => ((__Internal*)__Instance)->bReserved = value;
    }
}