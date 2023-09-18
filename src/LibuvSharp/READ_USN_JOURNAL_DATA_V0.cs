using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class READ_USN_JOURNAL_DATA_V0 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal long  StartUsn;
        internal uint  ReasonMask;
        internal uint  ReturnOnlyOnClose;
        internal ulong Timeout;
        internal ulong BytesToWaitFor;
        internal ulong UsnJournalID;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, READ_USN_JOURNAL_DATA_V0> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, READ_USN_JOURNAL_DATA_V0>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, READ_USN_JOURNAL_DATA_V0 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out READ_USN_JOURNAL_DATA_V0 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static READ_USN_JOURNAL_DATA_V0 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new READ_USN_JOURNAL_DATA_V0(native.ToPointer(), skipVTables);
    }

    internal static READ_USN_JOURNAL_DATA_V0 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (READ_USN_JOURNAL_DATA_V0)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static READ_USN_JOURNAL_DATA_V0 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new READ_USN_JOURNAL_DATA_V0(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private READ_USN_JOURNAL_DATA_V0(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected READ_USN_JOURNAL_DATA_V0(void* native, bool skipVTables = false)
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

    public long StartUsn
    {
        get => ((__Internal*)__Instance)->StartUsn;

        set => ((__Internal*)__Instance)->StartUsn = value;
    }

    public uint ReasonMask
    {
        get => ((__Internal*)__Instance)->ReasonMask;

        set => ((__Internal*)__Instance)->ReasonMask = value;
    }

    public uint ReturnOnlyOnClose
    {
        get => ((__Internal*)__Instance)->ReturnOnlyOnClose;

        set => ((__Internal*)__Instance)->ReturnOnlyOnClose = value;
    }

    public ulong Timeout
    {
        get => ((__Internal*)__Instance)->Timeout;

        set => ((__Internal*)__Instance)->Timeout = value;
    }

    public ulong BytesToWaitFor
    {
        get => ((__Internal*)__Instance)->BytesToWaitFor;

        set => ((__Internal*)__Instance)->BytesToWaitFor = value;
    }

    public ulong UsnJournalID
    {
        get => ((__Internal*)__Instance)->UsnJournalID;

        set => ((__Internal*)__Instance)->UsnJournalID = value;
    }
}