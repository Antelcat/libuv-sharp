﻿using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class UvStatT : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 128)]
    public partial struct __Internal
    {
        internal ulong                                     st_dev;
        internal ulong                                     st_mode;
        internal ulong                                     st_nlink;
        internal ulong                                     st_uid;
        internal ulong                                     st_gid;
        internal ulong                                     st_rdev;
        internal ulong                                     st_ino;
        internal ulong                                     st_size;
        internal ulong                                     st_blksize;
        internal ulong                                     st_blocks;
        internal ulong                                     st_flags;
        internal ulong                                     st_gen;
        internal global::LibuvSharp.UvTimespecT.__Internal st_atim;
        internal global::LibuvSharp.UvTimespecT.__Internal st_mtim;
        internal global::LibuvSharp.UvTimespecT.__Internal st_ctim;
        internal global::LibuvSharp.UvTimespecT.__Internal st_birthtim;

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "??0uv_stat_t@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvStatT> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.UvStatT>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.UvStatT managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.UvStatT managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvStatT __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new UvStatT(native.ToPointer(), skipVTables);
    }

    internal static UvStatT __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvStatT)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvStatT __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvStatT(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private UvStatT(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvStatT(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvStatT()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvStatT.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    public UvStatT(global::LibuvSharp.UvStatT __0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(global::LibuvSharp.UvStatT.__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *((global::LibuvSharp.UvStatT.__Internal*) __Instance) = *((global::LibuvSharp.UvStatT.__Internal*) __0.__Instance);
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

    public ulong StDev
    {
        get => ((__Internal*)__Instance)->st_dev;

        set => ((__Internal*)__Instance)->st_dev = value;
    }

    public ulong StMode
    {
        get => ((__Internal*)__Instance)->st_mode;

        set => ((__Internal*)__Instance)->st_mode = value;
    }

    public ulong StNlink
    {
        get => ((__Internal*)__Instance)->st_nlink;

        set => ((__Internal*)__Instance)->st_nlink = value;
    }

    public ulong StUid
    {
        get => ((__Internal*)__Instance)->st_uid;

        set => ((__Internal*)__Instance)->st_uid = value;
    }

    public ulong StGid
    {
        get => ((__Internal*)__Instance)->st_gid;

        set => ((__Internal*)__Instance)->st_gid = value;
    }

    public ulong StRdev
    {
        get => ((__Internal*)__Instance)->st_rdev;

        set => ((__Internal*)__Instance)->st_rdev = value;
    }

    public ulong StIno
    {
        get => ((__Internal*)__Instance)->st_ino;

        set => ((__Internal*)__Instance)->st_ino = value;
    }

    public ulong StSize
    {
        get => ((__Internal*)__Instance)->st_size;

        set => ((__Internal*)__Instance)->st_size = value;
    }

    public ulong StBlksize
    {
        get => ((__Internal*)__Instance)->st_blksize;

        set => ((__Internal*)__Instance)->st_blksize = value;
    }

    public ulong StBlocks
    {
        get => ((__Internal*)__Instance)->st_blocks;

        set => ((__Internal*)__Instance)->st_blocks = value;
    }

    public ulong StFlags
    {
        get => ((__Internal*)__Instance)->st_flags;

        set => ((__Internal*)__Instance)->st_flags = value;
    }

    public ulong StGen
    {
        get => ((__Internal*)__Instance)->st_gen;

        set => ((__Internal*)__Instance)->st_gen = value;
    }

    public global::LibuvSharp.UvTimespecT StAtim
    {
        get => global::LibuvSharp.UvTimespecT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->st_atim));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->st_atim = *(global::LibuvSharp.UvTimespecT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTimespecT StMtim
    {
        get => global::LibuvSharp.UvTimespecT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->st_mtim));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->st_mtim = *(global::LibuvSharp.UvTimespecT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTimespecT StCtim
    {
        get => global::LibuvSharp.UvTimespecT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->st_ctim));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->st_ctim = *(global::LibuvSharp.UvTimespecT.__Internal*) value.__Instance;
        }
    }

    public global::LibuvSharp.UvTimespecT StBirthtim
    {
        get => global::LibuvSharp.UvTimespecT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->st_birthtim));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->st_birthtim = *(global::LibuvSharp.UvTimespecT.__Internal*) value.__Instance;
        }
    }
}