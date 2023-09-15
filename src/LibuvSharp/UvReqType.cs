namespace LibuvSharp;

public enum UvReqType
{
    UV_UNKNOWN_REQ  = 0,
    UV_REQ          = 1,
    UV_CONNECT      = 2,
    UV_WRITE        = 3,
    UV_SHUTDOWN     = 4,
    UV_UDP_SEND     = 5,
    UV_FS           = 6,
    UV_WORK         = 7,
    UV_GETADDRINFO  = 8,
    UV_GETNAMEINFO  = 9,
    UV_RANDOM       = 10,
    UV_ACCEPT       = 11,
    UV_FS_EVENT_REQ = 12,
    UV_POLL_REQ     = 13,
    UV_PROCESS_EXIT = 14,
    UV_READ         = 15,
    UV_UDP_RECV     = 16,
    UV_WAKEUP       = 17,
    UV_SIGNAL_REQ   = 18,
    UV_REQ_TYPE_MAX = 19
}