﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class SENDCMDINPARAMS : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 33, Pack = 1)]
    public struct __Internal
    {
        internal       uint               cBufferSize;
        internal       IDEREGS.__Internal irDriveRegs;
        internal       byte               bDriveNumber;
        internal fixed byte               bReserved[3];
        internal fixed uint               dwReserved[4];
        internal fixed byte               bBuffer[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, SENDCMDINPARAMS> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, SENDCMDINPARAMS>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, SENDCMDINPARAMS managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out SENDCMDINPARAMS managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static SENDCMDINPARAMS __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new SENDCMDINPARAMS(native.ToPointer(), skipVTables);
    }

    internal static SENDCMDINPARAMS __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (SENDCMDINPARAMS)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static SENDCMDINPARAMS __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new SENDCMDINPARAMS(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private SENDCMDINPARAMS(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected SENDCMDINPARAMS(void* native, bool skipVTables = false)
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

    public IDEREGS IrDriveRegs
    {
        get => IDEREGS.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->irDriveRegs));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->irDriveRegs = *(IDEREGS.__Internal*) value.__Instance;
        }
    }

    public byte BDriveNumber
    {
        get => ((__Internal*)__Instance)->bDriveNumber;

        set => ((__Internal*)__Instance)->bDriveNumber = value;
    }

    public byte[] BReserved
    {
        get => MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->bReserved, 3);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 3; i++)
                    ((__Internal*)__Instance)->bReserved[i] = value[i];
            }
        }
    }

    public uint[] DwReserved
    {
        get => MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->dwReserved, 4);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 4; i++)
                    ((__Internal*)__Instance)->dwReserved[i] = value[i];
            }
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