using System.Text;

namespace Antelcat.LibuvSharp.Extensions;

internal static class IPCPipeExtensions
{
    public static Task WriteAsync(this IPCPipe pipe, Handle handle, ArraySegment<byte> data)
    {
        return WrapExtensions.Wrap(handle, data, pipe.Write);
    }

    public static Task WriteAsync(this IPCPipe pipe, Handle handle, byte[] data, int offset, int count)
    {
        return WrapExtensions.Wrap(handle, data, offset, count, pipe.Write);
    }

    public static Task WriteAsync(this IPCPipe pipe, Handle handle, byte[] data, int offset)
    {
        return WrapExtensions.Wrap(handle, data, offset, pipe.Write);
    }

    //public static Task WriteAsync(this IPCPipe pipe, Handle handle, byte[] data)
    //{
    //    return HelperFunctions.Wrap(handle, data, pipe.Write);
    //}

    #region Write string

    public static Task<int> WriteAsync(this IPCPipe pipe, Handle handle, Encoding encoding, string text)
    {
        return WrapExtensions.Wrap(handle, encoding, text, pipe.Write);
    }

    public static Task<int> WriteAsync(this IPCPipe pipe, Handle handle, string text)
    {
        return WrapExtensions.Wrap(handle, text, pipe.Write);
    }

    #endregion Write string
}
