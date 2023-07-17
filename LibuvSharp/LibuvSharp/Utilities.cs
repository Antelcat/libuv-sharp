namespace LibuvSharp.Utilities;

public static partial class UtilitiesExtensions
{
	public static void Pump<T>(this IUVStream<T> readStream, IUVStream<T> writeStream)
	{
		Pump(readStream, writeStream, null);
	}

	public static void Pump<T>(this IUVStream<T> readStream, IUVStream<T> writeStream, Action<Exception>? callback)
	{
		var pending = false;
		var done = false;

		Action<Exception>? call = null;
		void Complete() => call?.Invoke(null);

		call = (ex) => {
			if (done) {
				return;
			}

			readStream.Error -= call;
			readStream.Complete -= Complete;

			done = true;
			if (callback != null) {
				callback(ex);
			}
		};

		readStream.Data += (data => {
			writeStream.Write(data, null);
			if (writeStream.WriteQueueSize <= 0) return;
			pending = true;
			readStream.Pause();
		});

		writeStream.Drain += () =>
		{
			if (!pending) return;
			pending = false;
			readStream.Resume();
		};

		readStream.Error += call;
		readStream.Complete += Complete;

		readStream.Resume();
	}
}