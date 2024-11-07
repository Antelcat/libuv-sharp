using System.Text;
using Antelcat.LibuvSharp.Internal;

namespace Antelcat.LibuvSharp.Extensions;

internal static class IUVStreamExtensions
{
    public static void Read(this IUVStream<ArraySegment<byte>> stream, Encoding enc, Action<string> callback)
    {
        stream.Data += data => callback(enc.GetString(data.Array!, data.Offset, data.Count));
    }

    #region Write

    public static void Write(this IUVStream<ArraySegment<byte>> stream, byte[] data, int index, int count, Action<Exception?>? callback)
    {
        stream.Write(new ArraySegment<byte>(data, index, count), callback);
    }

    public static void Write(this IUVStream<ArraySegment<byte>> stream, byte[] data, int index, int count)
    {
        stream.Write(data, index, count, null);
    }

    public static void Write(this IUVStream<ArraySegment<byte>> stream, byte[] data, Action<Exception?>? callback)
    {
        Ensure.ArgumentNotNull(data, nameof(data));
        stream.Write(data, 0, data.Length, callback);
    }

    public static void Write(this IUVStream<ArraySegment<byte>> stream, byte[] data)
    {
        stream.Write(data, null);
    }

    public static void Write(this IUVStream<ArraySegment<byte>> stream, ArraySegment<byte> data)
    {
        stream.Write(data, null);
    }

    #endregion Write

    #region Write string

    public static int Write(this IUVStream<ArraySegment<byte>> stream, Encoding enc, string text, Action<Exception?>? callback)
    {
        var bytes = enc.GetBytes(text);
        stream.Write(bytes, callback);
        return bytes.Length;
    }

    public static int Write(this IUVStream<ArraySegment<byte>> stream, string text, Action<Exception?>? callback)
    {
        return stream.Write(Encoding.UTF8, text, callback);
    }

    public static int Write(this IUVStream<ArraySegment<byte>> stream, Encoding enc, string text)
    {
        return stream.Write(enc, text, null);
    }

    public static int Write(this IUVStream<ArraySegment<byte>> stream, string text)
    {
        return stream.Write(Encoding.UTF8, text);
    }

    #endregion Write string

    #region Shutdown

    public static void Shutdown(this IUVStream<ArraySegment<byte>> stream)
    {
        stream.Shutdown(null);
    }

    public static void Shutdown(this IUVStream<ArraySegment<byte>> stream, Action callback)
    {
        stream.Shutdown(_ => callback());
    }

    #endregion Shutdown

    #region End

    public static void End(this IUVStream<ArraySegment<byte>> stream, byte[] data, int index, int count, Action<Exception?>? callback)
    {
        stream.Write(data, index, count);
        stream.Shutdown(callback);
    }

    public static void End(this IUVStream<ArraySegment<byte>> stream, byte[] data, int index, int count)
    {
        stream.End(data, index, count, null);
    }

    public static void End(this IUVStream<ArraySegment<byte>> stream, byte[] data, Action<Exception?>? callback)
    {
        stream.Write(data);
        stream.Shutdown(callback);
    }

    public static void End(this IUVStream<ArraySegment<byte>> stream, byte[] data)
    {
        stream.Write(data, null);
    }

    public static void End(this IUVStream<ArraySegment<byte>> stream, ArraySegment<byte> data, Action<Exception?>? callback)
    {
        stream.Write(data);
        stream.Shutdown(callback);
    }

    public static void End(this IUVStream<ArraySegment<byte>> stream, ArraySegment<byte> data)
    {
        stream.End(data, null);
    }

    public static int End(this IUVStream<ArraySegment<byte>> stream, Encoding encoding, string text, Action<Exception?>? callback)
    {
        var size = stream.Write(encoding, text);
        stream.Shutdown(callback);
        return size;
    }

    public static int End(this IUVStream<ArraySegment<byte>> stream, string text, Action<Exception?>? callback)
    {
        return stream.End(Encoding.UTF8, text, callback);
    }

    public static int End(this IUVStream<ArraySegment<byte>> stream, Encoding encoding, string text)
    {
        return stream.End(encoding, text, null);
    }

    public static int End(this IUVStream<ArraySegment<byte>> stream, string text)
    {
        return stream.End(Encoding.UTF8, text);
    }

    #endregion End
      
    public static Task<TData?> ReadStructAsync<TData>(this IUVStream<TData> stream) where TData : struct
    {
        var tcs = new TaskCompletionSource<TData?>();
#if TASK_STATUS
			HelperFunctions.SetStatus(tcs.Task, TaskStatus.Running);
#endif

        Action<Exception?, TData?>? finish = null;

        void error(Exception? e)
        {
            finish?.Invoke(e, null);
        }

        void data(TData val)
        {
            finish?.Invoke(null, val);
        }

        void end()
        {
            finish?.Invoke(null, null);
        }

        finish = WrapExtensions.Finish(tcs, () =>
        {
            stream.Pause();
            stream.Error    -= error;
            stream.Complete -= end;
            stream.Data     -= data;
        });

        try
        {
            stream.Error    += error;
            stream.Complete += end;
            stream.Data     += data;
            stream.Resume();
        }
        catch(Exception e)
        {
            finish(e, null);
        }

        return tcs.Task;
    }

    #region WriteAsync

    public static Task WriteAsync(this IUVStream<ArraySegment<byte>> stream, ArraySegment<byte> data)
    {
        return WrapExtensions.Wrap(data, stream.Write);
    }

    public static Task WriteAsync(this IUVStream<ArraySegment<byte>> stream, byte[] data, int index, int count)
    {
        return WrapExtensions.Wrap(data, index, count, stream.Write);
    }

    //public static Task WriteAsync(this IUVStream<ArraySegment<byte>> stream, byte[] data)
    //{
    //    return HelperFunctions.Wrap(data, stream.Write);
    //}

    public static Task<int> WriteAsync(this IUVStream<ArraySegment<byte>> stream, Encoding encoding, string text)
    {
        return WrapExtensions.Wrap(encoding, text, stream.Write);
    }

    public static Task<int> WriteAsync(this IUVStream<ArraySegment<byte>> stream, string text)
    {
        return WrapExtensions.Wrap(text, stream.Write);
    }

    #endregion WriteAsync

    public static Task ShutdownAsync(this IUVStream<ArraySegment<byte>> stream)
    {
        return WrapExtensions.Wrap(stream.Shutdown);
    }
}
