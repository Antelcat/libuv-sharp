﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class PERF_DATA_BLOCK : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 88, Pack = 8)]
    public struct __Internal
    {
        internal fixed char                     Signature[4];
        internal       uint                     LittleEndian;
        internal       uint                     Version;
        internal       uint                     Revision;
        internal       uint                     TotalByteLength;
        internal       uint                     HeaderLength;
        internal       uint                     NumObjectTypes;
        internal       int                      DefaultObject;
        internal       SYSTEMTIME.__Internal    SystemTime;
        internal       LARGE_INTEGER.__Internal PerfTime;
        internal       LARGE_INTEGER.__Internal PerfFreq;
        internal       LARGE_INTEGER.__Internal PerfTime100nSec;
        internal       uint                     SystemNameLength;
        internal       uint                     SystemNameOffset;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, PERF_DATA_BLOCK> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, PERF_DATA_BLOCK>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, PERF_DATA_BLOCK managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out PERF_DATA_BLOCK managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static PERF_DATA_BLOCK __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new PERF_DATA_BLOCK(native.ToPointer(), skipVTables);
    }

    internal static PERF_DATA_BLOCK __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (PERF_DATA_BLOCK)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static PERF_DATA_BLOCK __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new PERF_DATA_BLOCK(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private PERF_DATA_BLOCK(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected PERF_DATA_BLOCK(void* native, bool skipVTables = false)
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

    public char[] Signature
    {
        get => MarshalUtil.GetArray<char>(((__Internal*)__Instance)->Signature, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->Signature[i] = value[i];
            }
        }
    }

    public uint LittleEndian
    {
        get => ((__Internal*)__Instance)->LittleEndian;

        set => ((__Internal*)__Instance)->LittleEndian = value;
    }

    public uint Version
    {
        get => ((__Internal*)__Instance)->Version;

        set => ((__Internal*)__Instance)->Version = value;
    }

    public uint Revision
    {
        get => ((__Internal*)__Instance)->Revision;

        set => ((__Internal*)__Instance)->Revision = value;
    }

    public uint TotalByteLength
    {
        get => ((__Internal*)__Instance)->TotalByteLength;

        set => ((__Internal*)__Instance)->TotalByteLength = value;
    }

    public uint HeaderLength
    {
        get => ((__Internal*)__Instance)->HeaderLength;

        set => ((__Internal*)__Instance)->HeaderLength = value;
    }

    public uint NumObjectTypes
    {
        get => ((__Internal*)__Instance)->NumObjectTypes;

        set => ((__Internal*)__Instance)->NumObjectTypes = value;
    }

    public int DefaultObject
    {
        get => ((__Internal*)__Instance)->DefaultObject;

        set => ((__Internal*)__Instance)->DefaultObject = value;
    }

    public uint SystemNameLength
    {
        get => ((__Internal*)__Instance)->SystemNameLength;

        set => ((__Internal*)__Instance)->SystemNameLength = value;
    }

    public uint SystemNameOffset
    {
        get => ((__Internal*)__Instance)->SystemNameOffset;

        set => ((__Internal*)__Instance)->SystemNameOffset = value;
    }
}