﻿using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class VOLUME_GET_GPT_ATTRIBUTES_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public partial struct __Internal
    {
        internal ulong GptAttributes;
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.VOLUME_GET_GPT_ATTRIBUTES_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.VOLUME_GET_GPT_ATTRIBUTES_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.VOLUME_GET_GPT_ATTRIBUTES_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.VOLUME_GET_GPT_ATTRIBUTES_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static VOLUME_GET_GPT_ATTRIBUTES_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new VOLUME_GET_GPT_ATTRIBUTES_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static VOLUME_GET_GPT_ATTRIBUTES_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (VOLUME_GET_GPT_ATTRIBUTES_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static VOLUME_GET_GPT_ATTRIBUTES_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new VOLUME_GET_GPT_ATTRIBUTES_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private VOLUME_GET_GPT_ATTRIBUTES_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected VOLUME_GET_GPT_ATTRIBUTES_INFORMATION(void* native, bool skipVTables = false)
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

    public ulong GptAttributes
    {
        get => ((__Internal*)__Instance)->GptAttributes;

        set => ((__Internal*)__Instance)->GptAttributes = value;
    }
}