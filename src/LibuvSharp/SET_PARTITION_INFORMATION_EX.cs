﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class SET_PARTITION_INFORMATION_EX : IDisposable
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct __Internal
    {
        [FieldOffset(0)]
        internal PARTITION_STYLE PartitionStyle;

        [FieldOffset(8)]
        internal SET_PARTITION_INFORMATION.__Internal Mbr;

        [FieldOffset(8)]
        internal PARTITION_INFORMATION_GPT.__Internal Gpt;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, SET_PARTITION_INFORMATION_EX> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, SET_PARTITION_INFORMATION_EX>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, SET_PARTITION_INFORMATION_EX managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out SET_PARTITION_INFORMATION_EX managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SET_PARTITION_INFORMATION_EX __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SET_PARTITION_INFORMATION_EX(native.ToPointer(), skipVTables);
    }

    internal static SET_PARTITION_INFORMATION_EX __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SET_PARTITION_INFORMATION_EX)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SET_PARTITION_INFORMATION_EX __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SET_PARTITION_INFORMATION_EX(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SET_PARTITION_INFORMATION_EX(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SET_PARTITION_INFORMATION_EX(void* native, bool skipVTables = false)
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

    public PARTITION_STYLE PartitionStyle
    {
        get => ((__Internal*)__Instance)->PartitionStyle;

        set => ((__Internal*)__Instance)->PartitionStyle = value;
    }

    public SET_PARTITION_INFORMATION Mbr
    {
        get => SET_PARTITION_INFORMATION.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Mbr));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Mbr = *(SET_PARTITION_INFORMATION.__Internal*) value.__Instance;
        }
    }

    public PARTITION_INFORMATION_GPT Gpt
    {
        get => PARTITION_INFORMATION_GPT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Gpt));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Gpt = *(PARTITION_INFORMATION_GPT.__Internal*) value.__Instance;
        }
    }
}