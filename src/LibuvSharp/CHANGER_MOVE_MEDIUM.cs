using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_MOVE_MEDIUM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public struct __Internal
    {
        internal CHANGER_ELEMENT.__Internal Transport;
        internal CHANGER_ELEMENT.__Internal Source;
        internal CHANGER_ELEMENT.__Internal Destination;
        internal byte                       Flip;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, CHANGER_MOVE_MEDIUM> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, CHANGER_MOVE_MEDIUM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, CHANGER_MOVE_MEDIUM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out CHANGER_MOVE_MEDIUM managed)
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

    public CHANGER_ELEMENT Transport
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Transport));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Transport = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public CHANGER_ELEMENT Source
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Source));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Source = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public CHANGER_ELEMENT Destination
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Destination));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Destination = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public byte Flip
    {
        get => ((__Internal*)__Instance)->Flip;

        set => ((__Internal*)__Instance)->Flip = value;
    }
}