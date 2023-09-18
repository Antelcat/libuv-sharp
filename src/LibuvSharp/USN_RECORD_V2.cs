using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class USN_RECORD_V2 : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 64)]
    public struct __Internal
    {
        internal       uint                     RecordLength;
        internal       ushort                   MajorVersion;
        internal       ushort                   MinorVersion;
        internal       ulong                    FileReferenceNumber;
        internal       ulong                    ParentFileReferenceNumber;
        internal       long                     Usn;
        internal       LARGE_INTEGER.__Internal TimeStamp;
        internal       uint                     Reason;
        internal       uint                     SourceInfo;
        internal       uint                     SecurityId;
        internal       uint                     FileAttributes;
        internal       ushort                   FileNameLength;
        internal       ushort                   FileNameOffset;
        internal fixed char                     FileName[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, USN_RECORD_V2> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, USN_RECORD_V2>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, USN_RECORD_V2 managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out USN_RECORD_V2 managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static USN_RECORD_V2 __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new USN_RECORD_V2(native.ToPointer(), skipVTables);
    }

    internal static USN_RECORD_V2 __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (USN_RECORD_V2)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static USN_RECORD_V2 __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new USN_RECORD_V2(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private USN_RECORD_V2(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected USN_RECORD_V2(void* native, bool skipVTables = false)
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

    public ulong FileReferenceNumber
    {
        get => ((__Internal*)__Instance)->FileReferenceNumber;

        set => ((__Internal*)__Instance)->FileReferenceNumber = value;
    }

    public ulong ParentFileReferenceNumber
    {
        get => ((__Internal*)__Instance)->ParentFileReferenceNumber;

        set => ((__Internal*)__Instance)->ParentFileReferenceNumber = value;
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
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->FileName, 1);

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