using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PLEX_READ_DATA_REQUEST : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal global::LARGE_INTEGER.__Internal ByteOffset;
        internal uint                             ByteLength;
        internal uint                             PlexNumber;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PLEX_READ_DATA_REQUEST> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PLEX_READ_DATA_REQUEST>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PLEX_READ_DATA_REQUEST managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PLEX_READ_DATA_REQUEST managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PLEX_READ_DATA_REQUEST __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PLEX_READ_DATA_REQUEST(native.ToPointer(), skipVTables);
    }

    internal static PLEX_READ_DATA_REQUEST __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PLEX_READ_DATA_REQUEST)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PLEX_READ_DATA_REQUEST __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PLEX_READ_DATA_REQUEST(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PLEX_READ_DATA_REQUEST(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PLEX_READ_DATA_REQUEST(void* native, bool skipVTables = false)
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

    public uint ByteLength
    {
        get => ((__Internal*)__Instance)->ByteLength;

        set => ((__Internal*)__Instance)->ByteLength = value;
    }

    public uint PlexNumber
    {
        get => ((__Internal*)__Instance)->PlexNumber;

        set => ((__Internal*)__Instance)->PlexNumber = value;
    }
}