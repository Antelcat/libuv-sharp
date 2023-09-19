﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class VIRTUALIZATION_INSTANCE_INFO_OUTPUT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal GUID.__Internal VirtualizationInstanceID;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, VIRTUALIZATION_INSTANCE_INFO_OUTPUT> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, VIRTUALIZATION_INSTANCE_INFO_OUTPUT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, VIRTUALIZATION_INSTANCE_INFO_OUTPUT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out VIRTUALIZATION_INSTANCE_INFO_OUTPUT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static VIRTUALIZATION_INSTANCE_INFO_OUTPUT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new VIRTUALIZATION_INSTANCE_INFO_OUTPUT(native.ToPointer(), skipVTables);
    }

    internal static VIRTUALIZATION_INSTANCE_INFO_OUTPUT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (VIRTUALIZATION_INSTANCE_INFO_OUTPUT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static VIRTUALIZATION_INSTANCE_INFO_OUTPUT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new VIRTUALIZATION_INSTANCE_INFO_OUTPUT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private VIRTUALIZATION_INSTANCE_INFO_OUTPUT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected VIRTUALIZATION_INSTANCE_INFO_OUTPUT(void* native, bool skipVTables = false)
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
}