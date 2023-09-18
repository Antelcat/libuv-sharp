using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using LibuvSharp.Delegates;

namespace LibuvSharp;

public unsafe partial class OLESTREAMVTBL : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16, Pack = 8)]
    public struct __Internal
    {
        internal IntPtr Get;
        internal IntPtr Put;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, OLESTREAMVTBL> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, OLESTREAMVTBL>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, OLESTREAMVTBL managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out OLESTREAMVTBL managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static OLESTREAMVTBL __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new OLESTREAMVTBL(native.ToPointer(), skipVTables);
    }

    internal static OLESTREAMVTBL __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (OLESTREAMVTBL)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static OLESTREAMVTBL __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new OLESTREAMVTBL(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private OLESTREAMVTBL(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected OLESTREAMVTBL(void* native, bool skipVTables = false)
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

    public Func_uint___IntPtr___IntPtr_uint Get
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->Get;
            return __ptr0 == IntPtr.Zero? null : (Func_uint___IntPtr___IntPtr_uint) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(Func_uint___IntPtr___IntPtr_uint));
        }

        set => ((__Internal*)__Instance)->Get = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public Func_uint___IntPtr___IntPtr_uint Put
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->Put;
            return __ptr0 == IntPtr.Zero? null : (Func_uint___IntPtr___IntPtr_uint) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(Func_uint___IntPtr___IntPtr_uint));
        }

        set => ((__Internal*)__Instance)->Put = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }
}