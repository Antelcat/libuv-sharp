namespace LibuvSharp;

[Flags]
public enum UvUdpFlags
{
    UV_UDP_IPV6ONLY      = 1,
    UV_UDP_PARTIAL       = 2,
    UV_UDP_REUSEADDR     = 4,
    UV_UDP_MMSG_CHUNK    = 8,
    UV_UDP_MMSG_FREE     = 16,
    UV_UDP_LINUX_RECVERR = 32,
    UV_UDP_RECVMMSG      = 256
}