namespace Antelcat.LibuvSharp;

public interface IListener<TStream>
{
    void Listen();

    event Action? Connection;

    TStream? Accept();
}
