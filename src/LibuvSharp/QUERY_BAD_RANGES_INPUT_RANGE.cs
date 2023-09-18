﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class QUERY_BAD_RANGES_INPUT_RANGE : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal ulong StartOffset;
        internal ulong LengthInBytes;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, QUERY_BAD_RANGES_INPUT_RANGE> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, QUERY_BAD_RANGES_INPUT_RANGE>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, QUERY_BAD_RANGES_INPUT_RANGE managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out QUERY_BAD_RANGES_INPUT_RANGE managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static QUERY_BAD_RANGES_INPUT_RANGE __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new QUERY_BAD_RANGES_INPUT_RANGE(native.ToPointer(), skipVTables);
    }

    internal static QUERY_BAD_RANGES_INPUT_RANGE __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (QUERY_BAD_RANGES_INPUT_RANGE)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static QUERY_BAD_RANGES_INPUT_RANGE __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new QUERY_BAD_RANGES_INPUT_RANGE(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private QUERY_BAD_RANGES_INPUT_RANGE(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected QUERY_BAD_RANGES_INPUT_RANGE(void* native, bool skipVTables = false)
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

    public ulong StartOffset
    {
        get => ((__Internal*)__Instance)->StartOffset;

        set => ((__Internal*)__Instance)->StartOffset = value;
    }

    public ulong LengthInBytes
    {
        get => ((__Internal*)__Instance)->LengthInBytes;

        set => ((__Internal*)__Instance)->LengthInBytes = value;
    }
}