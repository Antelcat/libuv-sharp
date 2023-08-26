namespace LibuvSharp;

public interface IListener<out TStream>
{
	void Listen();
	event Action Connection;
	TStream Accept();
}