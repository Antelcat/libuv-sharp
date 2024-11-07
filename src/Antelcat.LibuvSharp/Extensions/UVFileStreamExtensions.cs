namespace Antelcat.LibuvSharp.Extensions;

internal static class UVFileStreamExtensions
{
    public static Task OpenAsync(this UVFileStream filestream, string path, UVFileAccess access)
    {
        return WrapExtensions.Wrap(path, access, filestream.Open);
    }

    public static Task OpenReadAsync(this UVFileStream fileStream, string path)
    {
        return WrapExtensions.Wrap(path, fileStream.OpenRead);
    }

    public static Task OpenWriteAsync(this UVFileStream fileStream, string path)
    {
        return WrapExtensions.Wrap(path, fileStream.OpenWrite);
    }
}
