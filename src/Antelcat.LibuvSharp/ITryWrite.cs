namespace Antelcat.LibuvSharp;

public interface ITryWrite<TData>
{
    int TryWrite(TData data);
}
