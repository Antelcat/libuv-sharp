using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class READ_ELEMENT_ADDRESS_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 104)]
    public struct __Internal
    {
        internal       uint NumberOfElements;
        internal fixed byte ElementStatus[100];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, READ_ELEMENT_ADDRESS_INFO> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, READ_ELEMENT_ADDRESS_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, READ_ELEMENT_ADDRESS_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out READ_ELEMENT_ADDRESS_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static READ_ELEMENT_ADDRESS_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new READ_ELEMENT_ADDRESS_INFO(native.ToPointer(), skipVTables);
    }

    internal static READ_ELEMENT_ADDRESS_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (READ_ELEMENT_ADDRESS_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static READ_ELEMENT_ADDRESS_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new READ_ELEMENT_ADDRESS_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private READ_ELEMENT_ADDRESS_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected READ_ELEMENT_ADDRESS_INFO(void* native, bool skipVTables = false)
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

    public uint NumberOfElements
    {
        get => ((__Internal*)__Instance)->NumberOfElements;

        set => ((__Internal*)__Instance)->NumberOfElements = value;
    }

    public CHANGER_ELEMENT_STATUS[] ElementStatus
    {
        get
        {
            CHANGER_ELEMENT_STATUS[] __value = null;
            if (((__Internal*)__Instance)->ElementStatus != null)
            {
                __value = new CHANGER_ELEMENT_STATUS[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = CHANGER_ELEMENT_STATUS.__GetOrCreateInstance((IntPtr)(CHANGER_ELEMENT_STATUS.__Internal*)&((__Internal*)__Instance)->ElementStatus[i * sizeof(CHANGER_ELEMENT_STATUS.__Internal)], true, true);
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
                    *(CHANGER_ELEMENT_STATUS.__Internal*) &((__Internal*)__Instance)->ElementStatus[i * sizeof(CHANGER_ELEMENT_STATUS.__Internal)] = *(CHANGER_ELEMENT_STATUS.__Internal*)value[i].__Instance;
            }
        }
    }
}