namespace LibuvSharp
{
	public interface IMessageReceiver<out TMessage>
	{
		event Action<TMessage> Message;
	}
}

