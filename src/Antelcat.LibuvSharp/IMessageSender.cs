namespace Antelcat.LibuvSharp;

public interface IMessageSender<TMessage>
{
    void Send(TMessage message, Action<Exception?>? callback);
}
