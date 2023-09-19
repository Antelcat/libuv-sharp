﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class MARK_HANDLE_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    public struct __Internal
    {
        internal uint     UsnSourceInfo;
        internal IntPtr VolumeHandle;
        internal uint     HandleInfo;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, MARK_HANDLE_INFO> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, MARK_HANDLE_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, MARK_HANDLE_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out MARK_HANDLE_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static MARK_HANDLE_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new MARK_HANDLE_INFO(native.ToPointer(), skipVTables);
    }

    internal static MARK_HANDLE_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (MARK_HANDLE_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static MARK_HANDLE_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new MARK_HANDLE_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private MARK_HANDLE_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected MARK_HANDLE_INFO(void* native, bool skipVTables = false)
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

    public uint UsnSourceInfo
    {
        get => ((__Internal*)__Instance)->UsnSourceInfo;

        set => ((__Internal*)__Instance)->UsnSourceInfo = value;
    }

    public IntPtr VolumeHandle
    {
        get => ((__Internal*)__Instance)->VolumeHandle;

        set => ((__Internal*)__Instance)->VolumeHandle = value;
    }

    public uint HandleInfo
    {
        get => ((__Internal*)__Instance)->HandleInfo;

        set => ((__Internal*)__Instance)->HandleInfo = value;
    }
}