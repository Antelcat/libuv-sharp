﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class SENDCMDOUTPARAMS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 17, Pack = 1)]
    public struct __Internal
    {
        internal       uint                    cBufferSize;
        internal       DRIVERSTATUS.__Internal DriverStatus;
        internal fixed byte                    bBuffer[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, SENDCMDOUTPARAMS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, SENDCMDOUTPARAMS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, SENDCMDOUTPARAMS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out SENDCMDOUTPARAMS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SENDCMDOUTPARAMS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SENDCMDOUTPARAMS(native.ToPointer(), skipVTables);
    }

    internal static SENDCMDOUTPARAMS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SENDCMDOUTPARAMS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SENDCMDOUTPARAMS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SENDCMDOUTPARAMS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SENDCMDOUTPARAMS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SENDCMDOUTPARAMS(void* native, bool skipVTables = false)
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

    public uint CBufferSize
    {
        get => ((__Internal*)__Instance)->cBufferSize;

        set => ((__Internal*)__Instance)->cBufferSize = value;
    }

    public DRIVERSTATUS DriverStatus
    {
        get => DRIVERSTATUS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->DriverStatus));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->DriverStatus = *(DRIVERSTATUS.__Internal*) value.__Instance;
        }
    }

    public byte[] BBuffer
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->bBuffer, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->bBuffer[i] = value[i];
            }
        }
    }
}