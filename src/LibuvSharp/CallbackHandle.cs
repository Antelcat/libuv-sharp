﻿using System.Runtime.InteropServices;
using LibuvSharp.Internal;

namespace LibuvSharp;

public abstract class CallbackHandle : Handle
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    protected delegate void uv_handle_cb(IntPtr handle);

    protected static readonly uv_handle_cb uv_callback = uv_handle;

    protected CallbackHandle(Loop loop, HandleType handleType)
        : base(loop, handleType)
    {
    }

    protected CallbackHandle(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int> constructor)
        : base(loop, handleType, constructor)
    {
    }

    private static void uv_handle(IntPtr handle)
    {
        FromIntPtr<CallbackHandle>(handle).OnCallback();
    }

    public event Action? Callback;

    protected void OnCallback()
    {
        Callback?.Invoke();
    }
}

public abstract class StartableCallbackHandle(Loop loop, HandleType handleType, Func<IntPtr, IntPtr, int> constructor)
    : CallbackHandle(loop, handleType, constructor)
{
    public abstract void Start();

    public abstract void Stop();

    protected void Invoke(Func<IntPtr, uv_handle_cb, int> function)
    {
        CheckDisposed();

        var r = function(NativeHandle, uv_callback);
        Ensure.Success(r);
    }
}
