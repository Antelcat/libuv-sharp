namespace LibuvSharp
{
	public interface IRemoteAddress<out T>
	{
		T RemoteAddress { get; }
	}
}

