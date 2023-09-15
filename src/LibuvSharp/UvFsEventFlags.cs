namespace LibuvSharp;

[Flags]
public enum UvFsEventFlags
{
    UV_FS_EVENT_WATCH_ENTRY = 1,
    UV_FS_EVENT_STAT        = 2,
    UV_FS_EVENT_RECURSIVE   = 4
}