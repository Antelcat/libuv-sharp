namespace LibuvSharp;

[Flags]
public enum UvStatus
{
    UNINITIALIZED = -1,
    INITIALIZED   = 0x1,
    STARTED       = 0x3,
    CLOSING       = 0x4,
    CLOSED        = 0x8
}

public interface IUvState
{
    public UvStatus Status { get; }
}