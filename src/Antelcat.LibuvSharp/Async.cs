using System.Runtime.InteropServices;
using Antelcat.LibuvSharp.Internal;

namespace Antelcat.LibuvSharp;

public class Async : CallbackHandle
{
    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_async_init(IntPtr loop, IntPtr handle, uv_handle_cb callback);

    public Async()
        : this(Loop.Constructor)
    {
    }

    public Async(Loop loop)
        : base(loop, HandleType.UV_ASYNC)
    {
        var r = uv_async_init(loop.NativeHandle, NativeHandle, uv_callback);
        Ensure.Success(r);
    }

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_async_send(IntPtr handle);

    public void Send()
    {
        Invoke(uv_async_send);
    }
}
