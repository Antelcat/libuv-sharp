using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class DISK_PERFORMANCE : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 88)]
    public struct __Internal
    {
        internal       LARGE_INTEGER.__Internal BytesRead;
        internal       LARGE_INTEGER.__Internal BytesWritten;
        internal       LARGE_INTEGER.__Internal ReadTime;
        internal       LARGE_INTEGER.__Internal WriteTime;
        internal       LARGE_INTEGER.__Internal IdleTime;
        internal       uint                     ReadCount;
        internal       uint                     WriteCount;
        internal       uint                     QueueDepth;
        internal       uint                     SplitCount;
        internal       LARGE_INTEGER.__Internal QueryTime;
        internal       uint                     StorageDeviceNumber;
        internal fixed char                     StorageManagerName[8];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, DISK_PERFORMANCE> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, DISK_PERFORMANCE>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, DISK_PERFORMANCE managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out DISK_PERFORMANCE managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_PERFORMANCE __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_PERFORMANCE(native.ToPointer(), skipVTables);
    }

    internal static DISK_PERFORMANCE __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_PERFORMANCE)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_PERFORMANCE __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_PERFORMANCE(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_PERFORMANCE(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_PERFORMANCE(void* native, bool skipVTables = false)
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

    public uint ReadCount
    {
        get => ((__Internal*)__Instance)->ReadCount;

        set => ((__Internal*)__Instance)->ReadCount = value;
    }

    public uint WriteCount
    {
        get => ((__Internal*)__Instance)->WriteCount;

        set => ((__Internal*)__Instance)->WriteCount = value;
    }

    public uint QueueDepth
    {
        get => ((__Internal*)__Instance)->QueueDepth;

        set => ((__Internal*)__Instance)->QueueDepth = value;
    }

    public uint SplitCount
    {
        get => ((__Internal*)__Instance)->SplitCount;

        set => ((__Internal*)__Instance)->SplitCount = value;
    }

    public uint StorageDeviceNumber
    {
        get => ((__Internal*)__Instance)->StorageDeviceNumber;

        set => ((__Internal*)__Instance)->StorageDeviceNumber = value;
    }

    public char[] StorageManagerName
    {
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->StorageManagerName, 8);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 8; i++)
                    ((__Internal*)__Instance)->StorageManagerName[i] = value[i];
            }
        }
    }
}