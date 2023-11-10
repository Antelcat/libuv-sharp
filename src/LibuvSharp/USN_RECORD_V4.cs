using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_RECORD_V4 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 80)]
    public struct __Internal
    {
        internal       USN_RECORD_COMMON_HEADER.__Internal Header;
        internal       FILE_ID_128.__Internal              FileReferenceNumber;
        internal       FILE_ID_128.__Internal              ParentFileReferenceNumber;
        internal       long                                Usn;
        internal       uint                                Reason;
        internal       uint                                SourceInfo;
        internal       uint                                RemainingExtents;
        internal       ushort                              NumberOfExtents;
        internal       ushort                              ExtentSize;
        internal fixed byte                                Extents[16];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, USN_RECORD_V4> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, USN_RECORD_V4>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, USN_RECORD_V4 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out USN_RECORD_V4 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_RECORD_V4 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_RECORD_V4(native.ToPointer(), skipVTables);
    }

    internal static USN_RECORD_V4 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_RECORD_V4)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_RECORD_V4 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RECORD_V4(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_RECORD_V4(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_RECORD_V4(void* native, bool skipVTables = false)
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

    public USN_RECORD_COMMON_HEADER Header
    {
        get => USN_RECORD_COMMON_HEADER.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Header));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Header = *(USN_RECORD_COMMON_HEADER.__Internal*) value.__Instance;
        }
    }

    public long Usn
    {
        get => ((__Internal*)__Instance)->Usn;

        set => ((__Internal*)__Instance)->Usn = value;
    }

    public uint Reason
    {
        get => ((__Internal*)__Instance)->Reason;

        set => ((__Internal*)__Instance)->Reason = value;
    }

    public uint SourceInfo
    {
        get => ((__Internal*)__Instance)->SourceInfo;

        set => ((__Internal*)__Instance)->SourceInfo = value;
    }

    public uint RemainingExtents
    {
        get => ((__Internal*)__Instance)->RemainingExtents;

        set => ((__Internal*)__Instance)->RemainingExtents = value;
    }

    public ushort NumberOfExtents
    {
        get => ((__Internal*)__Instance)->NumberOfExtents;

        set => ((__Internal*)__Instance)->NumberOfExtents = value;
    }

    public ushort ExtentSize
    {
        get => ((__Internal*)__Instance)->ExtentSize;

        set => ((__Internal*)__Instance)->ExtentSize = value;
    }

    public USN_RECORD_EXTENT[] Extents
    {
        get
        {
            USN_RECORD_EXTENT[] __value = null;
            if (((__Internal*)__Instance)->Extents != null)
            {
                __value = new USN_RECORD_EXTENT[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = USN_RECORD_EXTENT.__GetOrCreateInstance((IntPtr)(USN_RECORD_EXTENT.__Internal*)&((__Internal*)__Instance)->Extents[i * sizeof(USN_RECORD_EXTENT.__Internal)], true, true);
            }
            return __value;
        }

        set
        {
            if (value != null)
            {
                if (value.Length != 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "The dimensions of the provided array don't match the required size.");
                for (var i = 0; i < 1; i++)
                    *(USN_RECORD_EXTENT.__Internal*) &((__Internal*)__Instance)->Extents[i * sizeof(USN_RECORD_EXTENT.__Internal)] = *(USN_RECORD_EXTENT.__Internal*)value[i].__Instance;
            }
        }
    }
}