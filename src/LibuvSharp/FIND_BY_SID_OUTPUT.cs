using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class FIND_BY_SID_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal       uint NextEntryOffset;
        internal       uint FileIndex;
        internal       uint FileNameLength;
        internal fixed char FileName[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, FIND_BY_SID_OUTPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, FIND_BY_SID_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, FIND_BY_SID_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out FIND_BY_SID_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static FIND_BY_SID_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new FIND_BY_SID_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static FIND_BY_SID_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (FIND_BY_SID_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static FIND_BY_SID_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new FIND_BY_SID_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private FIND_BY_SID_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected FIND_BY_SID_OUTPUT(void* native, bool skipVTables = false)
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

    public uint NextEntryOffset
    {
        get => ((__Internal*)__Instance)->NextEntryOffset;

        set => ((__Internal*)__Instance)->NextEntryOffset = value;
    }

    public uint FileIndex
    {
        get => ((__Internal*)__Instance)->FileIndex;

        set => ((__Internal*)__Instance)->FileIndex = value;
    }

    public uint FileNameLength
    {
        get => ((__Internal*)__Instance)->FileNameLength;

        set => ((__Internal*)__Instance)->FileNameLength = value;
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