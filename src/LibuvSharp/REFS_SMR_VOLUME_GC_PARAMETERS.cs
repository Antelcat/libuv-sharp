using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class REFS_SMR_VOLUME_GC_PARAMETERS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 88)]
    public struct __Internal
    {
        internal       uint                                         Version;
        internal       uint                                         Flags;
        internal       REFS_SMR_VOLUME_GC_ACTION Action;
        internal       REFS_SMR_VOLUME_GC_METHOD Method;
        internal       uint                                         IoGranularity;
        internal       uint                                         CompressionFormat;
        internal fixed ulong                                        Unused[8];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, REFS_SMR_VOLUME_GC_PARAMETERS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, REFS_SMR_VOLUME_GC_PARAMETERS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, REFS_SMR_VOLUME_GC_PARAMETERS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out REFS_SMR_VOLUME_GC_PARAMETERS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static REFS_SMR_VOLUME_GC_PARAMETERS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new REFS_SMR_VOLUME_GC_PARAMETERS(native.ToPointer(), skipVTables);
    }

    internal static REFS_SMR_VOLUME_GC_PARAMETERS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (REFS_SMR_VOLUME_GC_PARAMETERS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static REFS_SMR_VOLUME_GC_PARAMETERS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new REFS_SMR_VOLUME_GC_PARAMETERS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private REFS_SMR_VOLUME_GC_PARAMETERS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected REFS_SMR_VOLUME_GC_PARAMETERS(void* native, bool skipVTables = false)
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

    public REFS_SMR_VOLUME_GC_ACTION Action
    {
        get => ((__Internal*)__Instance)->Action;

        set => ((__Internal*)__Instance)->Action = value;
    }

    public REFS_SMR_VOLUME_GC_METHOD Method
    {
        get => ((__Internal*)__Instance)->Method;

        set => ((__Internal*)__Instance)->Method = value;
    }

    public uint IoGranularity
    {
        get => ((__Internal*)__Instance)->IoGranularity;

        set => ((__Internal*)__Instance)->IoGranularity = value;
    }

    public uint CompressionFormat
    {
        get => ((__Internal*)__Instance)->CompressionFormat;

        set => ((__Internal*)__Instance)->CompressionFormat = value;
    }

    public ulong[] Unused
    {
        get => MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->Unused, 8);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 8; i++)
                    ((__Internal*)__Instance)->Unused[i] = value[i];
            }
        }
    }
}