﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class PARTITION_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public partial struct __Internal
    {
        internal global::LARGE_INTEGER.__Internal StartingOffset;
        internal global::LARGE_INTEGER.__Internal PartitionLength;
        internal uint                             HiddenSectors;
        internal uint                             PartitionNumber;
        internal byte                             PartitionType;
        internal byte                             BootIndicator;
        internal byte                             RecognizedPartition;
        internal byte                             RewritePartition;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PARTITION_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.PARTITION_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.PARTITION_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.PARTITION_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PARTITION_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PARTITION_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static PARTITION_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PARTITION_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PARTITION_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PARTITION_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PARTITION_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PARTITION_INFORMATION(void* native, bool skipVTables = false)
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

    public uint HiddenSectors
    {
        get => ((__Internal*)__Instance)->HiddenSectors;

        set => ((__Internal*)__Instance)->HiddenSectors = value;
    }

    public uint PartitionNumber
    {
        get => ((__Internal*)__Instance)->PartitionNumber;

        set => ((__Internal*)__Instance)->PartitionNumber = value;
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

    public byte RewritePartition
    {
        get => ((__Internal*)__Instance)->RewritePartition;

        set => ((__Internal*)__Instance)->RewritePartition = value;
    }
}