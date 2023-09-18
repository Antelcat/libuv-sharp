using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class MODEMDEVCAPS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 80)]
    public struct __Internal
    {
        internal       uint dwActualSize;
        internal       uint dwRequiredSize;
        internal       uint dwDevSpecificOffset;
        internal       uint dwDevSpecificSize;
        internal       uint dwModemProviderVersion;
        internal       uint dwModemManufacturerOffset;
        internal       uint dwModemManufacturerSize;
        internal       uint dwModemModelOffset;
        internal       uint dwModemModelSize;
        internal       uint dwModemVersionOffset;
        internal       uint dwModemVersionSize;
        internal       uint dwDialOptions;
        internal       uint dwCallSetupFailTimer;
        internal       uint dwInactivityTimeout;
        internal       uint dwSpeakerVolume;
        internal       uint dwSpeakerMode;
        internal       uint dwModemOptions;
        internal       uint dwMaxDTERate;
        internal       uint dwMaxDCERate;
        internal fixed byte abVariablePortion[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, MODEMDEVCAPS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, MODEMDEVCAPS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, MODEMDEVCAPS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MODEMDEVCAPS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MODEMDEVCAPS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MODEMDEVCAPS(native.ToPointer(), skipVTables);
    }

    internal static MODEMDEVCAPS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MODEMDEVCAPS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MODEMDEVCAPS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MODEMDEVCAPS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MODEMDEVCAPS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MODEMDEVCAPS(void* native, bool skipVTables = false)
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

    public uint DwActualSize
    {
        get => ((__Internal*)__Instance)->dwActualSize;

        set => ((__Internal*)__Instance)->dwActualSize = value;
    }

    public uint DwRequiredSize
    {
        get => ((__Internal*)__Instance)->dwRequiredSize;

        set => ((__Internal*)__Instance)->dwRequiredSize = value;
    }

    public uint DwDevSpecificOffset
    {
        get => ((__Internal*)__Instance)->dwDevSpecificOffset;

        set => ((__Internal*)__Instance)->dwDevSpecificOffset = value;
    }

    public uint DwDevSpecificSize
    {
        get => ((__Internal*)__Instance)->dwDevSpecificSize;

        set => ((__Internal*)__Instance)->dwDevSpecificSize = value;
    }

    public uint DwModemProviderVersion
    {
        get => ((__Internal*)__Instance)->dwModemProviderVersion;

        set => ((__Internal*)__Instance)->dwModemProviderVersion = value;
    }

    public uint DwModemManufacturerOffset
    {
        get => ((__Internal*)__Instance)->dwModemManufacturerOffset;

        set => ((__Internal*)__Instance)->dwModemManufacturerOffset = value;
    }

    public uint DwModemManufacturerSize
    {
        get => ((__Internal*)__Instance)->dwModemManufacturerSize;

        set => ((__Internal*)__Instance)->dwModemManufacturerSize = value;
    }

    public uint DwModemModelOffset
    {
        get => ((__Internal*)__Instance)->dwModemModelOffset;

        set => ((__Internal*)__Instance)->dwModemModelOffset = value;
    }

    public uint DwModemModelSize
    {
        get => ((__Internal*)__Instance)->dwModemModelSize;

        set => ((__Internal*)__Instance)->dwModemModelSize = value;
    }

    public uint DwModemVersionOffset
    {
        get => ((__Internal*)__Instance)->dwModemVersionOffset;

        set => ((__Internal*)__Instance)->dwModemVersionOffset = value;
    }

    public uint DwModemVersionSize
    {
        get => ((__Internal*)__Instance)->dwModemVersionSize;

        set => ((__Internal*)__Instance)->dwModemVersionSize = value;
    }

    public uint DwDialOptions
    {
        get => ((__Internal*)__Instance)->dwDialOptions;

        set => ((__Internal*)__Instance)->dwDialOptions = value;
    }

    public uint DwCallSetupFailTimer
    {
        get => ((__Internal*)__Instance)->dwCallSetupFailTimer;

        set => ((__Internal*)__Instance)->dwCallSetupFailTimer = value;
    }

    public uint DwInactivityTimeout
    {
        get => ((__Internal*)__Instance)->dwInactivityTimeout;

        set => ((__Internal*)__Instance)->dwInactivityTimeout = value;
    }

    public uint DwSpeakerVolume
    {
        get => ((__Internal*)__Instance)->dwSpeakerVolume;

        set => ((__Internal*)__Instance)->dwSpeakerVolume = value;
    }

    public uint DwSpeakerMode
    {
        get => ((__Internal*)__Instance)->dwSpeakerMode;

        set => ((__Internal*)__Instance)->dwSpeakerMode = value;
    }

    public uint DwModemOptions
    {
        get => ((__Internal*)__Instance)->dwModemOptions;

        set => ((__Internal*)__Instance)->dwModemOptions = value;
    }

    public uint DwMaxDTERate
    {
        get => ((__Internal*)__Instance)->dwMaxDTERate;

        set => ((__Internal*)__Instance)->dwMaxDTERate = value;
    }

    public uint DwMaxDCERate
    {
        get => ((__Internal*)__Instance)->dwMaxDCERate;

        set => ((__Internal*)__Instance)->dwMaxDCERate = value;
    }

    public byte[] AbVariablePortion
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->abVariablePortion, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->abVariablePortion[i] = value[i];
            }
        }
    }
}