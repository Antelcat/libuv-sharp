using System.Net.Sockets;
using System.Runtime.InteropServices;
using LibuvSharp.Internal;

namespace LibuvSharp;

public unsafe class UVException(int systemErrorCode, string name, string description)
    : Exception($"{name}({systemErrorCode}): {description}")
{
    /// <summary>
    /// Independent error code, has the same value on all
    /// systems.
    /// </summary>
    /// <value>The error code.</value>
    internal UVErrorCode ErrorCode { get; set; } = Map(name);

    /// <summary>
    /// Gets the the underlying system error code of the error
    /// They might be different on windows and unix, EAGAIN
    /// for example is -4088 on windows while it is -11 on UNIX.
    /// </summary>
    /// <value>The system error code.</value>
    public int SystemErrorCode { get; protected set; } = systemErrorCode;

    public string Name        { get; protected set; } = name;
    public string Description { get; protected set; } = description;

    internal UVException(int systemErrorCode)
        : this(systemErrorCode, ErrorName(systemErrorCode), StringError(systemErrorCode))
    {
    }

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern sbyte* uv_strerror(int systemErrorCode);

    [DllImport(NativeMethods.Libuv, CallingConvention = CallingConvention.Cdecl)]
    private static extern sbyte* uv_err_name(int systemErrorCode);

    internal static string StringError(int systemErrorCode)
    {
        return new string(uv_strerror(systemErrorCode));
    }

    internal static string ErrorName(int systemErrorCode)
    {
        return new string(uv_err_name(systemErrorCode));
    }

    public static UVErrorCode Map(int systemErrorCode)
    {
        return systemErrorCode == 0 ? UVErrorCode.OK : Map(ErrorName(systemErrorCode));
    }

    public static UVErrorCode Map(string errorName)
    {
        try
        {
            return (UVErrorCode)Enum.Parse(typeof(UVErrorCode), errorName);
        }
        catch
        {
            return UVErrorCode.UNKNOWN;
        }
    }

    /// <summary>
    /// Returns the corresponding SocketError.
    /// </summary>
    /// <value>The socket error.</value>
    public SocketError SocketError
    {
        get
        {
            // every comment prefixed with WSA is not in the reference source
            // every comment prefixed with SocktError is not defined in uv.h
            return ErrorCode switch
            {
                UVErrorCode.EINTR        => SocketError.Interrupted,
                UVErrorCode.EACCES       => SocketError.AccessDenied,
                UVErrorCode.EFAULT       => SocketError.Fault,
                UVErrorCode.EINVAL       => SocketError.InvalidArgument,
                UVErrorCode.EMFILE       => SocketError.TooManyOpenSockets,
                UVErrorCode.EAGAIN       => SocketError.WouldBlock,
                UVErrorCode.EALREADY     => SocketError.AlreadyInProgress,
                UVErrorCode.ENOTSOCK     => SocketError.NotSocket,
                UVErrorCode.EDESTADDRREQ => SocketError.DestinationAddressRequired,
                UVErrorCode.EMSGSIZE     => SocketError.MessageSize,
                UVErrorCode.EPROTOTYPE   => SocketError.ProtocolType,
                // SocketError.ProtocolOption
                UVErrorCode.EPROTONOSUPPORT => SocketError.ProtocolNotSupported,
                // SocketNotSupported;
                UVErrorCode.ENOTSUP => SocketError.OperationNotSupported,
                // SocketError.ProtocolFamilyNotSupported
                UVErrorCode.EAFNOSUPPORT  => SocketError.AddressFamilyNotSupported,
                UVErrorCode.EADDRINUSE    => SocketError.AddressAlreadyInUse,
                UVErrorCode.EADDRNOTAVAIL => SocketError.AddressNotAvailable,
                UVErrorCode.ENETDOWN      => SocketError.NetworkDown,
                UVErrorCode.ENETUNREACH   => SocketError.NetworkUnreachable,
                // SocketError.NetworkReset
                UVErrorCode.ECONNABORTED => SocketError.ConnectionAborted,
                UVErrorCode.ECONNRESET   => SocketError.ConnectionReset,
                UVErrorCode.ENOBUFS      => SocketError.NoBufferSpaceAvailable,
                UVErrorCode.EISCONN      => SocketError.IsConnected,
                UVErrorCode.ENOTCONN     => SocketError.NotConnected,
                UVErrorCode.ESHUTDOWN    => SocketError.Shutdown,
                UVErrorCode.ETIMEDOUT    => SocketError.TimedOut,
                UVErrorCode.ECONNREFUSED => SocketError.ConnectionRefused,
                // WSAELOOP
                // WSAENAMETOOLONG
                // SocketError.HostDown
                UVErrorCode.EHOSTUNREACH => SocketError.HostUnreachable,
                _                        => SocketError.SocketError
            };
        }
    }
}
