using System.Collections;
using LibuvSharp;

namespace Libuv.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public async Task Test1()
    {
        var ios = new List<UvStdioContainerS>();
        for (var i = 0; i < 7; i++)
        {
            var pipe = new UvStdioContainerS();
            ios.Add(pipe);
        }

        uv.UvSpawn(null,
            null,
            new UvProcessOptionsS
            {
                File =
                    @"D:\Shared\WorkSpace\Git\mediasoup-sharp\src\MediasoupSharp.Test\bin\Debug\net7.0\runtimes\win-x64\native\mediasoup-worker.exe",
                Env = (from DictionaryEntry arg
                            in Environment.GetEnvironmentVariables()
                        select $"{arg.Key}={arg.Value}")
                    .Append("MEDIASOUP_VERSION=__MEDIASOUP_VERSION__")
                    .ToArray(),
                Args = new[]
                {
                    "--logLevel=debug", "--logTag=info",
                    "--logTag=ice", "--logTag=rtx",
                    "--logTag=bwe", "--logTag=score",
                    "--logTag=simulcast", "--logTag=svc",
                    "--logTag=sctp", "--logTag=message",
                    "--rtcMinPort=20000", "--rtcMaxPort=29999"
                },
                Stdio = ios.ToArray()
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

