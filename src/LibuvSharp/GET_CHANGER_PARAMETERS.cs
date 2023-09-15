using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class GET_CHANGER_PARAMETERS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 60)]
    public partial struct __Internal
    {
        internal       uint   Size;
        internal       ushort NumberTransportElements;
        internal       ushort NumberStorageElements;
        internal       ushort NumberCleanerSlots;
        internal       ushort NumberIEElements;
        internal       ushort NumberDataTransferElements;
        internal       ushort NumberOfDoors;
        internal       ushort FirstSlotNumber;
        internal       ushort FirstDriveNumber;
        internal       ushort FirstTransportNumber;
        internal       ushort FirstIEPortNumber;
        internal       ushort FirstCleanerSlotAddress;
        internal       ushort MagazineSize;
        internal       uint   DriveCleanTimeout;
        internal       uint   Features0;
        internal       uint   Features1;
        internal       byte   MoveFromTransport;
        internal       byte   MoveFromSlot;
        internal       byte   MoveFromIePort;
        internal       byte   MoveFromDrive;
        internal       byte   ExchangeFromTransport;
        internal       byte   ExchangeFromSlot;
        internal       byte   ExchangeFromIePort;
        internal       byte   ExchangeFromDrive;
        internal       byte   LockUnlockCapabilities;
        internal       byte   PositionCapabilities;
        internal fixed byte   Reserved1[2];
        internal fixed uint   Reserved2[2];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_CHANGER_PARAMETERS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_CHANGER_PARAMETERS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.GET_CHANGER_PARAMETERS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.GET_CHANGER_PARAMETERS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static GET_CHANGER_PARAMETERS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new GET_CHANGER_PARAMETERS(native.ToPointer(), skipVTables);
    }

    internal static GET_CHANGER_PARAMETERS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (GET_CHANGER_PARAMETERS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static GET_CHANGER_PARAMETERS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new GET_CHANGER_PARAMETERS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private GET_CHANGER_PARAMETERS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected GET_CHANGER_PARAMETERS(void* native, bool skipVTables = false)
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

    public uint Size
    {
        get => ((__Internal*)__Instance)->Size;

        set => ((__Internal*)__Instance)->Size = value;
    }

    public ushort NumberTransportElements
    {
        get => ((__Internal*)__Instance)->NumberTransportElements;

        set => ((__Internal*)__Instance)->NumberTransportElements = value;
    }

    public ushort NumberStorageElements
    {
        get => ((__Internal*)__Instance)->NumberStorageElements;

        set => ((__Internal*)__Instance)->NumberStorageElements = value;
    }

    public ushort NumberCleanerSlots
    {
        get => ((__Internal*)__Instance)->NumberCleanerSlots;

        set => ((__Internal*)__Instance)->NumberCleanerSlots = value;
    }

    public ushort NumberIEElements
    {
        get => ((__Internal*)__Instance)->NumberIEElements;

        set => ((__Internal*)__Instance)->NumberIEElements = value;
    }

    public ushort NumberDataTransferElements
    {
        get => ((__Internal*)__Instance)->NumberDataTransferElements;

        set => ((__Internal*)__Instance)->NumberDataTransferElements = value;
    }

    public ushort NumberOfDoors
    {
        get => ((__Internal*)__Instance)->NumberOfDoors;

        set => ((__Internal*)__Instance)->NumberOfDoors = value;
    }

    public ushort FirstSlotNumber
    {
        get => ((__Internal*)__Instance)->FirstSlotNumber;

        set => ((__Internal*)__Instance)->FirstSlotNumber = value;
    }

    public ushort FirstDriveNumber
    {
        get => ((__Internal*)__Instance)->FirstDriveNumber;

        set => ((__Internal*)__Instance)->FirstDriveNumber = value;
    }

    public ushort FirstTransportNumber
    {
        get => ((__Internal*)__Instance)->FirstTransportNumber;

        set => ((__Internal*)__Instance)->FirstTransportNumber = value;
    }

    public ushort FirstIEPortNumber
    {
        get => ((__Internal*)__Instance)->FirstIEPortNumber;

        set => ((__Internal*)__Instance)->FirstIEPortNumber = value;
    }

    public ushort FirstCleanerSlotAddress
    {
        get => ((__Internal*)__Instance)->FirstCleanerSlotAddress;

        set => ((__Internal*)__Instance)->FirstCleanerSlotAddress = value;
    }

    public ushort MagazineSize
    {
        get => ((__Internal*)__Instance)->MagazineSize;

        set => ((__Internal*)__Instance)->MagazineSize = value;
    }

    public uint DriveCleanTimeout
    {
        get => ((__Internal*)__Instance)->DriveCleanTimeout;

        set => ((__Internal*)__Instance)->DriveCleanTimeout = value;
    }

    public uint Features0
    {
        get => ((__Internal*)__Instance)->Features0;

        set => ((__Internal*)__Instance)->Features0 = value;
    }

    public uint Features1
    {
        get => ((__Internal*)__Instance)->Features1;

        set => ((__Internal*)__Instance)->Features1 = value;
    }

    public byte MoveFromTransport
    {
        get => ((__Internal*)__Instance)->MoveFromTransport;

        set => ((__Internal*)__Instance)->MoveFromTransport = value;
    }

    public byte MoveFromSlot
    {
        get => ((__Internal*)__Instance)->MoveFromSlot;

        set => ((__Internal*)__Instance)->MoveFromSlot = value;
    }

    public byte MoveFromIePort
    {
        get => ((__Internal*)__Instance)->MoveFromIePort;

        set => ((__Internal*)__Instance)->MoveFromIePort = value;
    }

    public byte MoveFromDrive
    {
        get => ((__Internal*)__Instance)->MoveFromDrive;

        set => ((__Internal*)__Instance)->MoveFromDrive = value;
    }

    public byte ExchangeFromTransport
    {
        get => ((__Internal*)__Instance)->ExchangeFromTransport;

        set => ((__Internal*)__Instance)->ExchangeFromTransport = value;
    }

    public byte ExchangeFromSlot
    {
        get => ((__Internal*)__Instance)->ExchangeFromSlot;

        set => ((__Internal*)__Instance)->ExchangeFromSlot = value;
    }

    public byte ExchangeFromIePort
    {
        get => ((__Internal*)__Instance)->ExchangeFromIePort;

        set => ((__Internal*)__Instance)->ExchangeFromIePort = value;
    }

    public byte ExchangeFromDrive
    {
        get => ((__Internal*)__Instance)->ExchangeFromDrive;

        set => ((__Internal*)__Instance)->ExchangeFromDrive = value;
    }

    public byte LockUnlockCapabilities
    {
        get => ((__Internal*)__Instance)->LockUnlockCapabilities;

        set => ((__Internal*)__Instance)->LockUnlockCapabilities = value;
    }

    public byte PositionCapabilities
    {
        get => ((__Internal*)__Instance)->PositionCapabilities;

        set => ((__Internal*)__Instance)->PositionCapabilities = value;
    }

    public byte[] Reserved1
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->Reserved1, 2);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 2; i++)
                    ((__Internal*)__Instance)->Reserved1[i] = value[i];
            }
        }
    }

    public uint[] Reserved2
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->Reserved2, 2);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 2; i++)
                    ((__Internal*)__Instance)->Reserved2[i] = value[i];
            }
        }
    }
}