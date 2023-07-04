namespace LibuvSharp;

public interface ILocalAddress<out T>
{
	T LocalAddress { get; }
}