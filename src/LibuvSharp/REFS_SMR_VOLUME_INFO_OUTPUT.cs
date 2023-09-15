using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class REFS_SMR_VOLUME_INFO_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 112)]
    public partial struct __Internal
    {
        internal       uint                                        Version;
        internal       uint                                        Flags;
        internal       global::LARGE_INTEGER.__Internal            SizeOfRandomlyWritableTier;
        internal       global::LARGE_INTEGER.__Internal            FreeSpaceInRandomlyWritableTier;
        internal       global::LARGE_INTEGER.__Internal            SizeofSMRTier;
        internal       global::LARGE_INTEGER.__Internal            FreeSpaceInSMRTier;
        internal       global::LARGE_INTEGER.__Internal            UsableFreeSpaceInSMRTier;
        internal       global::LibuvSharp.REFS_SMR_VOLUME_GC_STATE VolumeGcState;
        internal       uint                                        VolumeGcLastStatus;
        internal       uint                                        CurrentGcBandFillPercentage;
        internal fixed ulong                                       Unused[6];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REFS_SMR_VOLUME_INFO_OUTPUT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REFS_SMR_VOLUME_INFO_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.REFS_SMR_VOLUME_INFO_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.REFS_SMR_VOLUME_INFO_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static REFS_SMR_VOLUME_INFO_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new REFS_SMR_VOLUME_INFO_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static REFS_SMR_VOLUME_INFO_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (REFS_SMR_VOLUME_INFO_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static REFS_SMR_VOLUME_INFO_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new REFS_SMR_VOLUME_INFO_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private REFS_SMR_VOLUME_INFO_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected REFS_SMR_VOLUME_INFO_OUTPUT(void* native, bool skipVTables = false)
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

    public uint Version
    {
        get => ((__Internal*)__Instance)->Version;

        set => ((__Internal*)__Instance)->Version = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public global::LibuvSharp.REFS_SMR_VOLUME_GC_STATE VolumeGcState
    {
        get => ((__Internal*)__Instance)->VolumeGcState;

        set => ((__Internal*)__Instance)->VolumeGcState = value;
    }

    public uint VolumeGcLastStatus
    {
        get => ((__Internal*)__Instance)->VolumeGcLastStatus;

        set => ((__Internal*)__Instance)->VolumeGcLastStatus = value;
    }

    public uint CurrentGcBandFillPercentage
    {
        get => ((__Internal*)__Instance)->CurrentGcBandFillPercentage;

        set => ((__Internal*)__Instance)->CurrentGcBandFillPercentage = value;
    }

    public ulong[] Unused
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->Unused, 6);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 6; i++)
                    ((__Internal*)__Instance)->Unused[i] = value[i];
            }
        }
    }
}