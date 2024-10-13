using System.Runtime.InteropServices;
using LibuvSharp.Internal;

namespace LibuvSharp;

public class Idle(Loop loop) : StartableCallbackHandle(loop, HandleType.UV_IDLE, uv_idle_init)
{
    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_idle_init(IntPtr loop, IntPtr idle);

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_idle_start(IntPtr idle, uv_handle_cb callback);

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_idle_stop(IntPtr idle);

    public Idle() : this(Loop.Constructor)
    {
    }

    public override void Start()
    {
        Invoke(uv_idle_start);
    }

    public override void Stop()
    {
        Invoke(uv_idle_stop);
    }
}
