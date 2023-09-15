using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_DETECTION_INFO : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        internal uint SizeOfDetectInfo;

        [FieldOffset(4)]
        internal global::LibuvSharp.DETECTION_TYPE DetectionType;

        [FieldOffset(8)]
        internal global::LibuvSharp.DISK_INT13INFO.__Internal Int13;

        [FieldOffset(24)]
        internal global::LibuvSharp.DISK_EX_INT13INFO.__Internal ExInt13;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_DETECTION_INFO> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_DETECTION_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_DETECTION_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_DETECTION_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_DETECTION_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_DETECTION_INFO(native.ToPointer(), skipVTables);
    }

    internal static DISK_DETECTION_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_DETECTION_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_DETECTION_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_DETECTION_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_DETECTION_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_DETECTION_INFO(void* native, bool skipVTables = false)
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

    public uint SizeOfDetectInfo
    {
        get => ((__Internal*)__Instance)->SizeOfDetectInfo;

        set => ((__Internal*)__Instance)->SizeOfDetectInfo = value;
    }

    public global::LibuvSharp.DETECTION_TYPE DetectionType
    {
        get => ((__Internal*)__Instance)->DetectionType;

        set => ((__Internal*)__Instance)->DetectionType = value;
    }

    public global::LibuvSharp.DISK_INT13INFO Int13
    {
        get => global::LibuvSharp.DISK_INT13INFO.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Int13));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Int13 = *(global::LibuvSharp.DISK_INT13INFO.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.DISK_EX_INT13INFO ExInt13
    {
        get => global::LibuvSharp.DISK_EX_INT13INFO.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->ExInt13));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->ExInt13 = *(global::LibuvSharp.DISK_EX_INT13INFO.__Internal*) value.__Instance;
        }
    }
}