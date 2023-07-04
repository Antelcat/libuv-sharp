namespace LibuvSharp
{
	public interface IBindable<TType, in TEndPoint>
	{
		void Bind(TEndPoint endPoint);
	}
}

