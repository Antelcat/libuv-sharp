namespace Antelcat.LibuvSharp.Extensions;

internal static class IHandleExtensions
{
    public static void Close(this IHandle handle)
    {
        handle.Close(null);
    }
    
    public static Task CloseAsync(this IHandle handle)
    {
        return WrapExtensions.WrapSingle(handle.Close);
    }
}
