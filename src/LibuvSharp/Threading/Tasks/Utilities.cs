using LibuvSharp.Extensions;

namespace LibuvSharp.Threading.Tasks;

public static partial class UtilitiesExtensions
{
    public static Task PumpAsync<T>(this IUVStream<T> readStream, IUVStream<T> writeStream)
    {
        return WrapExtensions.Wrap(writeStream, readStream.Pump);
    }
}
