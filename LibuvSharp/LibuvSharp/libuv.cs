namespace LibuvSharp;

public class libuv
{
    public const string Lib = @"./runtimes/" +
#if OS_WINDOWS
                              @"win-x64/native/libuv.dll";
#elif OS_LINUX
                              @"linux-x64/native/libuv.so";
#endif
}