using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class GETVERSIONINPARAMS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24, Pack = 1)]
    public struct __Internal
    {
        internal       byte bVersion;
        internal       byte bRevision;
        internal       byte bReserved;
        internal       byte bIDEDeviceMap;
        internal       uint fCapabilities;
        internal fixed uint dwReserved[4];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, GETVERSIONINPARAMS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, GETVERSIONINPARAMS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, GETVERSIONINPARAMS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out GETVERSIONINPARAMS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static GETVERSIONINPARAMS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new GETVERSIONINPARAMS(native.ToPointer(), skipVTables);
    }

    internal static GETVERSIONINPARAMS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (GETVERSIONINPARAMS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static GETVERSIONINPARAMS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new GETVERSIONINPARAMS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private GETVERSIONINPARAMS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected GETVERSIONINPARAMS(void* native, bool skipVTables = false)
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

    public byte BVersion
    {
        get => ((__Internal*)__Instance)->bVersion;

        set => ((__Internal*)__Instance)->bVersion = value;
    }

    public byte BRevision
    {
        get => ((__Internal*)__Instance)->bRevision;

        set => ((__Internal*)__Instance)->bRevision = value;
    }

    public byte BReserved
    {
        get => ((__Internal*)__Instance)->bReserved;

        set => ((__Internal*)__Instance)->bReserved = value;
    }

    public byte BIDEDeviceMap
    {
        get => ((__Internal*)__Instance)->bIDEDeviceMap;

        set => ((__Internal*)__Instance)->bIDEDeviceMap = value;
    }

    public uint FCapabilities
    {
        get => ((__Internal*)__Instance)->fCapabilities;

        set => ((__Internal*)__Instance)->fCapabilities = value;
    }

    public uint[] DwReserved
    {
        get => MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->dwReserved, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->dwReserved[i] = value[i];
            }
        }
    }
}