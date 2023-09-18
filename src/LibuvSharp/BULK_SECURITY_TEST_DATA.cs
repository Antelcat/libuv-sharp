using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class BULK_SECURITY_TEST_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal       uint DesiredAccess;
        internal fixed uint SecurityIds[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, BULK_SECURITY_TEST_DATA> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, BULK_SECURITY_TEST_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, BULK_SECURITY_TEST_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out BULK_SECURITY_TEST_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static BULK_SECURITY_TEST_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new BULK_SECURITY_TEST_DATA(native.ToPointer(), skipVTables);
    }

    internal static BULK_SECURITY_TEST_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (BULK_SECURITY_TEST_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static BULK_SECURITY_TEST_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new BULK_SECURITY_TEST_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private BULK_SECURITY_TEST_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected BULK_SECURITY_TEST_DATA(void* native, bool skipVTables = false)
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

    public uint DesiredAccess
    {
        get => ((__Internal*)__Instance)->DesiredAccess;

        set => ((__Internal*)__Instance)->DesiredAccess = value;
    }

    public uint[] SecurityIds
    {
        get => MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->SecurityIds, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->SecurityIds[i] = value[i];
            }
        }
    }
}