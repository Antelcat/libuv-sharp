using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class RETRIEVAL_POINTERS_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal       uint                     ExtentCount;
        internal       LARGE_INTEGER.__Internal StartingVcn;
        internal fixed byte                     Extents[16];
    }

    public partial class _0 : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal LARGE_INTEGER.__Internal NextVcn;
            internal LARGE_INTEGER.__Internal Lcn;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, _0> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, _0>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, _0 managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out _0 managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static _0 __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new _0(native.ToPointer(), skipVTables);
        }

        internal static _0 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (_0)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static _0 __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new _0(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private _0(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected _0(void* native, bool skipVTables = false)
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
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, RETRIEVAL_POINTERS_BUFFER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, RETRIEVAL_POINTERS_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, RETRIEVAL_POINTERS_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out RETRIEVAL_POINTERS_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static RETRIEVAL_POINTERS_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new RETRIEVAL_POINTERS_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static RETRIEVAL_POINTERS_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (RETRIEVAL_POINTERS_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static RETRIEVAL_POINTERS_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new RETRIEVAL_POINTERS_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private RETRIEVAL_POINTERS_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected RETRIEVAL_POINTERS_BUFFER(void* native, bool skipVTables = false)
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

    public uint ExtentCount
    {
        get => ((__Internal*)__Instance)->ExtentCount;

        set => ((__Internal*)__Instance)->ExtentCount = value;
    }

    public _0[] Extents
    {
        get
        {
            _0[] __value = null;
            if (((__Internal*)__Instance)->Extents != null)
            {
                __value = new _0[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = _0.__GetOrCreateInstance((IntPtr)(_0.__Internal*)&((__Internal*)__Instance)->Extents[i * sizeof(_0.__Internal)], true, true);
            }
            return __value;
        }

        set
        {
            if (value != null)
            {
                if (value.Length != 1)
                    throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                for (var i = 0; i < 1; i++)
                    *(_0.__Internal*) &((__Internal*)__Instance)->Extents[i * sizeof(_0.__Internal)] = *(_0.__Internal*)value[i].__Instance;
            }
        }
    }
}