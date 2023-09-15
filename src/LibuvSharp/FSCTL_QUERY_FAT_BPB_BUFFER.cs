using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FSCTL_QUERY_FAT_BPB_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 36)]
    public partial struct __Internal
    {
        internal fixed byte First0x24BytesOfBootSector[36];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FSCTL_QUERY_FAT_BPB_BUFFER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FSCTL_QUERY_FAT_BPB_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FSCTL_QUERY_FAT_BPB_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FSCTL_QUERY_FAT_BPB_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FSCTL_QUERY_FAT_BPB_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FSCTL_QUERY_FAT_BPB_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static FSCTL_QUERY_FAT_BPB_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FSCTL_QUERY_FAT_BPB_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FSCTL_QUERY_FAT_BPB_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FSCTL_QUERY_FAT_BPB_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FSCTL_QUERY_FAT_BPB_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FSCTL_QUERY_FAT_BPB_BUFFER(void* native, bool skipVTables = false)
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

    public byte[] First0x24BytesOfBootSector
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->First0x24BytesOfBootSector, 36);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 36; i++)
                    ((__Internal*)__Instance)->First0x24BytesOfBootSector[i] = value[i];
            }
        }
    }
}