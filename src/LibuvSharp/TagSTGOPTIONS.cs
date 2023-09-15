using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagSTGOPTIONS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16, Pack = 8)]
    public partial struct __Internal
    {
        internal ushort   usVersion;
        internal ushort   reserved;
        internal uint     ulSectorSize;
        internal IntPtr pwcsTemplateFile;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagSTGOPTIONS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagSTGOPTIONS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TagSTGOPTIONS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TagSTGOPTIONS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __pwcsTemplateFile_OwnsNativeMemory = false;
    protected bool __ownsNativeInstance;

    internal static TagSTGOPTIONS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagSTGOPTIONS(native.ToPointer(), skipVTables);
    }

    internal static TagSTGOPTIONS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagSTGOPTIONS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagSTGOPTIONS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagSTGOPTIONS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagSTGOPTIONS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagSTGOPTIONS(void* native, bool skipVTables = false)
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
        if (__pwcsTemplateFile_OwnsNativeMemory)
            Marshal.FreeHGlobal(((__Internal*)__Instance)->pwcsTemplateFile);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public ushort UsVersion
    {
        get => ((__Internal*)__Instance)->usVersion;

        set => ((__Internal*)__Instance)->usVersion = value;
    }

    public ushort Reserved
    {
        get => ((__Internal*)__Instance)->reserved;

        set => ((__Internal*)__Instance)->reserved = value;
    }

    public uint UlSectorSize
    {
        get => ((__Internal*)__Instance)->ulSectorSize;

        set => ((__Internal*)__Instance)->ulSectorSize = value;
    }

    public string PwcsTemplateFile
    {
        get => CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.Unicode, ((__Internal*)__Instance)->pwcsTemplateFile);

        set
        {
            if (__pwcsTemplateFile_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->pwcsTemplateFile);
            __pwcsTemplateFile_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->pwcsTemplateFile = global::System.IntPtr.Zero;
                return;
            }
            var __bytePtr0 = Marshal.StringToHGlobalUni(value);
            ((__Internal*)__Instance)->pwcsTemplateFile = (IntPtr) __bytePtr0;
        }
    }
}