using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class uv_dirent_s : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal IntPtr                         name;
        internal UvDirentTypeT type;

        [SuppressUnmanagedCodeSecurity, DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_dirent_s@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, uv_dirent_s> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, uv_dirent_s>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, uv_dirent_s managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out uv_dirent_s managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    private   bool __name_OwnsNativeMemory;
    protected bool __ownsNativeInstance;

    internal static uv_dirent_s __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new uv_dirent_s(native.ToPointer(), skipVTables);
    }

    internal static uv_dirent_s __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (uv_dirent_s)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static uv_dirent_s __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new uv_dirent_s(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private uv_dirent_s(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected uv_dirent_s(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public uv_dirent_s()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public uv_dirent_s(uv_dirent_s _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((__Internal*) __Instance) = *((__Internal*) _0.__Instance);
        if (_0.__name_OwnsNativeMemory)
            Name = _0.Name;
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
        if (__name_OwnsNativeMemory)
            Marshal.FreeHGlobal(((__Internal*)__Instance)->name);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public string Name
    {
        get => MarshalUtil.GetString(Encoding.UTF8, ((__Internal*)__Instance)->name);

        set
        {
            if (__name_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->name);
            __name_OwnsNativeMemory = true;
            if (value == null)
            {
                ((__Internal*)__Instance)->name = IntPtr.Zero;
                return;
            }
            var __bytes0   = Encoding.UTF8.GetBytes(value);
            var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
            Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
            Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
            ((__Internal*)__Instance)->name = __bytePtr0;
        }
    }

    public UvDirentTypeT Type
    {
        get => ((__Internal*)__Instance)->type;

        set => ((__Internal*)__Instance)->type = value;
    }
}