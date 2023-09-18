using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class READ_FILE_USN_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal ushort MinMajorVersion;
        internal ushort MaxMajorVersion;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, READ_FILE_USN_DATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, READ_FILE_USN_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, READ_FILE_USN_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out READ_FILE_USN_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static READ_FILE_USN_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new READ_FILE_USN_DATA(native.ToPointer(), skipVTables);
    }

    internal static READ_FILE_USN_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (READ_FILE_USN_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static READ_FILE_USN_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new READ_FILE_USN_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private READ_FILE_USN_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected READ_FILE_USN_DATA(void* native, bool skipVTables = false)
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

    public ushort MinMajorVersion
    {
        get => ((__Internal*)__Instance)->MinMajorVersion;

        set => ((__Internal*)__Instance)->MinMajorVersion = value;
    }

    public ushort MaxMajorVersion
    {
        get => ((__Internal*)__Instance)->MaxMajorVersion;

        set => ((__Internal*)__Instance)->MaxMajorVersion = value;
    }
}