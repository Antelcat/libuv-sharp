namespace LibuvSharp;

public class UVFileStream 
	: IUVStream<ArraySegment<byte>>, IDisposable, IHandle
{
	public void Ref()
	{
	}

	public void Unref()
	{
	}

	public void Close(Action? callback)
	{
		Close(_ =>
		{
			callback?.Invoke();
		});
	}

	public bool HasRef => true;

	public Loop Loop { get; private set; }

	public bool IsClosed => uvfile == null;

	public bool IsClosing { get; private set; }

	public UVFileStream()
		: this(Loop.Constructor)
	{
	}

	public UVFileStream(Loop loop)
	{
		Loop = loop;
	}

	private UVFile? uvfile;

	public void OpenRead(string path, Action<Exception> callback)
	{
		Open(path, UVFileAccess.Read, callback);
	}

	public void OpenWrite(string path, Action<Exception> callback)
	{
		Open(path, UVFileAccess.Write, callback);
	}

	public void Open(string path, UVFileAccess access, Action<Exception>? callback)
	{
		callback.NotNull("path");

		switch (access) {
			case UVFileAccess.Read:
				Readable = true;
				break;
			case UVFileAccess.Write:
				Writeable = true;
				break;
			case UVFileAccess.ReadWrite:
				Writeable = true;
				Readable = true;
				break;
			default:
				throw new ArgumentException("access not supported");
		}

		UVFile.Open(Loop, path, access, (ex, file) => {
			uvfile = file;
			callback?.Invoke(ex);
		});
	}

	protected void OnComplete()
	{
		Complete?.Invoke();
	}

	public event Action? Complete;

	protected void OnError(Exception ex)
	{
		Error?.Invoke(ex);
	}

	public event Action<Exception>? Error;

	public bool Readable { get; private set; }

	private byte[] buffer = new byte[0x1000];
	private bool   reading;
	private int    readposition;

	private void HandleRead(Exception? ex, int size)
	{
		if (!reading) {
			return;
		}

		if (ex != null) {
			OnError(ex);
			return;
		}

		if (size == 0) {
			uvfile.Close(ex2 => {
				OnComplete();
			});
			return;
		}

		readposition += size;
		OnData(new ArraySegment<byte>(buffer, 0, size));

		if (reading) {
			WorkRead();
		}
	}

	private void WorkRead()
	{
		uvfile.Read(Loop, readposition, new ArraySegment<byte>(buffer, 0, buffer.Length), HandleRead);
	}

	public void Resume()
	{
		reading = true;
		WorkRead();
	}

	public void Pause()
	{
		reading = false;
	}

	private void OnData(ArraySegment<byte> data)
	{
		Data?.Invoke(data);
	}
	public event Action<ArraySegment<byte>> Data;

	private int                                                 writeoffset;
	private Queue<Tuple<ArraySegment<byte>, Action<Exception>>> queue = new Queue<Tuple<ArraySegment<byte>, Action<Exception>>>();

	private void HandleWrite(Exception ex, int size)
	{
		var tuple = queue.Dequeue();

		WriteQueueSize -= tuple.Item1.Count;

		var cb = tuple.Item2;
		cb?.Invoke(ex);

		writeoffset += size;
		WorkWrite();
	}

	private void WorkWrite()
	{
		if (queue.Count == 0) {
			if (shutdown) {
				uvfile.Truncate(writeoffset, Finish);
				//uvfile.Close(shutdownCallback);
			}
			OnDrain();
		} else {
			// handle next write
			var item = queue.Peek();
			uvfile.Write(Loop, writeoffset, item.Item1, HandleWrite);
		}
	}

	private void Finish(Exception ex)
	{
		uvfile.Close(ex2 => {
			uvfile = null;
			IsClosing = false;
			shutdownCallback?.Invoke(ex ?? ex2);
		});
	}

	private void OnDrain()
	{
		Drain?.Invoke();
	}

	public event Action? Drain;

	public long WriteQueueSize { get; private set; }

	public bool Writeable { private set; get; }

	public void Write(ArraySegment<byte> data, Action<Exception> callback)
	{
		queue.Enqueue(Tuple.Create(data, callback));
		WriteQueueSize += data.Count;
		if (queue.Count == 1) {
			WorkWrite();
		}
	}

	private bool               shutdown;
	private Action<Exception>? shutdownCallback;
	public void Shutdown(Action<Exception> callback)
	{
		shutdown = true;
		shutdownCallback = callback;
		if (queue.Count == 0) {
			uvfile.Truncate(writeoffset, Finish);
		}
	}

	private void Close(Action<Exception> callback)
	{
		if (IsClosed || IsClosing) return;
		IsClosing = true;
		uvfile.Close(callback);
	}

	private void Close()
	{
		Close(ex => { });
	}

	public void Dispose()
	{
		Close();
	}
}