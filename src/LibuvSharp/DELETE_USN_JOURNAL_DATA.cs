﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class DELETE_USN_JOURNAL_DATA : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public partial struct __Internal
    {
        internal ulong UsnJournalID;
        internal uint  DeleteFlags;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DELETE_USN_JOURNAL_DATA> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.DELETE_USN_JOURNAL_DATA>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.DELETE_USN_JOURNAL_DATA managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.DELETE_USN_JOURNAL_DATA managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static DELETE_USN_JOURNAL_DATA __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new DELETE_USN_JOURNAL_DATA(native.ToPointer(), skipVTables);
    }

    internal static DELETE_USN_JOURNAL_DATA __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (DELETE_USN_JOURNAL_DATA)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static DELETE_USN_JOURNAL_DATA __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new DELETE_USN_JOURNAL_DATA(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private DELETE_USN_JOURNAL_DATA(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected DELETE_USN_JOURNAL_DATA(void* native, bool skipVTables = false)
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

    public ulong UsnJournalID
    {
        get => ((__Internal*)__Instance)->UsnJournalID;

        set => ((__Internal*)__Instance)->UsnJournalID = value;
    }

    public uint DeleteFlags
    {
        get => ((__Internal*)__Instance)->DeleteFlags;

        set => ((__Internal*)__Instance)->DeleteFlags = value;
    }
}