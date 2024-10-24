namespace Antelcat.LibuvSharp;

public interface IMessageReceiver<TMessage>
{
    event Action<TMessage> Message;
}
