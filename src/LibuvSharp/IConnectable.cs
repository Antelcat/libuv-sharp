namespace LibuvSharp;

public interface IConnectable<TType, in TEndPoint>
{
	void Connect(TEndPoint endPoint, Action<Exception> callback);
}