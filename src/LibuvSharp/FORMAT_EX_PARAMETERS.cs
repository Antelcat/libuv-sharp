using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class FORMAT_EX_PARAMETERS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public struct __Internal
    {
        internal       MEDIA_TYPE MediaType;
        internal       uint                          StartCylinderNumber;
        internal       uint                          EndCylinderNumber;
        internal       uint                          StartHeadNumber;
        internal       uint                          EndHeadNumber;
        internal       ushort                        FormatGapLength;
        internal       ushort                        SectorsPerTrack;
        internal fixed ushort                        SectorNumber[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, FORMAT_EX_PARAMETERS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, FORMAT_EX_PARAMETERS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, FORMAT_EX_PARAMETERS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out FORMAT_EX_PARAMETERS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FORMAT_EX_PARAMETERS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FORMAT_EX_PARAMETERS(native.ToPointer(), skipVTables);
    }

    internal static FORMAT_EX_PARAMETERS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FORMAT_EX_PARAMETERS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FORMAT_EX_PARAMETERS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FORMAT_EX_PARAMETERS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FORMAT_EX_PARAMETERS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FORMAT_EX_PARAMETERS(void* native, bool skipVTables = false)
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

    public MEDIA_TYPE MediaType
    {
        get => ((__Internal*)__Instance)->MediaType;

        set => ((__Internal*)__Instance)->MediaType = value;
    }

    public uint StartCylinderNumber
    {
        get => ((__Internal*)__Instance)->StartCylinderNumber;

        set => ((__Internal*)__Instance)->StartCylinderNumber = value;
    }

    public uint EndCylinderNumber
    {
        get => ((__Internal*)__Instance)->EndCylinderNumber;

        set => ((__Internal*)__Instance)->EndCylinderNumber = value;
    }

    public uint StartHeadNumber
    {
        get => ((__Internal*)__Instance)->StartHeadNumber;

        set => ((__Internal*)__Instance)->StartHeadNumber = value;
    }

    public uint EndHeadNumber
    {
        get => ((__Internal*)__Instance)->EndHeadNumber;

        set => ((__Internal*)__Instance)->EndHeadNumber = value;
    }

    public ushort FormatGapLength
    {
        get => ((__Internal*)__Instance)->FormatGapLength;

        set => ((__Internal*)__Instance)->FormatGapLength = value;
    }

    public ushort SectorsPerTrack
    {
        get => ((__Internal*)__Instance)->SectorsPerTrack;

        set => ((__Internal*)__Instance)->SectorsPerTrack = value;
    }

    public ushort[] SectorNumber
    {
        get => MarshalUtil.GetArray<ushort>(((__Internal*)__Instance)->SectorNumber, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->SectorNumber[i] = value[i];
            }
        }
    }
}