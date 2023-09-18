using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class PARTITION_INFORMATION_GPT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 112)]
    public struct __Internal
    {
        internal       GUID.__Internal PartitionType;
        internal       GUID.__Internal PartitionId;
        internal       ulong           Attributes;
        internal fixed char            Name[36];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, PARTITION_INFORMATION_GPT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, PARTITION_INFORMATION_GPT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, PARTITION_INFORMATION_GPT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out PARTITION_INFORMATION_GPT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PARTITION_INFORMATION_GPT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PARTITION_INFORMATION_GPT(native.ToPointer(), skipVTables);
    }

    internal static PARTITION_INFORMATION_GPT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PARTITION_INFORMATION_GPT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PARTITION_INFORMATION_GPT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PARTITION_INFORMATION_GPT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PARTITION_INFORMATION_GPT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PARTITION_INFORMATION_GPT(void* native, bool skipVTables = false)
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

    public ulong Attributes
    {
        get => ((__Internal*)__Instance)->Attributes;

        set => ((__Internal*)__Instance)->Attributes = value;
    }

    public char[] Name
    {
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->Name, 36);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 36; i++)
                    ((__Internal*)__Instance)->Name[i] = value[i];
            }
        }
    }
}