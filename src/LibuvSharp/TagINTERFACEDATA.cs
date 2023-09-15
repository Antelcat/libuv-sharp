﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TagINTERFACEDATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16, Pack = 8)]
    public partial struct __Internal
    {
        internal IntPtr pmethdata;
        internal uint     cMembers;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagINTERFACEDATA> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TagINTERFACEDATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TagINTERFACEDATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TagINTERFACEDATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TagINTERFACEDATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TagINTERFACEDATA(native.ToPointer(), skipVTables);
    }

    internal static TagINTERFACEDATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TagINTERFACEDATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TagINTERFACEDATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TagINTERFACEDATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TagINTERFACEDATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TagINTERFACEDATA(void* native, bool skipVTables = false)
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

    public global::LibuvSharp.TagMETHODDATA Pmethdata
    {
        get
        {
            var __result0 = global::LibuvSharp.TagMETHODDATA.__GetOrCreateInstance(((__Internal*)__Instance)->pmethdata, false);
            return __result0;
        }

        set => ((__Internal*)__Instance)->pmethdata = value is null ? IntPtr.Zero : value.__Instance;
    }

    public uint CMembers
    {
        get => ((__Internal*)__Instance)->cMembers;

        set => ((__Internal*)__Instance)->cMembers = value;
    }
}