namespace LibuvSharp;

public enum UvDirentTypeT
{
    UV_DIRENT_UNKNOWN = 0,
    UV_DIRENT_FILE    = 1,
    UV_DIRENT_DIR     = 2,
    UV_DIRENT_LINK    = 3,
    UV_DIRENT_FIFO    = 4,
    UV_DIRENT_SOCKET  = 5,
    UV_DIRENT_CHAR    = 6,
    UV_DIRENT_BLOCK   = 7
}