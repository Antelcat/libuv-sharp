using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_GET_METADATA_INFO_OUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 48)]
    public struct __Internal
    {
        internal TxfFileId.__Internal TxfFileId;
        internal GUID.__Internal      LockingTransaction;
        internal ulong                LastLsn;
        internal uint                 TransactionState;
    }

    public partial class TxfFileId : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal long LowPart;
            internal long HighPart;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, TxfFileId> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, TxfFileId>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, TxfFileId managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TxfFileId managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static TxfFileId __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new TxfFileId(native.ToPointer(), skipVTables);
        }

        internal static TxfFileId __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (TxfFileId)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static TxfFileId __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new TxfFileId(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private TxfFileId(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected TxfFileId(void* native, bool skipVTables = false)
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

        public long LowPart
        {
            get => ((__Internal*)__Instance)->LowPart;

            set => ((__Internal*)__Instance)->LowPart = value;
        }

        public long HighPart
        {
            get => ((__Internal*)__Instance)->HighPart;

            set => ((__Internal*)__Instance)->HighPart = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, TXFS_GET_METADATA_INFO_OUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, TXFS_GET_METADATA_INFO_OUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, TXFS_GET_METADATA_INFO_OUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out TXFS_GET_METADATA_INFO_OUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_GET_METADATA_INFO_OUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_GET_METADATA_INFO_OUT(native.ToPointer(), skipVTables);
    }

    internal static TXFS_GET_METADATA_INFO_OUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_GET_METADATA_INFO_OUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_GET_METADATA_INFO_OUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_GET_METADATA_INFO_OUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_GET_METADATA_INFO_OUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_GET_METADATA_INFO_OUT(void* native, bool skipVTables = false)
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

    public TxfFileId txfFileId
    {
        get => TxfFileId.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->TxfFileId));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->TxfFileId = *(TxfFileId.__Internal*) value.__Instance;
        }
    }

    public ulong LastLsn
    {
        get => ((__Internal*)__Instance)->LastLsn;

        set => ((__Internal*)__Instance)->LastLsn = value;
    }

    public uint TransactionState
    {
        get => ((__Internal*)__Instance)->TransactionState;

        set => ((__Internal*)__Instance)->TransactionState = value;
    }
}