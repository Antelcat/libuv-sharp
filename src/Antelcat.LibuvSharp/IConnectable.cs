namespace Antelcat.LibuvSharp;

public interface IConnectable<TType, TEndPoint>
{
    void Connect(TEndPoint endPoint, Action<Exception?>? callback);
}
