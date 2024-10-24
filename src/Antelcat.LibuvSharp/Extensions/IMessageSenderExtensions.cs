using System.Net;
using Antelcat.LibuvSharp.Internal;
using Antelcat.LibuvSharp.Threading;

namespace Antelcat.LibuvSharp.Extensions;

internal static class IMessageSenderExtensions
{
    #region IPAddress string

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        Ensure.ArgumentNotNull(data, nameof(data));
        sender.Send(IPAddress.Parse(ipAddress), port, data, 0, data.Length, callback);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(ipAddress, port, data, null);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data, int index, int count, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        sender.Send(IPAddress.Parse(ipAddress), port, new ArraySegment<byte>(data, index, count), callback);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data, int index, int count)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(ipAddress, port, data, index, count, null);
    }

    #endregion IPAddress string

    #region IPAddress

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(data, nameof(data));
        sender.Send(ipAddress, port, data, 0, data.Length, callback);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(ipAddress, port, data, null);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data, int index, int count, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(data, nameof(data));
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        sender.Send(new IPEndPoint(ipAddress, port), new ArraySegment<byte>(data, index, count), callback);
    }

    public static void Send<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data, int index, int count)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(ipAddress, port, data, index, count, null);
    }

    #endregion IPAddress

    #region TEndPoint

    public static void Send<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data, Action<Exception?>? callback)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(data, nameof(data));
        sender.Send(endPoint, data, 0, data.Length, callback);
    }

    public static void Send<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(endPoint, data, null);
    }

    public static void Send<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data, int index, int count, Action<Exception?>? callback)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        Ensure.ArgumentNotNull(data, nameof(data));
        sender.Send(endPoint, new ArraySegment<byte>(data, index, count), callback);
    }

    public static void Send<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data, int index, int count)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        sender.Send(endPoint, data, index, count, null);
    }

    #endregion TEndPoint

    #region TMessage

    public static void Send<TMessage, TPayload>(this IMessageSender<TMessage> sender, string ipAddress, int port, TPayload payload, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        sender.Send(IPAddress.Parse(ipAddress), port, payload, callback);
    }

    public static void Send<TMessage, TPayload>(this IMessageSender<TMessage> sender, string ipAddress, int port, TPayload payload)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        sender.Send(ipAddress, port, payload, null);
    }

    public static void Send<TMessage, TPayload>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, TPayload payload, Action<Exception?>? callback)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        sender.Send(new IPEndPoint(ipAddress, port), payload, callback);
    }

    public static void Send<TMessage, TPayload>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, TPayload payload)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        sender.Send(ipAddress, port, payload, null);
    }

    #endregion TMessage

    public static void Send<TMessage, TEndPoint, TPayload>(this IMessageSender<TMessage> sender, TEndPoint endPoint, TPayload payload, Action<Exception?>? callback)
        where TMessage : IMessage<TEndPoint, TPayload>, new()
    {
        sender.Send(new TMessage { EndPoint = endPoint, Payload = payload }, callback);
    }

    public static void Send<TMessage, TEndPoint, TPayload>(this IMessageSender<TMessage> sender, TEndPoint endPoint, TPayload payload)
        where TMessage : IMessage<TEndPoint, TPayload>, new()
    {
        sender.Send(endPoint, payload, null);
    }
    
    public static Task SendAsync<TMessage>(this IMessageSender<TMessage> sender, TMessage message)
    {
        return WrapExtensions.Wrap(message, sender.Send);
    }

    #region IPAddress string

    public static Task SendAsync<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, data, sender.Send<TMessage>);
    }

    public static Task SendAsync<TMessage>(this IMessageSender<TMessage> sender, string ipAddress, int port, byte[] data, int index, int count)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, data, index, count, sender.Send<TMessage>);
    }

    #endregion IPAddress string

    #region IPAddress

    public static Task SendAsync<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, data, sender.Send<TMessage>);
    }

    public static Task SendAsync<TMessage>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, byte[] data, int index, int count)
        where TMessage : IMessage<IPEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, data, index, count, sender.Send<TMessage>);
    }

    #endregion IPAddress

    #region TEndPoint

    public static Task SendAsync<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(endPoint, data, sender.Send);
    }

    public static Task SendAsync<TMessage, TEndPoint>(this IMessageSender<TMessage> sender, TEndPoint endPoint, byte[] data, int index, int count)
        where TMessage : IMessage<TEndPoint, ArraySegment<byte>>, new()
    {
        return WrapExtensions.Wrap(endPoint, data, index, count, sender.Send);
    }

    #endregion TEndPoint

    #region TMessage

    public static Task SendAsync<TMessage, TPayload>(this IMessageSender<TMessage> sender, string ipAddress, int port, TPayload payload)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, payload, sender.Send);
    }

    public static Task SendAsync<TMessage, TPayload>(this IMessageSender<TMessage> sender, IPAddress ipAddress, int port, TPayload payload)
        where TMessage : IMessage<IPEndPoint, TPayload>, new()
    {
        return WrapExtensions.Wrap(ipAddress, port, payload, sender.Send);
    }

    #endregion TMessage

    public static Task SendAsync<TMessage, TEndPoint, TPayload>(this IMessageSender<TMessage> sender, TEndPoint endPoint, TPayload payload)
        where TMessage : IMessage<TEndPoint, TPayload>, new()
    {
        return WrapExtensions.Wrap(endPoint, payload, sender.Send);
    }
}
