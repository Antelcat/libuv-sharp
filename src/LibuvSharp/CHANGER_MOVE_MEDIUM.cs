using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_MOVE_MEDIUM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public partial struct __Internal
    {
        internal global::LibuvSharp.CHANGER_ELEMENT.__Internal Transport;
        internal global::LibuvSharp.CHANGER_ELEMENT.__Internal Source;
        internal global::LibuvSharp.CHANGER_ELEMENT.__Internal Destination;
        internal byte                                          Flip;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_MOVE_MEDIUM> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_MOVE_MEDIUM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CHANGER_MOVE_MEDIUM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CHANGER_MOVE_MEDIUM managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_MOVE_MEDIUM __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_MOVE_MEDIUM(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_MOVE_MEDIUM __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_MOVE_MEDIUM)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_MOVE_MEDIUM __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_MOVE_MEDIUM(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_MOVE_MEDIUM(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_MOVE_MEDIUM(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.CHANGER_ELEMENT Transport
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Transport));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Transport = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.CHANGER_ELEMENT Source
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Source));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Source = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.CHANGER_ELEMENT Destination
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Destination));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Destination = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public byte Flip
    {
        get => ((__Internal*)__Instance)->Flip;

        set => ((__Internal*)__Instance)->Flip = value;
    }
}