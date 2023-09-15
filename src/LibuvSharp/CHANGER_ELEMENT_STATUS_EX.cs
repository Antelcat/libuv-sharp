using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_ELEMENT_STATUS_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 156)]
    public partial struct __Internal
    {
        internal       global::LibuvSharp.CHANGER_ELEMENT.__Internal Element;
        internal       global::LibuvSharp.CHANGER_ELEMENT.__Internal SrcElementAddress;
        internal       uint                                          Flags;
        internal       uint                                          ExceptionCode;
        internal       byte                                          TargetId;
        internal       byte                                          Lun;
        internal       ushort                                        Reserved;
        internal fixed byte                                          PrimaryVolumeID[36];
        internal fixed byte                                          AlternateVolumeID[36];
        internal fixed byte                                          VendorIdentification[8];
        internal fixed byte                                          ProductIdentification[16];
        internal fixed byte                                          SerialNumber[32];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_ELEMENT_STATUS_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_ELEMENT_STATUS_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CHANGER_ELEMENT_STATUS_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CHANGER_ELEMENT_STATUS_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_ELEMENT_STATUS_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_ELEMENT_STATUS_EX(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_ELEMENT_STATUS_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_ELEMENT_STATUS_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_ELEMENT_STATUS_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_ELEMENT_STATUS_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_ELEMENT_STATUS_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_ELEMENT_STATUS_EX(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.CHANGER_ELEMENT Element
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Element));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Element = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.CHANGER_ELEMENT SrcElementAddress
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->SrcElementAddress));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->SrcElementAddress = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public uint ExceptionCode
    {
        get => ((__Internal*)__Instance)->ExceptionCode;

        set => ((__Internal*)__Instance)->ExceptionCode = value;
    }

    public byte TargetId
    {
        get => ((__Internal*)__Instance)->TargetId;

        set => ((__Internal*)__Instance)->TargetId = value;
    }

    public byte Lun
    {
        get => ((__Internal*)__Instance)->Lun;

        set => ((__Internal*)__Instance)->Lun = value;
    }

    public ushort Reserved
    {
        get => ((__Internal*)__Instance)->Reserved;

        set => ((__Internal*)__Instance)->Reserved = value;
    }

    public byte[] PrimaryVolumeID
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->PrimaryVolumeID, 36);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 36; i++)
                    ((__Internal*)__Instance)->PrimaryVolumeID[i] = value[i];
            }
        }
    }

    public byte[] AlternateVolumeID
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->AlternateVolumeID, 36);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 36; i++)
                    ((__Internal*)__Instance)->AlternateVolumeID[i] = value[i];
            }
        }
    }

    public byte[] VendorIdentification
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->VendorIdentification, 8);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 8; i++)
                    ((__Internal*)__Instance)->VendorIdentification[i] = value[i];
            }
        }
    }

    public byte[] ProductIdentification
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->ProductIdentification, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->ProductIdentification[i] = value[i];
            }
        }
    }

    public byte[] SerialNumber
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->SerialNumber, 32);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 32; i++)
                    ((__Internal*)__Instance)->SerialNumber[i] = value[i];
            }
        }
    }
}