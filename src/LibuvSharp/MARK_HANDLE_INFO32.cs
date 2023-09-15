using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class MARK_HANDLE_INFO32 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public partial struct __Internal
    {
        internal uint UsnSourceInfo;
        internal uint VolumeHandle;
        internal uint HandleInfo;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MARK_HANDLE_INFO32> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.MARK_HANDLE_INFO32>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.MARK_HANDLE_INFO32 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.MARK_HANDLE_INFO32 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MARK_HANDLE_INFO32 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MARK_HANDLE_INFO32(native.ToPointer(), skipVTables);
    }

    internal static MARK_HANDLE_INFO32 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MARK_HANDLE_INFO32)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MARK_HANDLE_INFO32 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MARK_HANDLE_INFO32(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MARK_HANDLE_INFO32(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MARK_HANDLE_INFO32(void* native, bool skipVTables = false)
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

    public uint UsnSourceInfo
    {
        get => ((__Internal*)__Instance)->UsnSourceInfo;

        set => ((__Internal*)__Instance)->UsnSourceInfo = value;
    }

    public uint VolumeHandle
    {
        get => ((__Internal*)__Instance)->VolumeHandle;

        set => ((__Internal*)__Instance)->VolumeHandle = value;
    }

    public uint HandleInfo
    {
        get => ((__Internal*)__Instance)->HandleInfo;

        set => ((__Internal*)__Instance)->HandleInfo = value;
    }
}