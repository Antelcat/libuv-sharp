﻿using System.Text;

namespace LibuvSharp.Threading.Tasks;

public static class IPCPipeExtensions
{
	public static Task WriteAsync(this IpcPipe pipe, Handle handle, ArraySegment<byte> data)
	{
		return HelperFunctions.Wrap(handle, data, pipe.Write);
	}

	public static Task WriteAsync(this IpcPipe pipe, Handle handle, byte[] data, int offset, int count)
	{
		return HelperFunctions.Wrap(handle, data, offset, count, pipe.Write);
	}

	public static Task WriteAsync(this IpcPipe pipe, Handle handle, byte[] data, int offset)
	{
		return HelperFunctions.Wrap(handle, data, offset, pipe.Write);
	}

	public static Task WriteAsync(this IpcPipe pipe, Handle handle, byte[] data)
	{
		return HelperFunctions.Wrap(handle, data, pipe.Write);
	}

	#region Write string

	public static Task<int> WriteAsync(this IpcPipe pipe, Handle handle, Encoding encoding, string text)
	{
		return HelperFunctions.Wrap(handle, encoding, text, pipe.Write);
	}

	public static Task<int> WriteAsync(this IpcPipe pipe, Handle handle, string text)
	{
		return HelperFunctions.Wrap(handle, text, pipe.Write);
	}

	#endregion
}