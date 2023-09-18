using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class TXFS_READ_BACKUP_INFORMATION_OUT : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal uint BufferLength;

        [FieldOffset(0)]
        internal fixed byte Buffer[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TXFS_READ_BACKUP_INFORMATION_OUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TXFS_READ_BACKUP_INFORMATION_OUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TXFS_READ_BACKUP_INFORMATION_OUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TXFS_READ_BACKUP_INFORMATION_OUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_READ_BACKUP_INFORMATION_OUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_READ_BACKUP_INFORMATION_OUT(native.ToPointer(), skipVTables);
    }

    internal static TXFS_READ_BACKUP_INFORMATION_OUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_READ_BACKUP_INFORMATION_OUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_READ_BACKUP_INFORMATION_OUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_READ_BACKUP_INFORMATION_OUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_READ_BACKUP_INFORMATION_OUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_READ_BACKUP_INFORMATION_OUT(void* native, bool skipVTables = false)
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

    public uint BufferLength
    {
        get => ((__Internal*)__Instance)->BufferLength;

        set => ((__Internal*)__Instance)->BufferLength = value;
    }

    public byte[] Buffer
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->Buffer, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->Buffer[i] = value[i];
            }
        }
    }
}