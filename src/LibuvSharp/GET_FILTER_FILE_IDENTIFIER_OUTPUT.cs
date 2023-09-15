using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class GET_FILTER_FILE_IDENTIFIER_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public partial struct __Internal
    {
        internal       ushort FilterFileIdentifierLength;
        internal fixed byte   FilterFileIdentifier[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_FILTER_FILE_IDENTIFIER_OUTPUT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.GET_FILTER_FILE_IDENTIFIER_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.GET_FILTER_FILE_IDENTIFIER_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.GET_FILTER_FILE_IDENTIFIER_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static GET_FILTER_FILE_IDENTIFIER_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new GET_FILTER_FILE_IDENTIFIER_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static GET_FILTER_FILE_IDENTIFIER_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (GET_FILTER_FILE_IDENTIFIER_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static GET_FILTER_FILE_IDENTIFIER_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new GET_FILTER_FILE_IDENTIFIER_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private GET_FILTER_FILE_IDENTIFIER_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected GET_FILTER_FILE_IDENTIFIER_OUTPUT(void* native, bool skipVTables = false)
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

    public ushort FilterFileIdentifierLength
    {
        get => ((__Internal*)__Instance)->FilterFileIdentifierLength;

        set => ((__Internal*)__Instance)->FilterFileIdentifierLength = value;
    }

    public byte[] FilterFileIdentifier
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->FilterFileIdentifier, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->FilterFileIdentifier[i] = value[i];
            }
        }
    }
}