using System.Net;
using Antelcat.LibuvSharp.Internal;
using Antelcat.LibuvSharp.Threading;

namespace Antelcat.LibuvSharp.Extensions;

internal static class IConnectableExtensions
{
    #region IP Extensions

    public static void Connect<TType>(this IConnectable<TType, IPEndPoint> client, IPAddress ipAddress, int port, Action<Exception?>? callback)
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));

        client.Connect(new IPEndPoint(ipAddress, port), callback);
    }

    public static void Connect<TType>(this IConnectable<TType, IPEndPoint> client, string ipAddress, int port, Action<Exception?>? callback)
    {
        client.Connect(IPAddress.Parse(ipAddress), port, callback);
    }

    #endregion IP Extensions

    public static void Connect<TType, TEndPoint>(this IConnectable<TType, TEndPoint> client, ILocalAddress<TEndPoint> remote, Action<Exception?>? callback)
    {
        client.Connect(remote.LocalAddress, callback);
    }
    
    public static Task ConnectAsync<TType, TEndPoint>(this IConnectable<TType, TEndPoint> client, TEndPoint endPoint)
    {
        return WrapExtensions.Wrap(endPoint, client.Connect);
    }

    public static Task ConnectAsync<TType>(this IConnectable<TType, IPEndPoint> client, IPAddress ipAddress, int port)
    {
        return WrapExtensions.Wrap(ipAddress, port, client.Connect);
    }

    public static Task ConnectAsync<TType>(this IConnectable<TType, IPEndPoint> client, string ipAddress, int port)
    {
        return WrapExtensions.Wrap(ipAddress, port, client.Connect);
    }

    public static Task ConnectAsync<TType, TEndPoint>(this IConnectable<TType, TEndPoint> client, ILocalAddress<TEndPoint> localAddress)
    {
        return WrapExtensions.Wrap(localAddress, client.Connect);
    }
}
