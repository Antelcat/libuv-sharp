namespace Antelcat.LibuvSharp;

public interface ITrySend<in TMessage>
{
    int TrySend(TMessage message);
}
