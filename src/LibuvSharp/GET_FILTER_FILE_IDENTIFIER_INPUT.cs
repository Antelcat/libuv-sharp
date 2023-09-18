using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class GET_FILTER_FILE_IDENTIFIER_INPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct __Internal
    {
        internal       ushort AltitudeLength;
        internal fixed char   Altitude[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, GET_FILTER_FILE_IDENTIFIER_INPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, GET_FILTER_FILE_IDENTIFIER_INPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, GET_FILTER_FILE_IDENTIFIER_INPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out GET_FILTER_FILE_IDENTIFIER_INPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static GET_FILTER_FILE_IDENTIFIER_INPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new GET_FILTER_FILE_IDENTIFIER_INPUT(native.ToPointer(), skipVTables);
    }

    internal static GET_FILTER_FILE_IDENTIFIER_INPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (GET_FILTER_FILE_IDENTIFIER_INPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static GET_FILTER_FILE_IDENTIFIER_INPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new GET_FILTER_FILE_IDENTIFIER_INPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private GET_FILTER_FILE_IDENTIFIER_INPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected GET_FILTER_FILE_IDENTIFIER_INPUT(void* native, bool skipVTables = false)
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

    public ushort AltitudeLength
    {
        get => ((__Internal*)__Instance)->AltitudeLength;

        set => ((__Internal*)__Instance)->AltitudeLength = value;
    }

    public char[] Altitude
    {
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->Altitude, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->Altitude[i] = value[i];
            }
        }
    }
}