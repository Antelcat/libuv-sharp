using System.Collections;
using System.Text;
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
    public void Test1()
    {
        var ios = new List<UvStdioContainerS>();
        for (var i = 0; i < 7; i++)
        {
            var pipe = new UvStdioContainerS();
            ios.Add(pipe);
        }

        uv.UvSpawn(
            new UvLoopS(),
            new UvProcessS(),
            new UvProcessOptionsS
            {
                File =
                    @"D:\Shared\WorkSpace\Git\mediasoup-sharp\src\MediasoupSharp.Test\bin\Debug\net7.0\runtimes\win-x64\native\mediasoup-worker.exe",
                Env = (from DictionaryEntry arg
                            in Environment.GetEnvironmentVariables()
                        select $"{arg.Key}={arg.Value}")
                    .Append("MEDIASOUP_VERSION=__MEDIASOUP_VERSION__")
                    .ToArray(),
                Args  = new[] { "" },
                Stdio = ios.ToArray()
            });
    }
}

