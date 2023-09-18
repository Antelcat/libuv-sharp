using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class CHANGER_PRODUCT_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 61)]
    public struct __Internal
    {
        internal fixed byte VendorId[8];
        internal fixed byte ProductId[16];
        internal fixed byte Revision[4];
        internal fixed byte SerialNumber[32];
        internal       byte DeviceType;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, CHANGER_PRODUCT_DATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, CHANGER_PRODUCT_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, CHANGER_PRODUCT_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out CHANGER_PRODUCT_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_PRODUCT_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_PRODUCT_DATA(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_PRODUCT_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_PRODUCT_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_PRODUCT_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_PRODUCT_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_PRODUCT_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_PRODUCT_DATA(void* native, bool skipVTables = false)
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

    public byte[] VendorId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->VendorId, 8);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 8; i++)
                    ((__Internal*)__Instance)->VendorId[i] = value[i];
            }
        }
    }

    public byte[] ProductId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->ProductId, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->ProductId[i] = value[i];
            }
        }
    }

    public byte[] Revision
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->Revision, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->Revision[i] = value[i];
            }
        }
    }

    public byte[] SerialNumber
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->SerialNumber, 32);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 32; i++)
                    ((__Internal*)__Instance)->SerialNumber[i] = value[i];
            }
        }
    }

    public byte DeviceType
    {
        get => ((__Internal*)__Instance)->DeviceType;

        set => ((__Internal*)__Instance)->DeviceType = value;
    }
}