namespace LibuvSharp.Utilities
{
	public static partial class UtilitiesExtensions
	{
		public static void Pump<T>(this IUVStream<T> readStream, IUVStream<T> writeStream)
		{
			Pump(readStream, writeStream, null);
		}

		public static void Pump<T>(this IUVStream<T> readStream, IUVStream<T> writeStream, Action<Exception> callback)
		{
			var pending = false;
			var done = false;

			Action<Exception> call = null;
			var complete = () => call(null);

			call = (ex) => {
				if (done) {
					return;
				}

				readStream.Error -= call;
				readStream.Complete -= complete;

				done = true;
				if (callback != null) {
					callback(ex);
				}
			};

			readStream.Data += ((data) => {
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
			readStream.Complete += complete;

			readStream.Resume();
		}
	}
}

