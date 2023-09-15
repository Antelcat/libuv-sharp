namespace LibuvSharp;

[Flags]
public enum UvStdioFlags
{
    UV_IGNORE          = 0,
    UV_CREATE_PIPE     = 1,
    UV_INHERIT_FD      = 2,
    UV_INHERIT_STREAM  = 4,
    UV_READABLE_PIPE   = 16,
    UV_WRITABLE_PIPE   = 32,
    UV_NONBLOCK_PIPE   = 64,
    UV_OVERLAPPED_PIPE = 64
}