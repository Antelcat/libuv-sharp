namespace LibuvSharp;

public enum UvHandleType
{
    UV_UNKNOWN_HANDLE  = 0,
    UV_ASYNC           = 1,
    UV_CHECK           = 2,
    UV_FS_EVENT        = 3,
    UV_FS_POLL         = 4,
    UV_HANDLE          = 5,
    UV_IDLE            = 6,
    UV_NAMED_PIPE      = 7,
    UV_POLL            = 8,
    UV_PREPARE         = 9,
    UV_PROCESS         = 10,
    UV_STREAM          = 11,
    UV_TCP             = 12,
    UV_TIMER           = 13,
    UV_TTY             = 14,
    UV_UDP             = 15,
    UV_SIGNAL          = 16,
    UV_FILE            = 17,
    UV_HANDLE_TYPE_MAX = 18
}