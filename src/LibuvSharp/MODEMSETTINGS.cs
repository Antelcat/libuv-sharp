using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class MODEMSETTINGS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 48)]
    public struct __Internal
    {
        internal       uint dwActualSize;
        internal       uint dwRequiredSize;
        internal       uint dwDevSpecificOffset;
        internal       uint dwDevSpecificSize;
        internal       uint dwCallSetupFailTimer;
        internal       uint dwInactivityTimeout;
        internal       uint dwSpeakerVolume;
        internal       uint dwSpeakerMode;
        internal       uint dwPreferredModemOptions;
        internal       uint dwNegotiatedModemOptions;
        internal       uint dwNegotiatedDCERate;
        internal fixed byte abVariablePortion[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, MODEMSETTINGS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, MODEMSETTINGS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, MODEMSETTINGS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MODEMSETTINGS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MODEMSETTINGS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MODEMSETTINGS(native.ToPointer(), skipVTables);
    }

    internal static MODEMSETTINGS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MODEMSETTINGS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MODEMSETTINGS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MODEMSETTINGS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MODEMSETTINGS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MODEMSETTINGS(void* native, bool skipVTables = false)
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

    public uint DwPreferredModemOptions
    {
        get => ((__Internal*)__Instance)->dwPreferredModemOptions;

        set => ((__Internal*)__Instance)->dwPreferredModemOptions = value;
    }

    public uint DwNegotiatedModemOptions
    {
        get => ((__Internal*)__Instance)->dwNegotiatedModemOptions;

        set => ((__Internal*)__Instance)->dwNegotiatedModemOptions = value;
    }

    public uint DwNegotiatedDCERate
    {
        get => ((__Internal*)__Instance)->dwNegotiatedDCERate;

        set => ((__Internal*)__Instance)->dwNegotiatedDCERate = value;
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