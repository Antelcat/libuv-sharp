using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class SET_DISK_ATTRIBUTES : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct __Internal
    {
        internal       uint  Version;
        internal       byte  Persist;
        internal fixed byte  Reserved1[3];
        internal       ulong Attributes;
        internal       ulong AttributesMask;
        internal fixed uint  Reserved2[4];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, SET_DISK_ATTRIBUTES> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, SET_DISK_ATTRIBUTES>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, SET_DISK_ATTRIBUTES managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out SET_DISK_ATTRIBUTES managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SET_DISK_ATTRIBUTES __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SET_DISK_ATTRIBUTES(native.ToPointer(), skipVTables);
    }

    internal static SET_DISK_ATTRIBUTES __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SET_DISK_ATTRIBUTES)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SET_DISK_ATTRIBUTES __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SET_DISK_ATTRIBUTES(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SET_DISK_ATTRIBUTES(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SET_DISK_ATTRIBUTES(void* native, bool skipVTables = false)
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

    public uint Version
    {
        get => ((__Internal*)__Instance)->Version;

        set => ((__Internal*)__Instance)->Version = value;
    }

    public byte Persist
    {
        get => ((__Internal*)__Instance)->Persist;

        set => ((__Internal*)__Instance)->Persist = value;
    }

    public byte[] Reserved1
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->Reserved1, 3);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 3; i++)
                    ((__Internal*)__Instance)->Reserved1[i] = value[i];
            }
        }
    }

    public ulong Attributes
    {
        get => ((__Internal*)__Instance)->Attributes;

        set => ((__Internal*)__Instance)->Attributes = value;
    }

    public ulong AttributesMask
    {
        get => ((__Internal*)__Instance)->AttributesMask;

        set => ((__Internal*)__Instance)->AttributesMask = value;
    }

    public uint[] Reserved2
    {
        get => MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->Reserved2, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->Reserved2[i] = value[i];
            }
        }
    }
}