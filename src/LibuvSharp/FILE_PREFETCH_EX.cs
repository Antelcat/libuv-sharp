using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILE_PREFETCH_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal       uint     Type;
        internal       uint     Count;
        internal       IntPtr Context;
        internal fixed ulong    Prefetch[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_PREFETCH_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_PREFETCH_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FILE_PREFETCH_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FILE_PREFETCH_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILE_PREFETCH_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILE_PREFETCH_EX(native.ToPointer(), skipVTables);
    }

    internal static FILE_PREFETCH_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILE_PREFETCH_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILE_PREFETCH_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILE_PREFETCH_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILE_PREFETCH_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILE_PREFETCH_EX(void* native, bool skipVTables = false)
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

    public uint Type
    {
        get => ((__Internal*)__Instance)->Type;

        set => ((__Internal*)__Instance)->Type = value;
    }

    public uint Count
    {
        get => ((__Internal*)__Instance)->Count;

        set => ((__Internal*)__Instance)->Count = value;
    }

    public IntPtr Context
    {
        get => ((__Internal*)__Instance)->Context;

        set => ((__Internal*)__Instance)->Context = (IntPtr) value;
    }

    public ulong[] Prefetch
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<ulong>(((__Internal*)__Instance)->Prefetch, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->Prefetch[i] = value[i];
            }
        }
    }
}