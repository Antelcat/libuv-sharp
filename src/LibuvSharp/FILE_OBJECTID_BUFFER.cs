using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class FILE_OBJECTID_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal fixed byte ObjectId[16];

        [FieldOffset(16)]
        internal fixed byte BirthVolumeId[16];

        [FieldOffset(32)]
        internal fixed byte BirthObjectId[16];

        [FieldOffset(48)]
        internal fixed byte DomainId[16];

        [FieldOffset(16)]
        internal fixed byte ExtendedInfo[48];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, FILE_OBJECTID_BUFFER> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, FILE_OBJECTID_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, FILE_OBJECTID_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out FILE_OBJECTID_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILE_OBJECTID_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILE_OBJECTID_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static FILE_OBJECTID_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILE_OBJECTID_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILE_OBJECTID_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILE_OBJECTID_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILE_OBJECTID_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILE_OBJECTID_BUFFER(void* native, bool skipVTables = false)
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

    public byte[] ObjectId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->ObjectId, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->ObjectId[i] = value[i];
            }
        }
    }

    public byte[] BirthVolumeId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->BirthVolumeId, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->BirthVolumeId[i] = value[i];
            }
        }
    }

    public byte[] BirthObjectId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->BirthObjectId, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->BirthObjectId[i] = value[i];
            }
        }
    }

    public byte[] DomainId
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->DomainId, 16);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 16; i++)
                    ((__Internal*)__Instance)->DomainId[i] = value[i];
            }
        }
    }

    public byte[] ExtendedInfo
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->ExtendedInfo, 48);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 48; i++)
                    ((__Internal*)__Instance)->ExtendedInfo[i] = value[i];
            }
        }
    }
}