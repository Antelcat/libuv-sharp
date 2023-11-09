using System.Collections;
using System.Diagnostics;
using LibuvSharp;
using LibuvSharp.Extensions;

namespace Libuv.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMarshal()
    {
        var ptr  = new[] { "123" , "12" , "1" }.CopyToPointer();
        var strs = ptr.CopyToStrings();
        
    }

    [Test]
    public async Task Test1()
    {
        var ios = new List<UvPipe>();
        for (var i = 0; i < 7; i++)
        {
            var pipe = new UvPipe
            {
                Readable = true,
                Writable = true
            };
            ios.Add(pipe);
        }

        var process = Uv.UvSpawn(new UvProcessOptionsS
            {
                ExitCb = (a, exit, c) =>
                {
                    Debugger.Break();
                },
                File =
                    @"D:\Shared\WorkSpace\Git\mediasoup-sharp\src\MediasoupSharp.Test\bin\Debug\net7.0\runtimes\win-x64\native\mediasoup-worker.exe",
                Env = (from DictionaryEntry arg
                            in Environment.GetEnvironmentVariables()
                        select $"{arg.Key}={arg.Value}")
                    .Append("MEDIASOUP_VERSION=3.11.12")
                    .ToArray(),
                Args  = Array.Empty<string>(),
                Stdio = ios.ToArray(),
            });

        await Task.Delay(10000);
    }
    
    /*
    public global::LibuvSharp.UvStdioContainerS[]? Stdio
    {
        get
        {
            var ret     = new UvStdioContainerS[StdioCount];
            var pointer = (UvStdioContainerS.__Internal*)((__Internal*)__Instance)->stdio;
            for (var i = 0; i < StdioCount; i++)
            {
                ret[StdioCount] = global::LibuvSharp.UvStdioContainerS.__GetOrCreateInstance((nint)pointer, false);
                pointer++;
            }

            return ret;
        }

        set
        {
            ((__Internal*)__Instance)->stdio = value is null ? IntPtr.Zero : value[0].__Instance;
            StdioCount                       = value?.Length ?? 0;
        }
    }
    */
}

