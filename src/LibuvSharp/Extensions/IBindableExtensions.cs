using System.Net;
using LibuvSharp.Internal;

namespace LibuvSharp.Extensions;

internal static class IBindableExtensions
{
    public static void Bind<T>(this IBindable<T, IPEndPoint> bindable, IPAddress ipAddress, int port)
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        bindable.Bind(new IPEndPoint(ipAddress, port));
    }

    public static void Bind<T>(this IBindable<T, IPEndPoint> bindable, string ipAddress, int port)
    {
        Ensure.ArgumentNotNull(ipAddress, nameof(ipAddress));
        bindable.Bind(IPAddress.Parse(ipAddress), port);
    }
}
