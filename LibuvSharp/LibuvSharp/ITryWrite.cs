namespace LibuvSharp;

public interface ITryWrite<in TData>
{
	int TryWrite(TData data);
}