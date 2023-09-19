﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PARTITION_INFORMATION_MBR : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct __Internal
    {
        internal byte PartitionType;
        internal byte BootIndicator;
        internal byte RecognizedPartition;
        internal uint HiddenSectors;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, PARTITION_INFORMATION_MBR> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, PARTITION_INFORMATION_MBR>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, PARTITION_INFORMATION_MBR managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out PARTITION_INFORMATION_MBR managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PARTITION_INFORMATION_MBR __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PARTITION_INFORMATION_MBR(native.ToPointer(), skipVTables);
    }

    internal static PARTITION_INFORMATION_MBR __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PARTITION_INFORMATION_MBR)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PARTITION_INFORMATION_MBR __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PARTITION_INFORMATION_MBR(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PARTITION_INFORMATION_MBR(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PARTITION_INFORMATION_MBR(void* native, bool skipVTables = false)
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

    public byte PartitionType
    {
        get => ((__Internal*)__Instance)->PartitionType;

        set => ((__Internal*)__Instance)->PartitionType = value;
    }

    public byte BootIndicator
    {
        get => ((__Internal*)__Instance)->BootIndicator;

        set => ((__Internal*)__Instance)->BootIndicator = value;
    }

    public byte RecognizedPartition
    {
        get => ((__Internal*)__Instance)->RecognizedPartition;

        set => ((__Internal*)__Instance)->RecognizedPartition = value;
    }

    public uint HiddenSectors
    {
        get => ((__Internal*)__Instance)->HiddenSectors;

        set => ((__Internal*)__Instance)->HiddenSectors = value;
    }
}