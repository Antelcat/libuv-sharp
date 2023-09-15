using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvUtsnameS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 1024)]
    public partial struct __Internal
    {
        internal fixed sbyte sysname[256];
        internal fixed sbyte release[256];
        internal fixed sbyte version[256];
        internal fixed sbyte machine[256];

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_utsname_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvUtsnameS> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvUtsnameS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvUtsnameS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvUtsnameS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvUtsnameS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvUtsnameS(native.ToPointer(), skipVTables);
    }

    internal static UvUtsnameS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvUtsnameS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvUtsnameS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvUtsnameS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvUtsnameS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvUtsnameS(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvUtsnameS()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvUtsnameS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvUtsnameS(global::LibuvSharp.UvUtsnameS _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvUtsnameS.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvUtsnameS.__Internal*) __Instance) = *((global::LibuvSharp.UvUtsnameS.__Internal*) _0.__Instance);
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

    public sbyte[] Sysname
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->sysname, 256);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 256; i++)
                    ((__Internal*)__Instance)->sysname[i] = value[i];
            }
        }
    }

    public sbyte[] Release
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->release, 256);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 256; i++)
                    ((__Internal*)__Instance)->release[i] = value[i];
            }
        }
    }

    public sbyte[] Version
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->version, 256);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 256; i++)
                    ((__Internal*)__Instance)->version[i] = value[i];
            }
        }
    }

    public sbyte[] Machine
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->machine, 256);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 256; i++)
                    ((__Internal*)__Instance)->machine[i] = value[i];
            }
        }
    }
}