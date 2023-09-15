using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_JOURNAL_DATA_V0 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 56)]
    public partial struct __Internal
    {
        internal ulong UsnJournalID;
        internal long  FirstUsn;
        internal long  NextUsn;
        internal long  LowestValidUsn;
        internal long  MaxUsn;
        internal ulong MaximumSize;
        internal ulong AllocationDelta;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_JOURNAL_DATA_V0> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_JOURNAL_DATA_V0>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.USN_JOURNAL_DATA_V0 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.USN_JOURNAL_DATA_V0 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_JOURNAL_DATA_V0 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_JOURNAL_DATA_V0(native.ToPointer(), skipVTables);
    }

    internal static USN_JOURNAL_DATA_V0 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_JOURNAL_DATA_V0)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_JOURNAL_DATA_V0 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_JOURNAL_DATA_V0(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_JOURNAL_DATA_V0(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_JOURNAL_DATA_V0(void* native, bool skipVTables = false)
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

    public ulong UsnJournalID
    {
        get => ((__Internal*)__Instance)->UsnJournalID;

        set => ((__Internal*)__Instance)->UsnJournalID = value;
    }

    public long FirstUsn
    {
        get => ((__Internal*)__Instance)->FirstUsn;

        set => ((__Internal*)__Instance)->FirstUsn = value;
    }

    public long NextUsn
    {
        get => ((__Internal*)__Instance)->NextUsn;

        set => ((__Internal*)__Instance)->NextUsn = value;
    }

    public long LowestValidUsn
    {
        get => ((__Internal*)__Instance)->LowestValidUsn;

        set => ((__Internal*)__Instance)->LowestValidUsn = value;
    }

    public long MaxUsn
    {
        get => ((__Internal*)__Instance)->MaxUsn;

        set => ((__Internal*)__Instance)->MaxUsn = value;
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