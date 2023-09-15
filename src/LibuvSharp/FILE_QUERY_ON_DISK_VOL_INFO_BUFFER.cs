using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class FILE_QUERY_ON_DISK_VOL_INFO_BUFFER : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 336)]
    public partial struct __Internal
    {
        internal       global::LARGE_INTEGER.__Internal DirectoryCount;
        internal       global::LARGE_INTEGER.__Internal FileCount;
        internal       ushort                           FsFormatMajVersion;
        internal       ushort                           FsFormatMinVersion;
        internal fixed char                             FsFormatName[12];
        internal       global::LARGE_INTEGER.__Internal FormatTime;
        internal       global::LARGE_INTEGER.__Internal LastUpdateTime;
        internal fixed char                             CopyrightInfo[34];
        internal fixed char                             AbstractInfo[34];
        internal fixed char                             FormattingImplementationInfo[34];
        internal fixed char                             LastModifyingImplementationInfo[34];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_QUERY_ON_DISK_VOL_INFO_BUFFER> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.FILE_QUERY_ON_DISK_VOL_INFO_BUFFER>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.FILE_QUERY_ON_DISK_VOL_INFO_BUFFER managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.FILE_QUERY_ON_DISK_VOL_INFO_BUFFER managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FILE_QUERY_ON_DISK_VOL_INFO_BUFFER __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FILE_QUERY_ON_DISK_VOL_INFO_BUFFER(native.ToPointer(), skipVTables);
    }

    internal static FILE_QUERY_ON_DISK_VOL_INFO_BUFFER __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FILE_QUERY_ON_DISK_VOL_INFO_BUFFER)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FILE_QUERY_ON_DISK_VOL_INFO_BUFFER __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FILE_QUERY_ON_DISK_VOL_INFO_BUFFER(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FILE_QUERY_ON_DISK_VOL_INFO_BUFFER(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FILE_QUERY_ON_DISK_VOL_INFO_BUFFER(void* native, bool skipVTables = false)
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

    public ushort FsFormatMajVersion
    {
        get => ((__Internal*)__Instance)->FsFormatMajVersion;

        set => ((__Internal*)__Instance)->FsFormatMajVersion = value;
    }

    public ushort FsFormatMinVersion
    {
        get => ((__Internal*)__Instance)->FsFormatMinVersion;

        set => ((__Internal*)__Instance)->FsFormatMinVersion = value;
    }

    public char[] FsFormatName
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->FsFormatName, 12);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 12; i++)
                    ((__Internal*)__Instance)->FsFormatName[i] = value[i];
            }
        }
    }

    public char[] CopyrightInfo
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->CopyrightInfo, 34);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 34; i++)
                    ((__Internal*)__Instance)->CopyrightInfo[i] = value[i];
            }
        }
    }

    public char[] AbstractInfo
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->AbstractInfo, 34);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 34; i++)
                    ((__Internal*)__Instance)->AbstractInfo[i] = value[i];
            }
        }
    }

    public char[] FormattingImplementationInfo
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->FormattingImplementationInfo, 34);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 34; i++)
                    ((__Internal*)__Instance)->FormattingImplementationInfo[i] = value[i];
            }
        }
    }

    public char[] LastModifyingImplementationInfo
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->LastModifyingImplementationInfo, 34);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 34; i++)
                    ((__Internal*)__Instance)->LastModifyingImplementationInfo[i] = value[i];
            }
        }
    }
}