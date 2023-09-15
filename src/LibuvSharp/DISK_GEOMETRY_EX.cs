using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DISK_GEOMETRY_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public partial struct __Internal
    {
        internal       global::LibuvSharp.DISK_GEOMETRY.__Internal Geometry;
        internal       global::LARGE_INTEGER.__Internal            DiskSize;
        internal fixed byte                                        Data[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_GEOMETRY_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DISK_GEOMETRY_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DISK_GEOMETRY_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DISK_GEOMETRY_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DISK_GEOMETRY_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DISK_GEOMETRY_EX(native.ToPointer(), skipVTables);
    }

    internal static DISK_GEOMETRY_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DISK_GEOMETRY_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DISK_GEOMETRY_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DISK_GEOMETRY_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DISK_GEOMETRY_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DISK_GEOMETRY_EX(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.DISK_GEOMETRY Geometry
    {
        get => global::LibuvSharp.DISK_GEOMETRY.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Geometry));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Geometry = *(global::LibuvSharp.DISK_GEOMETRY.__Internal*) value.__Instance;
        }
    }

    public byte[] Data
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->Data, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->Data[i] = value[i];
            }
        }
    }
}