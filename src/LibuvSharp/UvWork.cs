using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using LibuvSharp.Delegates;

namespace LibuvSharp;

public unsafe partial class UvWork : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal IntPtr             work;
        internal IntPtr             done;
        internal IntPtr             loop;
        internal UvQueue.__Internal wq;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv__work@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvWork> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, UvWork>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvWork managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvWork managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvWork __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvWork(native.ToPointer(), skipVTables);
    }

    internal static UvWork __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvWork)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvWork __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvWork(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvWork(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvWork(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvWork()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvWork(UvWork _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*) __Instance = *(__Internal*) _0.__Instance;
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

    public Action___IntPtr Work
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->work;
            return __ptr0 == IntPtr.Zero? null : (Action___IntPtr) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(Action___IntPtr));
        }

        set => ((__Internal*)__Instance)->work = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public Action___IntPtr_int Done
    {
        get
        {
            var __ptr0 = ((__Internal*)__Instance)->done;
            return __ptr0 == IntPtr.Zero? null : (Action___IntPtr_int) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(Action___IntPtr_int));
        }

        set => ((__Internal*)__Instance)->done = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
    }

    public UvLoopS Loop
    {
        get
        {
            var __result0 = UvLoopS.__GetOrCreateInstance(((__Internal*)__Instance)->loop);
            return __result0;
        }

        set => ((__Internal*)__Instance)->loop = value is null ? IntPtr.Zero : value.__Instance;
    }

    public UvQueue Wq
    {
        get => UvQueue.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->wq));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->wq = *(UvQueue.__Internal*) value.__Instance;
        }
    }
}