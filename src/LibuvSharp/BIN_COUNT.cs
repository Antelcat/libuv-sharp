using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class BIN_COUNT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public struct __Internal
    {
        internal BIN_RANGE.__Internal BinRange;
        internal uint                 BinCount;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, BIN_COUNT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, BIN_COUNT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, BIN_COUNT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out BIN_COUNT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static BIN_COUNT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new BIN_COUNT(native.ToPointer(), skipVTables);
    }

    internal static BIN_COUNT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (BIN_COUNT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static BIN_COUNT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new BIN_COUNT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private BIN_COUNT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected BIN_COUNT(void* native, bool skipVTables = false)
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

    public BIN_RANGE BinRange
    {
        get => BIN_RANGE.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->BinRange));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->BinRange = *(BIN_RANGE.__Internal*) value.__Instance;
        }
    }

    public uint BinCount
    {
        get => ((__Internal*)__Instance)->BinCount;

        set => ((__Internal*)__Instance)->BinCount = value;
    }
}