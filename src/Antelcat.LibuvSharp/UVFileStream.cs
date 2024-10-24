using Antelcat.LibuvSharp.Internal;

namespace Antelcat.LibuvSharp;

public class UVFileStream(Loop loop) : IUVStream<ArraySegment<byte>>, IDisposable, IHandle
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

    public Loop Loop { get; } = loop;

    public bool IsClosed => uvFile == null;

    public bool IsClosing { get; private set; }

    public UVFileStream() : this(Loop.Constructor)
    {
    }

    private UVFile? uvFile;

    public void OpenRead(string path, Action<Exception?>? callback)
    {
        Open(path, UVFileAccess.Read, callback);
    }

    public void OpenWrite(string path, Action<Exception?>? callback)
    {
        Open(path, UVFileAccess.Write, callback);
    }

    public void Open(string path, UVFileAccess access, Action<Exception?>? callback)
    {
        Ensure.ArgumentNotNull(path, nameof(path));

        switch(access)
        {
            case UVFileAccess.Read:
                Readable = true;
                break;

            case UVFileAccess.Write:
                Writeable = true;
                break;

            case UVFileAccess.ReadWrite:
                Writeable = true;
                Readable  = true;
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(access));
        }

        UVFile.Open(Loop, path, access, (ex, file) =>
        {
            uvFile = file;
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

    private readonly byte[] buffer       = new byte[0x1000];
    private          bool   reading;
    private          int    readPosition;

    private void HandleRead(Exception? ex, int? size)
    {
        if(!reading)
        {
            return;
        }

        if(ex != null)
        {
            OnError(ex);
            return;
        }

        if(size is 0 or null)
        {
            uvFile?.Close(_ =>
            {
                OnComplete();
            });
            return;
        }

        readPosition += size.Value;
        OnData(new ArraySegment<byte>(buffer, 0, size.Value));

        if(reading)
        {
            WorkRead();
        }
    }

    private void WorkRead()
    {
        uvFile?.Read(Loop, readPosition, new ArraySegment<byte>(buffer, 0, buffer.Length), HandleRead);
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

    public event Action<ArraySegment<byte>>? Data;

    private int writeOffset;

    private readonly Queue<Tuple<ArraySegment<byte>, Action<Exception?>?>> queue = new();

    private void HandleWrite(Exception? ex, int? size)
    {
        var tuple = queue.Dequeue();
        WriteQueueSize -= tuple.Item1.Count;
        tuple.Item2?.Invoke(ex);
        if(size is > 0)
        {
            writeOffset += size.Value;
        }
        WorkWrite();
    }

    private void WorkWrite()
    {
        if(queue.Count == 0)
        {
            if(shutdown)
            {
                uvFile?.Truncate(writeOffset, Finish);
                //uvfile.Close(shutdownCallback);
            }
            OnDrain();
        }
        else
        {
            // handle next write
            var item = queue.Peek();
            uvFile?.Write(Loop, writeOffset, item.Item1, HandleWrite);
        }
    }

    private void Finish(Exception? ex)
    {
        uvFile?.Close(ex2 =>
        {
            uvFile    = null;
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

    public void Write(ArraySegment<byte> data, Action<Exception?>? callback)
    {
        queue.Enqueue(Tuple.Create(data, callback));
        WriteQueueSize += data.Count;
        if(queue.Count == 1)
        {
            WorkWrite();
        }
    }

    private bool                shutdown;
    private Action<Exception?>? shutdownCallback;

    public void Shutdown(Action<Exception?>? callback)
    {
        shutdown         = true;
        shutdownCallback = callback;
        if(queue.Count == 0)
        {
            uvFile?.Truncate(writeOffset, Finish);
        }
    }

    private void Close(Action<Exception?>? callback)
    {
        if(!IsClosed && !IsClosing)
        {
            IsClosing = true;
            uvFile?.Close(callback);
        }
    }

    private void Close()
    {
        Close(_ => { });
    }

    public void Dispose()
    {
        Close();
    }
}
