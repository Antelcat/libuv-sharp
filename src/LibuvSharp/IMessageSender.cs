namespace LibuvSharp;

public interface IMessageSender<in TMessage>
{
	void Send(TMessage message, Action<Exception> callback);
}