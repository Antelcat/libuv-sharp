using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class VIRTUALIZATION_INSTANCE_INFO_INPUT_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal ushort HeaderSize;
        internal uint   Flags;
        internal uint   NotificationInfoSize;
        internal ushort NotificationInfoOffset;
        internal ushort ProviderMajorVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, VIRTUALIZATION_INSTANCE_INFO_INPUT_EX> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, VIRTUALIZATION_INSTANCE_INFO_INPUT_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, VIRTUALIZATION_INSTANCE_INFO_INPUT_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out VIRTUALIZATION_INSTANCE_INFO_INPUT_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static VIRTUALIZATION_INSTANCE_INFO_INPUT_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new VIRTUALIZATION_INSTANCE_INFO_INPUT_EX(native.ToPointer(), skipVTables);
    }

    internal static VIRTUALIZATION_INSTANCE_INFO_INPUT_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (VIRTUALIZATION_INSTANCE_INFO_INPUT_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static VIRTUALIZATION_INSTANCE_INFO_INPUT_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new VIRTUALIZATION_INSTANCE_INFO_INPUT_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private VIRTUALIZATION_INSTANCE_INFO_INPUT_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected VIRTUALIZATION_INSTANCE_INFO_INPUT_EX(void* native, bool skipVTables = false)
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

    public ushort HeaderSize
    {
        get => ((__Internal*)__Instance)->HeaderSize;

        set => ((__Internal*)__Instance)->HeaderSize = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public uint NotificationInfoSize
    {
        get => ((__Internal*)__Instance)->NotificationInfoSize;

        set => ((__Internal*)__Instance)->NotificationInfoSize = value;
    }

    public ushort NotificationInfoOffset
    {
        get => ((__Internal*)__Instance)->NotificationInfoOffset;

        set => ((__Internal*)__Instance)->NotificationInfoOffset = value;
    }

    public ushort ProviderMajorVersion
    {
        get => ((__Internal*)__Instance)->ProviderMajorVersion;

        set => ((__Internal*)__Instance)->ProviderMajorVersion = value;
    }
}