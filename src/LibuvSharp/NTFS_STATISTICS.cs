using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class NTFS_STATISTICS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 216)]
    public struct __Internal
    {
        internal uint                                LogFileFullExceptions;
        internal uint                                OtherExceptions;
        internal uint                                MftReads;
        internal uint                                MftReadBytes;
        internal uint                                MftWrites;
        internal uint                                MftWriteBytes;
        internal MftWritesUserLevel.__Internal       MftWritesUserLevel;
        internal ushort                              MftWritesFlushForLogFileFull;
        internal ushort                              MftWritesLazyWriter;
        internal ushort                              MftWritesUserRequest;
        internal uint                                Mft2Writes;
        internal uint                                Mft2WriteBytes;
        internal Mft2WritesUserLevel.__Internal      Mft2WritesUserLevel;
        internal ushort                              Mft2WritesFlushForLogFileFull;
        internal ushort                              Mft2WritesLazyWriter;
        internal ushort                              Mft2WritesUserRequest;
        internal uint                                RootIndexReads;
        internal uint                                RootIndexReadBytes;
        internal uint                                RootIndexWrites;
        internal uint                                RootIndexWriteBytes;
        internal uint                                BitmapReads;
        internal uint                                BitmapReadBytes;
        internal uint                                BitmapWrites;
        internal uint                                BitmapWriteBytes;
        internal ushort                              BitmapWritesFlushForLogFileFull;
        internal ushort                              BitmapWritesLazyWriter;
        internal ushort                              BitmapWritesUserRequest;
        internal BitmapWritesUserLevel.__Internal    BitmapWritesUserLevel;
        internal uint                                MftBitmapReads;
        internal uint                                MftBitmapReadBytes;
        internal uint                                MftBitmapWrites;
        internal uint                                MftBitmapWriteBytes;
        internal ushort                              MftBitmapWritesFlushForLogFileFull;
        internal ushort                              MftBitmapWritesLazyWriter;
        internal ushort                              MftBitmapWritesUserRequest;
        internal MftBitmapWritesUserLevel.__Internal MftBitmapWritesUserLevel;
        internal uint                                UserIndexReads;
        internal uint                                UserIndexReadBytes;
        internal uint                                UserIndexWrites;
        internal uint                                UserIndexWriteBytes;
        internal uint                                LogFileReads;
        internal uint                                LogFileReadBytes;
        internal uint                                LogFileWrites;
        internal uint                                LogFileWriteBytes;
        internal Allocate.__Internal                 Allocate;
        internal uint                                DiskResourcesExhausted;
    }

    public partial class MftWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct __Internal
        {
            internal ushort Write;
            internal ushort Create;
            internal ushort SetInfo;
            internal ushort Flush;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, MftWritesUserLevel> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, MftWritesUserLevel>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, MftWritesUserLevel managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MftWritesUserLevel managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static MftWritesUserLevel __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new MftWritesUserLevel(native.ToPointer(), skipVTables);
        }

        internal static MftWritesUserLevel __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (MftWritesUserLevel)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static MftWritesUserLevel __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new MftWritesUserLevel(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MftWritesUserLevel(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected MftWritesUserLevel(void* native, bool skipVTables = false)
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

        public ushort Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public ushort Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public ushort SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public ushort Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class Mft2WritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct __Internal
        {
            internal ushort Write;
            internal ushort Create;
            internal ushort SetInfo;
            internal ushort Flush;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, Mft2WritesUserLevel> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, Mft2WritesUserLevel>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, Mft2WritesUserLevel managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Mft2WritesUserLevel managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Mft2WritesUserLevel __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new Mft2WritesUserLevel(native.ToPointer(), skipVTables);
        }

        internal static Mft2WritesUserLevel __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Mft2WritesUserLevel)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Mft2WritesUserLevel __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Mft2WritesUserLevel(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Mft2WritesUserLevel(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Mft2WritesUserLevel(void* native, bool skipVTables = false)
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

        public ushort Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public ushort Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public ushort SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public ushort Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class BitmapWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 6)]
        public struct __Internal
        {
            internal ushort Write;
            internal ushort Create;
            internal ushort SetInfo;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, BitmapWritesUserLevel> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, BitmapWritesUserLevel>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, BitmapWritesUserLevel managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out BitmapWritesUserLevel managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static BitmapWritesUserLevel __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new BitmapWritesUserLevel(native.ToPointer(), skipVTables);
        }

        internal static BitmapWritesUserLevel __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (BitmapWritesUserLevel)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static BitmapWritesUserLevel __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new BitmapWritesUserLevel(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private BitmapWritesUserLevel(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected BitmapWritesUserLevel(void* native, bool skipVTables = false)
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

        public ushort Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public ushort Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public ushort SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }
    }

    public partial class MftBitmapWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct __Internal
        {
            internal ushort Write;
            internal ushort Create;
            internal ushort SetInfo;
            internal ushort Flush;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, MftBitmapWritesUserLevel> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, MftBitmapWritesUserLevel>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, MftBitmapWritesUserLevel managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MftBitmapWritesUserLevel managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static MftBitmapWritesUserLevel __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new MftBitmapWritesUserLevel(native.ToPointer(), skipVTables);
        }

        internal static MftBitmapWritesUserLevel __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (MftBitmapWritesUserLevel)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static MftBitmapWritesUserLevel __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new MftBitmapWritesUserLevel(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MftBitmapWritesUserLevel(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected MftBitmapWritesUserLevel(void* native, bool skipVTables = false)
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

        public ushort Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public ushort Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public ushort SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public ushort Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class Allocate : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 40)]
        public struct __Internal
        {
            internal uint Calls;
            internal uint Clusters;
            internal uint Hints;
            internal uint RunsReturned;
            internal uint HintsHonored;
            internal uint HintsClusters;
            internal uint Cache;
            internal uint CacheClusters;
            internal uint CacheMiss;
            internal uint CacheMissClusters;
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, Allocate> NativeToManagedMap =
            new ConcurrentDictionary<IntPtr, Allocate>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, Allocate managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out Allocate managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Allocate __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            return new Allocate(native.ToPointer(), skipVTables);
        }

        internal static Allocate __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Allocate)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Allocate __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Allocate(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Allocate(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Allocate(void* native, bool skipVTables = false)
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

        public uint Calls
        {
            get => ((__Internal*)__Instance)->Calls;

            set => ((__Internal*)__Instance)->Calls = value;
        }

        public uint Clusters
        {
            get => ((__Internal*)__Instance)->Clusters;

            set => ((__Internal*)__Instance)->Clusters = value;
        }

        public uint Hints
        {
            get => ((__Internal*)__Instance)->Hints;

            set => ((__Internal*)__Instance)->Hints = value;
        }

        public uint RunsReturned
        {
            get => ((__Internal*)__Instance)->RunsReturned;

            set => ((__Internal*)__Instance)->RunsReturned = value;
        }

        public uint HintsHonored
        {
            get => ((__Internal*)__Instance)->HintsHonored;

            set => ((__Internal*)__Instance)->HintsHonored = value;
        }

        public uint HintsClusters
        {
            get => ((__Internal*)__Instance)->HintsClusters;

            set => ((__Internal*)__Instance)->HintsClusters = value;
        }

        public uint Cache
        {
            get => ((__Internal*)__Instance)->Cache;

            set => ((__Internal*)__Instance)->Cache = value;
        }

        public uint CacheClusters
        {
            get => ((__Internal*)__Instance)->CacheClusters;

            set => ((__Internal*)__Instance)->CacheClusters = value;
        }

        public uint CacheMiss
        {
            get => ((__Internal*)__Instance)->CacheMiss;

            set => ((__Internal*)__Instance)->CacheMiss = value;
        }

        public uint CacheMissClusters
        {
            get => ((__Internal*)__Instance)->CacheMissClusters;

            set => ((__Internal*)__Instance)->CacheMissClusters = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, NTFS_STATISTICS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, NTFS_STATISTICS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, NTFS_STATISTICS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out NTFS_STATISTICS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static NTFS_STATISTICS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new NTFS_STATISTICS(native.ToPointer(), skipVTables);
    }

    internal static NTFS_STATISTICS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (NTFS_STATISTICS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static NTFS_STATISTICS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new NTFS_STATISTICS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private NTFS_STATISTICS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected NTFS_STATISTICS(void* native, bool skipVTables = false)
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

    public uint LogFileFullExceptions
    {
        get => ((__Internal*)__Instance)->LogFileFullExceptions;

        set => ((__Internal*)__Instance)->LogFileFullExceptions = value;
    }

    public uint OtherExceptions
    {
        get => ((__Internal*)__Instance)->OtherExceptions;

        set => ((__Internal*)__Instance)->OtherExceptions = value;
    }

    public uint MftReads
    {
        get => ((__Internal*)__Instance)->MftReads;

        set => ((__Internal*)__Instance)->MftReads = value;
    }

    public uint MftReadBytes
    {
        get => ((__Internal*)__Instance)->MftReadBytes;

        set => ((__Internal*)__Instance)->MftReadBytes = value;
    }

    public uint MftWrites
    {
        get => ((__Internal*)__Instance)->MftWrites;

        set => ((__Internal*)__Instance)->MftWrites = value;
    }

    public uint MftWriteBytes
    {
        get => ((__Internal*)__Instance)->MftWriteBytes;

        set => ((__Internal*)__Instance)->MftWriteBytes = value;
    }

    public MftWritesUserLevel mftWritesUserLevel
    {
        get => MftWritesUserLevel.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->MftWritesUserLevel));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->MftWritesUserLevel = *(MftWritesUserLevel.__Internal*) value.__Instance;
        }
    }

    public ushort MftWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->MftWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->MftWritesFlushForLogFileFull = value;
    }

    public ushort MftWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->MftWritesLazyWriter;

        set => ((__Internal*)__Instance)->MftWritesLazyWriter = value;
    }

    public ushort MftWritesUserRequest
    {
        get => ((__Internal*)__Instance)->MftWritesUserRequest;

        set => ((__Internal*)__Instance)->MftWritesUserRequest = value;
    }

    public uint Mft2Writes
    {
        get => ((__Internal*)__Instance)->Mft2Writes;

        set => ((__Internal*)__Instance)->Mft2Writes = value;
    }

    public uint Mft2WriteBytes
    {
        get => ((__Internal*)__Instance)->Mft2WriteBytes;

        set => ((__Internal*)__Instance)->Mft2WriteBytes = value;
    }

    public Mft2WritesUserLevel mft2WritesUserLevel
    {
        get => Mft2WritesUserLevel.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mft2WritesUserLevel));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mft2WritesUserLevel = *(Mft2WritesUserLevel.__Internal*) value.__Instance;
        }
    }

    public ushort Mft2WritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->Mft2WritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->Mft2WritesFlushForLogFileFull = value;
    }

    public ushort Mft2WritesLazyWriter
    {
        get => ((__Internal*)__Instance)->Mft2WritesLazyWriter;

        set => ((__Internal*)__Instance)->Mft2WritesLazyWriter = value;
    }

    public ushort Mft2WritesUserRequest
    {
        get => ((__Internal*)__Instance)->Mft2WritesUserRequest;

        set => ((__Internal*)__Instance)->Mft2WritesUserRequest = value;
    }

    public uint RootIndexReads
    {
        get => ((__Internal*)__Instance)->RootIndexReads;

        set => ((__Internal*)__Instance)->RootIndexReads = value;
    }

    public uint RootIndexReadBytes
    {
        get => ((__Internal*)__Instance)->RootIndexReadBytes;

        set => ((__Internal*)__Instance)->RootIndexReadBytes = value;
    }

    public uint RootIndexWrites
    {
        get => ((__Internal*)__Instance)->RootIndexWrites;

        set => ((__Internal*)__Instance)->RootIndexWrites = value;
    }

    public uint RootIndexWriteBytes
    {
        get => ((__Internal*)__Instance)->RootIndexWriteBytes;

        set => ((__Internal*)__Instance)->RootIndexWriteBytes = value;
    }

    public uint BitmapReads
    {
        get => ((__Internal*)__Instance)->BitmapReads;

        set => ((__Internal*)__Instance)->BitmapReads = value;
    }

    public uint BitmapReadBytes
    {
        get => ((__Internal*)__Instance)->BitmapReadBytes;

        set => ((__Internal*)__Instance)->BitmapReadBytes = value;
    }

    public uint BitmapWrites
    {
        get => ((__Internal*)__Instance)->BitmapWrites;

        set => ((__Internal*)__Instance)->BitmapWrites = value;
    }

    public uint BitmapWriteBytes
    {
        get => ((__Internal*)__Instance)->BitmapWriteBytes;

        set => ((__Internal*)__Instance)->BitmapWriteBytes = value;
    }

    public ushort BitmapWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->BitmapWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->BitmapWritesFlushForLogFileFull = value;
    }

    public ushort BitmapWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->BitmapWritesLazyWriter;

        set => ((__Internal*)__Instance)->BitmapWritesLazyWriter = value;
    }

    public ushort BitmapWritesUserRequest
    {
        get => ((__Internal*)__Instance)->BitmapWritesUserRequest;

        set => ((__Internal*)__Instance)->BitmapWritesUserRequest = value;
    }

    public BitmapWritesUserLevel bitmapWritesUserLevel
    {
        get => BitmapWritesUserLevel.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->BitmapWritesUserLevel));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->BitmapWritesUserLevel = *(BitmapWritesUserLevel.__Internal*) value.__Instance;
        }
    }

    public uint MftBitmapReads
    {
        get => ((__Internal*)__Instance)->MftBitmapReads;

        set => ((__Internal*)__Instance)->MftBitmapReads = value;
    }

    public uint MftBitmapReadBytes
    {
        get => ((__Internal*)__Instance)->MftBitmapReadBytes;

        set => ((__Internal*)__Instance)->MftBitmapReadBytes = value;
    }

    public uint MftBitmapWrites
    {
        get => ((__Internal*)__Instance)->MftBitmapWrites;

        set => ((__Internal*)__Instance)->MftBitmapWrites = value;
    }

    public uint MftBitmapWriteBytes
    {
        get => ((__Internal*)__Instance)->MftBitmapWriteBytes;

        set => ((__Internal*)__Instance)->MftBitmapWriteBytes = value;
    }

    public ushort MftBitmapWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->MftBitmapWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->MftBitmapWritesFlushForLogFileFull = value;
    }

    public ushort MftBitmapWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->MftBitmapWritesLazyWriter;

        set => ((__Internal*)__Instance)->MftBitmapWritesLazyWriter = value;
    }

    public ushort MftBitmapWritesUserRequest
    {
        get => ((__Internal*)__Instance)->MftBitmapWritesUserRequest;

        set => ((__Internal*)__Instance)->MftBitmapWritesUserRequest = value;
    }

    public MftBitmapWritesUserLevel mftBitmapWritesUserLevel
    {
        get => MftBitmapWritesUserLevel.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->MftBitmapWritesUserLevel));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->MftBitmapWritesUserLevel = *(MftBitmapWritesUserLevel.__Internal*) value.__Instance;
        }
    }

    public uint UserIndexReads
    {
        get => ((__Internal*)__Instance)->UserIndexReads;

        set => ((__Internal*)__Instance)->UserIndexReads = value;
    }

    public uint UserIndexReadBytes
    {
        get => ((__Internal*)__Instance)->UserIndexReadBytes;

        set => ((__Internal*)__Instance)->UserIndexReadBytes = value;
    }

    public uint UserIndexWrites
    {
        get => ((__Internal*)__Instance)->UserIndexWrites;

        set => ((__Internal*)__Instance)->UserIndexWrites = value;
    }

    public uint UserIndexWriteBytes
    {
        get => ((__Internal*)__Instance)->UserIndexWriteBytes;

        set => ((__Internal*)__Instance)->UserIndexWriteBytes = value;
    }

    public uint LogFileReads
    {
        get => ((__Internal*)__Instance)->LogFileReads;

        set => ((__Internal*)__Instance)->LogFileReads = value;
    }

    public uint LogFileReadBytes
    {
        get => ((__Internal*)__Instance)->LogFileReadBytes;

        set => ((__Internal*)__Instance)->LogFileReadBytes = value;
    }

    public uint LogFileWrites
    {
        get => ((__Internal*)__Instance)->LogFileWrites;

        set => ((__Internal*)__Instance)->LogFileWrites = value;
    }

    public uint LogFileWriteBytes
    {
        get => ((__Internal*)__Instance)->LogFileWriteBytes;

        set => ((__Internal*)__Instance)->LogFileWriteBytes = value;
    }

    public Allocate allocate
    {
        get => Allocate.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Allocate));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Allocate = *(Allocate.__Internal*) value.__Instance;
        }
    }

    public uint DiskResourcesExhausted
    {
        get => ((__Internal*)__Instance)->DiskResourcesExhausted;

        set => ((__Internal*)__Instance)->DiskResourcesExhausted = value;
    }
}