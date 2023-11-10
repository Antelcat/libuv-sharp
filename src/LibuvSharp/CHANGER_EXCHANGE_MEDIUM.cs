﻿using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_EXCHANGE_MEDIUM : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 36)]
    public struct __Internal
    {
        internal CHANGER_ELEMENT.__Internal Transport;
        internal CHANGER_ELEMENT.__Internal Source;
        internal CHANGER_ELEMENT.__Internal Destination1;
        internal CHANGER_ELEMENT.__Internal Destination2;
        internal byte                       Flip1;
        internal byte                       Flip2;
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, CHANGER_EXCHANGE_MEDIUM> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, CHANGER_EXCHANGE_MEDIUM>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, CHANGER_EXCHANGE_MEDIUM managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out CHANGER_EXCHANGE_MEDIUM managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_EXCHANGE_MEDIUM __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_EXCHANGE_MEDIUM(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_EXCHANGE_MEDIUM __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_EXCHANGE_MEDIUM)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_EXCHANGE_MEDIUM __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_EXCHANGE_MEDIUM(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_EXCHANGE_MEDIUM(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_EXCHANGE_MEDIUM(void* native, bool skipVTables = false)
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

    public CHANGER_ELEMENT Transport
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Transport));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Transport = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public CHANGER_ELEMENT Source
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Source));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Source = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public CHANGER_ELEMENT Destination1
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Destination1));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Destination1 = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public CHANGER_ELEMENT Destination2
    {
        get => CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->Destination2));

        set
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException(nameof(value), "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->Destination2 = *(CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public byte Flip1
    {
        get => ((__Internal*)__Instance)->Flip1;

        set => ((__Internal*)__Instance)->Flip1 = value;
    }

    public byte Flip2
    {
        get => ((__Internal*)__Instance)->Flip2;

        set => ((__Internal*)__Instance)->Flip2 = value;
    }
}