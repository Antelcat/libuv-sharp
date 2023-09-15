﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class TXFS_LIST_TRANSACTIONS_ENTRY : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public partial struct __Internal
    {
        internal global::GUID.__Internal TransactionId;
        internal uint                    TransactionState;
        internal uint                    Reserved1;
        internal uint                    Reserved2;
        internal long                    Reserved3;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTIONS_ENTRY> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.TXFS_LIST_TRANSACTIONS_ENTRY>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.TXFS_LIST_TRANSACTIONS_ENTRY managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.TXFS_LIST_TRANSACTIONS_ENTRY managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static TXFS_LIST_TRANSACTIONS_ENTRY __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new TXFS_LIST_TRANSACTIONS_ENTRY(native.ToPointer(), skipVTables);
    }

    internal static TXFS_LIST_TRANSACTIONS_ENTRY __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (TXFS_LIST_TRANSACTIONS_ENTRY)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static TXFS_LIST_TRANSACTIONS_ENTRY __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new TXFS_LIST_TRANSACTIONS_ENTRY(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private TXFS_LIST_TRANSACTIONS_ENTRY(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected TXFS_LIST_TRANSACTIONS_ENTRY(void* native, bool skipVTables = false)
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

    public uint TransactionState
    {
        get => ((__Internal*)__Instance)->TransactionState;

        set => ((__Internal*)__Instance)->TransactionState = value;
    }

    public uint Reserved1
    {
        get => ((__Internal*)__Instance)->Reserved1;

        set => ((__Internal*)__Instance)->Reserved1 = value;
    }

    public uint Reserved2
    {
        get => ((__Internal*)__Instance)->Reserved2;

        set => ((__Internal*)__Instance)->Reserved2 = value;
    }

    public long Reserved3
    {
        get => ((__Internal*)__Instance)->Reserved3;

        set => ((__Internal*)__Instance)->Reserved3 = value;
    }
}