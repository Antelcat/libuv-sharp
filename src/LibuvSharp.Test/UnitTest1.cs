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

        var process = UvProcess.Spawn(new UvProcessOptions
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
        _ = Task.Delay(3000).ContinueWith(t =>
        {
            process.Kill(9);
        });
        
        await Task.Delay(10000);
    }
    
}

