namespace LibuvSharp;

[Flags]
public enum UvPollEvent
{
    UV_READABLE    = 1,
    UV_WRITABLE    = 2,
    UV_DISCONNECT  = 4,
    UV_PRIORITIZED = 8
}