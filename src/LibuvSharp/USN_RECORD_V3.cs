using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class USN_RECORD_V3 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 80)]
    public partial struct __Internal
    {
        internal       uint                             RecordLength;
        internal       ushort                           MajorVersion;
        internal       ushort                           MinorVersion;
        internal       global::FILE_ID_128.__Internal   FileReferenceNumber;
        internal       global::FILE_ID_128.__Internal   ParentFileReferenceNumber;
        internal       long                             Usn;
        internal       global::LARGE_INTEGER.__Internal TimeStamp;
        internal       uint                             Reason;
        internal       uint                             SourceInfo;
        internal       uint                             SecurityId;
        internal       uint                             FileAttributes;
        internal       ushort                           FileNameLength;
        internal       ushort                           FileNameOffset;
        internal fixed char                             FileName[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RECORD_V3> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.USN_RECORD_V3>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.USN_RECORD_V3 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.USN_RECORD_V3 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_RECORD_V3 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_RECORD_V3(native.ToPointer(), skipVTables);
    }

    internal static USN_RECORD_V3 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_RECORD_V3)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_RECORD_V3 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RECORD_V3(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_RECORD_V3(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_RECORD_V3(void* native, bool skipVTables = false)
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

    public uint RecordLength
    {
        get => ((__Internal*)__Instance)->RecordLength;

        set => ((__Internal*)__Instance)->RecordLength = value;
    }

    public ushort MajorVersion
    {
        get => ((__Internal*)__Instance)->MajorVersion;

        set => ((__Internal*)__Instance)->MajorVersion = value;
    }

    public ushort MinorVersion
    {
        get => ((__Internal*)__Instance)->MinorVersion;

        set => ((__Internal*)__Instance)->MinorVersion = value;
    }

    public long Usn
    {
        get => ((__Internal*)__Instance)->Usn;

        set => ((__Internal*)__Instance)->Usn = value;
    }

    public uint Reason
    {
        get => ((__Internal*)__Instance)->Reason;

        set => ((__Internal*)__Instance)->Reason = value;
    }

    public uint SourceInfo
    {
        get => ((__Internal*)__Instance)->SourceInfo;

        set => ((__Internal*)__Instance)->SourceInfo = value;
    }

    public uint SecurityId
    {
        get => ((__Internal*)__Instance)->SecurityId;

        set => ((__Internal*)__Instance)->SecurityId = value;
    }

    public uint FileAttributes
    {
        get => ((__Internal*)__Instance)->FileAttributes;

        set => ((__Internal*)__Instance)->FileAttributes = value;
    }

    public ushort FileNameLength
    {
        get => ((__Internal*)__Instance)->FileNameLength;

        set => ((__Internal*)__Instance)->FileNameLength = value;
    }

    public ushort FileNameOffset
    {
        get => ((__Internal*)__Instance)->FileNameOffset;

        set => ((__Internal*)__Instance)->FileNameOffset = value;
    }

    public char[] FileName
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->FileName, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->FileName[i] = value[i];
            }
        }
    }
}