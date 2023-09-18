using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class SI_COPYFILE : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal       uint SourceFileNameLength;
        internal       uint DestinationFileNameLength;
        internal       uint Flags;
        internal fixed char FileNameBuffer[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, SI_COPYFILE> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, SI_COPYFILE>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, SI_COPYFILE managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out SI_COPYFILE managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SI_COPYFILE __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SI_COPYFILE(native.ToPointer(), skipVTables);
    }

    internal static SI_COPYFILE __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SI_COPYFILE)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SI_COPYFILE __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SI_COPYFILE(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SI_COPYFILE(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SI_COPYFILE(void* native, bool skipVTables = false)
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

    public uint SourceFileNameLength
    {
        get => ((__Internal*)__Instance)->SourceFileNameLength;

        set => ((__Internal*)__Instance)->SourceFileNameLength = value;
    }

    public uint DestinationFileNameLength
    {
        get => ((__Internal*)__Instance)->DestinationFileNameLength;

        set => ((__Internal*)__Instance)->DestinationFileNameLength = value;
    }

    public uint Flags
    {
        get => ((__Internal*)__Instance)->Flags;

        set => ((__Internal*)__Instance)->Flags = value;
    }

    public char[] FileNameBuffer
    {
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->FileNameBuffer, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->FileNameBuffer[i] = value[i];
            }
        }
    }
}