using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class ENCRYPTION_KEY_CTRL_INPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal uint   HeaderSize;
        internal uint   StructureSize;
        internal ushort KeyOffset;
        internal ushort KeySize;
        internal uint   DplLock;
        internal ulong  DplUserId;
        internal ulong  DplCredentialId;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, ENCRYPTION_KEY_CTRL_INPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, ENCRYPTION_KEY_CTRL_INPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, ENCRYPTION_KEY_CTRL_INPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out ENCRYPTION_KEY_CTRL_INPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static ENCRYPTION_KEY_CTRL_INPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new ENCRYPTION_KEY_CTRL_INPUT(native.ToPointer(), skipVTables);
    }

    internal static ENCRYPTION_KEY_CTRL_INPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (ENCRYPTION_KEY_CTRL_INPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static ENCRYPTION_KEY_CTRL_INPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new ENCRYPTION_KEY_CTRL_INPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private ENCRYPTION_KEY_CTRL_INPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected ENCRYPTION_KEY_CTRL_INPUT(void* native, bool skipVTables = false)
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

    public uint HeaderSize
    {
        get => ((__Internal*)__Instance)->HeaderSize;

        set => ((__Internal*)__Instance)->HeaderSize = value;
    }

    public uint StructureSize
    {
        get => ((__Internal*)__Instance)->StructureSize;

        set => ((__Internal*)__Instance)->StructureSize = value;
    }

    public ushort KeyOffset
    {
        get => ((__Internal*)__Instance)->KeyOffset;

        set => ((__Internal*)__Instance)->KeyOffset = value;
    }

    public ushort KeySize
    {
        get => ((__Internal*)__Instance)->KeySize;

        set => ((__Internal*)__Instance)->KeySize = value;
    }

    public uint DplLock
    {
        get => ((__Internal*)__Instance)->DplLock;

        set => ((__Internal*)__Instance)->DplLock = value;
    }

    public ulong DplUserId
    {
        get => ((__Internal*)__Instance)->DplUserId;

        set => ((__Internal*)__Instance)->DplUserId = value;
    }

    public ulong DplCredentialId
    {
        get => ((__Internal*)__Instance)->DplCredentialId;

        set => ((__Internal*)__Instance)->DplCredentialId = value;
    }
}