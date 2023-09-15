using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public partial struct __Internal
    {
        internal uint  Flags;
        internal uint  AlignmentShift;
        internal ulong FileOffsetToAlign;
        internal uint  FallbackAlignmentShift;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT(native.ToPointer(), skipVTables);
    }

    internal static SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SET_DAX_ALLOC_ALIGNMENT_HINT_INPUT(void* native, bool skipVTables = false)
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

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public uint AlignmentShift
    {
        get => ((__Internal*)__Instance)->AlignmentShift;

        set => ((__Internal*)__Instance)->AlignmentShift = value;
    }

    public ulong FileOffsetToAlign
    {
        get => ((__Internal*)__Instance)->FileOffsetToAlign;

        set => ((__Internal*)__Instance)->FileOffsetToAlign = value;
    }

    public uint FallbackAlignmentShift
    {
        get => ((__Internal*)__Instance)->FallbackAlignmentShift;

        set => ((__Internal*)__Instance)->FallbackAlignmentShift = value;
    }
}