using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_ELEMENT_LIST : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct __Internal
    {
        internal CHANGER_ELEMENT.__Internal Element;
        internal uint                       NumberOfElements;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, CHANGER_ELEMENT_LIST> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, CHANGER_ELEMENT_LIST>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, CHANGER_ELEMENT_LIST managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out CHANGER_ELEMENT_LIST managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_ELEMENT_LIST __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_ELEMENT_LIST(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_ELEMENT_LIST __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_ELEMENT_LIST)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_ELEMENT_LIST __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_ELEMENT_LIST(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_ELEMENT_LIST(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_ELEMENT_LIST(void* native, bool skipVTables = false)
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

    public CHANGER_ELEMENT Element
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Element));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Element = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public uint NumberOfElements
    {
        get => ((__Internal*)__Instance)->NumberOfElements;

        set => ((__Internal*)__Instance)->NumberOfElements = value;
    }
}