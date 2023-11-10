using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class NTFS_STATISTICS_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 496)]
    public struct __Internal
    {
        internal uint                             LogFileFullExceptions;
        internal uint                             OtherExceptions;
        internal ulong                            MftReads;
        internal ulong                            MftReadBytes;
        internal ulong                            MftWrites;
        internal ulong                            MftWriteBytes;
        internal MftWritesUserLevel.__Internal    MftWritesUserLevel;
        internal uint                             MftWritesFlushForLogFileFull;
        internal uint                             MftWritesLazyWriter;
        internal uint                             MftWritesUserRequest;
        internal ulong                            Mft2Writes;
        internal ulong                            Mft2WriteBytes;
        internal Mft2WritesUserLevel.__Internal   Mft2WritesUserLevel;
        internal uint                             Mft2WritesFlushForLogFileFull;
        internal uint                             Mft2WritesLazyWriter;
        internal uint                             Mft2WritesUserRequest;
        internal ulong                            RootIndexReads;
        internal ulong                            RootIndexReadBytes;
        internal ulong                            RootIndexWrites;
        internal ulong                            RootIndexWriteBytes;
        internal ulong                            BitmapReads;
        internal ulong                            BitmapReadBytes;
        internal ulong                            BitmapWrites;
        internal ulong                            BitmapWriteBytes;
        internal uint                             BitmapWritesFlushForLogFileFull;
        internal uint                             BitmapWritesLazyWriter;
        internal uint                             BitmapWritesUserRequest;
        internal BitmapWritesUserLevel.__Internal BitmapWritesUserLevel;
        internal ulong                            MftBitmapReads;
        internal ulong                            MftBitmapReadBytes;
        internal ulong                            MftBitmapWrites;
        internal ulong                            MftBitmapWriteBytes;
        internal uint                             MftBitmapWritesFlushForLogFileFull;
        internal uint                             MftBitmapWritesLazyWriter;
        internal uint                             MftBitmapWritesUserRequest;
        internal MftBitmapWritesUserLevel.__Internal                       MftBitmapWritesUserLevel;
        internal ulong                            UserIndexReads;
        internal ulong                            UserIndexReadBytes;
        internal ulong                            UserIndexWrites;
        internal ulong                            UserIndexWriteBytes;
        internal ulong                            LogFileReads;
        internal ulong                            LogFileReadBytes;
        internal ulong                            LogFileWrites;
        internal ulong                            LogFileWriteBytes;
        internal Allocate.__Internal                       Allocate;
        internal uint                             DiskResourcesExhausted;
        internal ulong                            VolumeTrimCount;
        internal ulong                            VolumeTrimTime;
        internal ulong                            VolumeTrimByteCount;
        internal ulong                            FileLevelTrimCount;
        internal ulong                            FileLevelTrimTime;
        internal ulong                            FileLevelTrimByteCount;
        internal ulong                            VolumeTrimSkippedCount;
        internal ulong                            VolumeTrimSkippedByteCount;
        internal ulong                            NtfsFillStatInfoFromMftRecordCalledCount;
        internal ulong                            NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount;
        internal ulong                            NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount;
    }

    public partial class MftWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal uint Write;
            internal uint Create;
            internal uint SetInfo;
            internal uint Flush;
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

        public uint Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public uint Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public uint SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public uint Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class Mft2WritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal uint Write;
            internal uint Create;
            internal uint SetInfo;
            internal uint Flush;
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

        public uint Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public uint Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public uint SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public uint Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class BitmapWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal uint Write;
            internal uint Create;
            internal uint SetInfo;
            internal uint Flush;
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

        public uint Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public uint Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public uint SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public uint Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class MftBitmapWritesUserLevel : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal uint Write;
            internal uint Create;
            internal uint SetInfo;
            internal uint Flush;
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

        public uint Write
        {
            get => ((__Internal*)__Instance)->Write;

            set => ((__Internal*)__Instance)->Write = value;
        }

        public uint Create
        {
            get => ((__Internal*)__Instance)->Create;

            set => ((__Internal*)__Instance)->Create = value;
        }

        public uint SetInfo
        {
            get => ((__Internal*)__Instance)->SetInfo;

            set => ((__Internal*)__Instance)->SetInfo = value;
        }

        public uint Flush
        {
            get => ((__Internal*)__Instance)->Flush;

            set => ((__Internal*)__Instance)->Flush = value;
        }
    }

    public partial class Allocate : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 56)]
        public struct __Internal
        {
            internal uint  Calls;
            internal uint  RunsReturned;
            internal uint  Hints;
            internal uint  HintsHonored;
            internal uint  Cache;
            internal uint  CacheMiss;
            internal ulong Clusters;
            internal ulong HintsClusters;
            internal ulong CacheClusters;
            internal ulong CacheMissClusters;
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

        public uint RunsReturned
        {
            get => ((__Internal*)__Instance)->RunsReturned;

            set => ((__Internal*)__Instance)->RunsReturned = value;
        }

        public uint Hints
        {
            get => ((__Internal*)__Instance)->Hints;

            set => ((__Internal*)__Instance)->Hints = value;
        }

        public uint HintsHonored
        {
            get => ((__Internal*)__Instance)->HintsHonored;

            set => ((__Internal*)__Instance)->HintsHonored = value;
        }

        public uint Cache
        {
            get => ((__Internal*)__Instance)->Cache;

            set => ((__Internal*)__Instance)->Cache = value;
        }

        public uint CacheMiss
        {
            get => ((__Internal*)__Instance)->CacheMiss;

            set => ((__Internal*)__Instance)->CacheMiss = value;
        }

        public ulong Clusters
        {
            get => ((__Internal*)__Instance)->Clusters;

            set => ((__Internal*)__Instance)->Clusters = value;
        }

        public ulong HintsClusters
        {
            get => ((__Internal*)__Instance)->HintsClusters;

            set => ((__Internal*)__Instance)->HintsClusters = value;
        }

        public ulong CacheClusters
        {
            get => ((__Internal*)__Instance)->CacheClusters;

            set => ((__Internal*)__Instance)->CacheClusters = value;
        }

        public ulong CacheMissClusters
        {
            get => ((__Internal*)__Instance)->CacheMissClusters;

            set => ((__Internal*)__Instance)->CacheMissClusters = value;
        }
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, NTFS_STATISTICS_EX> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, NTFS_STATISTICS_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, NTFS_STATISTICS_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out NTFS_STATISTICS_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static NTFS_STATISTICS_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new NTFS_STATISTICS_EX(native.ToPointer(), skipVTables);
    }

    internal static NTFS_STATISTICS_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (NTFS_STATISTICS_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static NTFS_STATISTICS_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new NTFS_STATISTICS_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private NTFS_STATISTICS_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected NTFS_STATISTICS_EX(void* native, bool skipVTables = false)
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

    public ulong MftReads
    {
        get => ((__Internal*)__Instance)->MftReads;

        set => ((__Internal*)__Instance)->MftReads = value;
    }

    public ulong MftReadBytes
    {
        get => ((__Internal*)__Instance)->MftReadBytes;

        set => ((__Internal*)__Instance)->MftReadBytes = value;
    }

    public ulong MftWrites
    {
        get => ((__Internal*)__Instance)->MftWrites;

        set => ((__Internal*)__Instance)->MftWrites = value;
    }

    public ulong MftWriteBytes
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

    public uint MftWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->MftWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->MftWritesFlushForLogFileFull = value;
    }

    public uint MftWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->MftWritesLazyWriter;

        set => ((__Internal*)__Instance)->MftWritesLazyWriter = value;
    }

    public uint MftWritesUserRequest
    {
        get => ((__Internal*)__Instance)->MftWritesUserRequest;

        set => ((__Internal*)__Instance)->MftWritesUserRequest = value;
    }

    public ulong Mft2Writes
    {
        get => ((__Internal*)__Instance)->Mft2Writes;

        set => ((__Internal*)__Instance)->Mft2Writes = value;
    }

    public ulong Mft2WriteBytes
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

    public uint Mft2WritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->Mft2WritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->Mft2WritesFlushForLogFileFull = value;
    }

    public uint Mft2WritesLazyWriter
    {
        get => ((__Internal*)__Instance)->Mft2WritesLazyWriter;

        set => ((__Internal*)__Instance)->Mft2WritesLazyWriter = value;
    }

    public uint Mft2WritesUserRequest
    {
        get => ((__Internal*)__Instance)->Mft2WritesUserRequest;

        set => ((__Internal*)__Instance)->Mft2WritesUserRequest = value;
    }

    public ulong RootIndexReads
    {
        get => ((__Internal*)__Instance)->RootIndexReads;

        set => ((__Internal*)__Instance)->RootIndexReads = value;
    }

    public ulong RootIndexReadBytes
    {
        get => ((__Internal*)__Instance)->RootIndexReadBytes;

        set => ((__Internal*)__Instance)->RootIndexReadBytes = value;
    }

    public ulong RootIndexWrites
    {
        get => ((__Internal*)__Instance)->RootIndexWrites;

        set => ((__Internal*)__Instance)->RootIndexWrites = value;
    }

    public ulong RootIndexWriteBytes
    {
        get => ((__Internal*)__Instance)->RootIndexWriteBytes;

        set => ((__Internal*)__Instance)->RootIndexWriteBytes = value;
    }

    public ulong BitmapReads
    {
        get => ((__Internal*)__Instance)->BitmapReads;

        set => ((__Internal*)__Instance)->BitmapReads = value;
    }

    public ulong BitmapReadBytes
    {
        get => ((__Internal*)__Instance)->BitmapReadBytes;

        set => ((__Internal*)__Instance)->BitmapReadBytes = value;
    }

    public ulong BitmapWrites
    {
        get => ((__Internal*)__Instance)->BitmapWrites;

        set => ((__Internal*)__Instance)->BitmapWrites = value;
    }

    public ulong BitmapWriteBytes
    {
        get => ((__Internal*)__Instance)->BitmapWriteBytes;

        set => ((__Internal*)__Instance)->BitmapWriteBytes = value;
    }

    public uint BitmapWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->BitmapWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->BitmapWritesFlushForLogFileFull = value;
    }

    public uint BitmapWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->BitmapWritesLazyWriter;

        set => ((__Internal*)__Instance)->BitmapWritesLazyWriter = value;
    }

    public uint BitmapWritesUserRequest
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

    public ulong MftBitmapReads
    {
        get => ((__Internal*)__Instance)->MftBitmapReads;

        set => ((__Internal*)__Instance)->MftBitmapReads = value;
    }

    public ulong MftBitmapReadBytes
    {
        get => ((__Internal*)__Instance)->MftBitmapReadBytes;

        set => ((__Internal*)__Instance)->MftBitmapReadBytes = value;
    }

    public ulong MftBitmapWrites
    {
        get => ((__Internal*)__Instance)->MftBitmapWrites;

        set => ((__Internal*)__Instance)->MftBitmapWrites = value;
    }

    public ulong MftBitmapWriteBytes
    {
        get => ((__Internal*)__Instance)->MftBitmapWriteBytes;

        set => ((__Internal*)__Instance)->MftBitmapWriteBytes = value;
    }

    public uint MftBitmapWritesFlushForLogFileFull
    {
        get => ((__Internal*)__Instance)->MftBitmapWritesFlushForLogFileFull;

        set => ((__Internal*)__Instance)->MftBitmapWritesFlushForLogFileFull = value;
    }

    public uint MftBitmapWritesLazyWriter
    {
        get => ((__Internal*)__Instance)->MftBitmapWritesLazyWriter;

        set => ((__Internal*)__Instance)->MftBitmapWritesLazyWriter = value;
    }

    public uint MftBitmapWritesUserRequest
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

    public ulong UserIndexReads
    {
        get => ((__Internal*)__Instance)->UserIndexReads;

        set => ((__Internal*)__Instance)->UserIndexReads = value;
    }

    public ulong UserIndexReadBytes
    {
        get => ((__Internal*)__Instance)->UserIndexReadBytes;

        set => ((__Internal*)__Instance)->UserIndexReadBytes = value;
    }

    public ulong UserIndexWrites
    {
        get => ((__Internal*)__Instance)->UserIndexWrites;

        set => ((__Internal*)__Instance)->UserIndexWrites = value;
    }

    public ulong UserIndexWriteBytes
    {
        get => ((__Internal*)__Instance)->UserIndexWriteBytes;

        set => ((__Internal*)__Instance)->UserIndexWriteBytes = value;
    }

    public ulong LogFileReads
    {
        get => ((__Internal*)__Instance)->LogFileReads;

        set => ((__Internal*)__Instance)->LogFileReads = value;
    }

    public ulong LogFileReadBytes
    {
        get => ((__Internal*)__Instance)->LogFileReadBytes;

        set => ((__Internal*)__Instance)->LogFileReadBytes = value;
    }

    public ulong LogFileWrites
    {
        get => ((__Internal*)__Instance)->LogFileWrites;

        set => ((__Internal*)__Instance)->LogFileWrites = value;
    }

    public ulong LogFileWriteBytes
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

    public ulong VolumeTrimCount
    {
        get => ((__Internal*)__Instance)->VolumeTrimCount;

        set => ((__Internal*)__Instance)->VolumeTrimCount = value;
    }

    public ulong VolumeTrimTime
    {
        get => ((__Internal*)__Instance)->VolumeTrimTime;

        set => ((__Internal*)__Instance)->VolumeTrimTime = value;
    }

    public ulong VolumeTrimByteCount
    {
        get => ((__Internal*)__Instance)->VolumeTrimByteCount;

        set => ((__Internal*)__Instance)->VolumeTrimByteCount = value;
    }

    public ulong FileLevelTrimCount
    {
        get => ((__Internal*)__Instance)->FileLevelTrimCount;

        set => ((__Internal*)__Instance)->FileLevelTrimCount = value;
    }

    public ulong FileLevelTrimTime
    {
        get => ((__Internal*)__Instance)->FileLevelTrimTime;

        set => ((__Internal*)__Instance)->FileLevelTrimTime = value;
    }

    public ulong FileLevelTrimByteCount
    {
        get => ((__Internal*)__Instance)->FileLevelTrimByteCount;

        set => ((__Internal*)__Instance)->FileLevelTrimByteCount = value;
    }

    public ulong VolumeTrimSkippedCount
    {
        get => ((__Internal*)__Instance)->VolumeTrimSkippedCount;

        set => ((__Internal*)__Instance)->VolumeTrimSkippedCount = value;
    }

    public ulong VolumeTrimSkippedByteCount
    {
        get => ((__Internal*)__Instance)->VolumeTrimSkippedByteCount;

        set => ((__Internal*)__Instance)->VolumeTrimSkippedByteCount = value;
    }

    public ulong NtfsFillStatInfoFromMftRecordCalledCount
    {
        get => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordCalledCount;

        set => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordCalledCount = value;
    }

    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount
    {
        get => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount;

        set => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount = value;
    }

    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount
    {
        get => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount;

        set => ((__Internal*)__Instance)->NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount = value;
    }
}