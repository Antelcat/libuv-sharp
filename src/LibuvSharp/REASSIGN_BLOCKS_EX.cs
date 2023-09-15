﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class REASSIGN_BLOCKS_EX : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 1)]
    public partial struct __Internal
    {
        internal       ushort Reserved;
        internal       ushort Count;
        internal fixed byte   BlockNumber[8];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REASSIGN_BLOCKS_EX> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.REASSIGN_BLOCKS_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.REASSIGN_BLOCKS_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.REASSIGN_BLOCKS_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static REASSIGN_BLOCKS_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new REASSIGN_BLOCKS_EX(native.ToPointer(), skipVTables);
    }

    internal static REASSIGN_BLOCKS_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (REASSIGN_BLOCKS_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static REASSIGN_BLOCKS_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new REASSIGN_BLOCKS_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private REASSIGN_BLOCKS_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected REASSIGN_BLOCKS_EX(void* native, bool skipVTables = false)
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

    public ushort Reserved
    {
        get => ((__Internal*)__Instance)->Reserved;

        set => ((__Internal*)__Instance)->Reserved = value;
    }

    public ushort Count
    {
        get => ((__Internal*)__Instance)->Count;

        set => ((__Internal*)__Instance)->Count = value;
    }

    public global::LARGE_INTEGER[]? BlockNumber
    {
        get
        {
            global::LARGE_INTEGER[]? __value = null;
            if (((__Internal*)__Instance)->BlockNumber != null)
            {
                __value = new global::LARGE_INTEGER[1];
                for (var i = 0; i < 1; i++)
                    __value[i] = ((__Internal*)__Instance)->BlockNumber[i];
            }
            return __value;
        }

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->BlockNumber[i] = value[i];
            }
        }
    }
}