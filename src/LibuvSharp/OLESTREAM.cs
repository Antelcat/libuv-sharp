using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class OLESTREAM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public partial struct __Internal
    {
        internal IntPtr lpstbl;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.OLESTREAM> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.OLESTREAM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.OLESTREAM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.OLESTREAM managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static OLESTREAM __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new OLESTREAM(native.ToPointer(), skipVTables);
    }

    internal static OLESTREAM __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (OLESTREAM)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static OLESTREAM __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new OLESTREAM(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private OLESTREAM(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected OLESTREAM(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.OLESTREAMVTBL Lpstbl
    {
        get
        {
            var __result0 = global::LibuvSharp.OLESTREAMVTBL.__GetOrCreateInstance(((__Internal*)__Instance)->lpstbl, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->lpstbl = value is null ? IntPtr.Zero : value.__Instance;
    }
}