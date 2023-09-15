namespace LibuvSharp;

[Flags]
public enum UvProcessFlags
{
    UV_PROCESS_SETUID                     = 1,
    UV_PROCESS_SETGID                     = 2,
    UV_PROCESS_WINDOWS_VERBATIM_ARGUMENTS = 4,
    UV_PROCESS_DETACHED                   = 8,
    UV_PROCESS_WINDOWS_HIDE               = 16,
    UV_PROCESS_WINDOWS_HIDE_CONSOLE       = 32,
    UV_PROCESS_WINDOWS_HIDE_GUI           = 64
}