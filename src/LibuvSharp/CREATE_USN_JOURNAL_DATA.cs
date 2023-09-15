using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CREATE_USN_JOURNAL_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal ulong MaximumSize;
        internal ulong AllocationDelta;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_USN_JOURNAL_DATA> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CREATE_USN_JOURNAL_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CREATE_USN_JOURNAL_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CREATE_USN_JOURNAL_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CREATE_USN_JOURNAL_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CREATE_USN_JOURNAL_DATA(native.ToPointer(), skipVTables);
    }

    internal static CREATE_USN_JOURNAL_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CREATE_USN_JOURNAL_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CREATE_USN_JOURNAL_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CREATE_USN_JOURNAL_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CREATE_USN_JOURNAL_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CREATE_USN_JOURNAL_DATA(void* native, bool skipVTables = false)
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

    public ulong MaximumSize
    {
        get => ((__Internal*)__Instance)->MaximumSize;

        set => ((__Internal*)__Instance)->MaximumSize = value;
    }

    public ulong AllocationDelta
    {
        get => ((__Internal*)__Instance)->AllocationDelta;

        set => ((__Internal*)__Instance)->AllocationDelta = value;
    }
}