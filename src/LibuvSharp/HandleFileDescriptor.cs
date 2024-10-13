using System.Runtime.InteropServices;
using LibuvSharp.Internal;

namespace LibuvSharp;

public partial class HandleBase : IFileDescriptor
{
    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_fileno", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_fileno_windows(IntPtr handle, out IntPtr fd);

    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_fileno", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_fileno_unix(IntPtr handle, out int fd);

    public IntPtr FileDescriptor
    {
        get
        {
            if(UV.IsUnix)
            {
                uv_fileno_unix(NativeHandle, out var value);
                return (IntPtr)value;
            }
            else
            {
                uv_fileno_windows(NativeHandle, out var value);
                return value;
            }
        }
    }

    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_tcp_open", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_tcp_open_unix(IntPtr handle, int sock);

    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_tcp_open", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_tcp_open_windows(IntPtr handle, IntPtr sock);

    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_udp_open", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_udp_open_unix(IntPtr handle, int sock);

    [DllImport(NativeMethods.Libuv, EntryPoint = "uv_udp_open", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int uv_udp_open_windows(IntPtr handle, IntPtr sock);

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern int uv_pipe_open(IntPtr handle, int fd);

    public static int Open(Func<IntPtr, int, int> unix, Func<IntPtr, IntPtr, int> windows, IntPtr handle, IntPtr fileDescriptor)
    {
        return UV.IsUnix ? unix(handle, fileDescriptor.ToInt32()) : windows(handle, fileDescriptor);
    }

    public void Open(IntPtr fileDescriptor)
    {
        var r = HandleType switch
        {
            HandleType.UV_TCP        => Open(uv_tcp_open_unix, uv_tcp_open_windows, NativeHandle, fileDescriptor),
            HandleType.UV_UDP        => Open(uv_udp_open_unix, uv_udp_open_windows, NativeHandle, fileDescriptor),
            HandleType.UV_NAMED_PIPE => uv_pipe_open(NativeHandle, fileDescriptor.ToInt32()),
            _                        => throw new NotSupportedException($"Unsupport \"{HandleType}\".")
        };

        Ensure.Success(r);
    }
}
