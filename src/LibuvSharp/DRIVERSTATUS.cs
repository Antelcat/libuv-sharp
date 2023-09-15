using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DRIVERSTATUS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 1)]
    public partial struct __Internal
    {
        internal       byte bDriverError;
        internal       byte bIDEError;
        internal fixed byte bReserved[2];
        internal fixed uint dwReserved[2];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVERSTATUS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DRIVERSTATUS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DRIVERSTATUS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DRIVERSTATUS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DRIVERSTATUS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DRIVERSTATUS(native.ToPointer(), skipVTables);
    }

    internal static DRIVERSTATUS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DRIVERSTATUS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DRIVERSTATUS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DRIVERSTATUS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DRIVERSTATUS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DRIVERSTATUS(void* native, bool skipVTables = false)
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

    public byte BDriverError
    {
        get => ((__Internal*)__Instance)->bDriverError;

        set => ((__Internal*)__Instance)->bDriverError = value;
    }

    public byte BIDEError
    {
        get => ((__Internal*)__Instance)->bIDEError;

        set => ((__Internal*)__Instance)->bIDEError = value;
    }

    public byte[] BReserved
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->bReserved, 2);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 2; i++)
                    ((__Internal*)__Instance)->bReserved[i] = value[i];
            }
        }
    }

    public uint[] DwReserved
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->dwReserved, 2);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 2; i++)
                    ((__Internal*)__Instance)->dwReserved[i] = value[i];
            }
        }
    }
}