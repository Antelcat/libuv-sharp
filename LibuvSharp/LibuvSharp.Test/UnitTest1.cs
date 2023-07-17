using System.Text;
using LibuvSharp;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;

namespace Libuv.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    private void SetPath()
    {
        var str = string.Empty;
        unsafe
        {
            fixed (char* path = LibuvSharp.Libuv.Lib)
            {
                var head = path;
                while (*head != '\0')
                {
                    str += *head;
                    if (*head == 'X')
                    {
                        *head = 'x';
                    }
                    head++;
                }
            }
        }
        
    }

    [Test]
    public async Task Test1()
    {
        SetPath();
        var str = LibuvSharp.Libuv.Lib;
        TaskCompletionSource source = new();
        var pipe = () =>
        {
            var ret = new Pipe { Writeable = true, Readable = true };
            ret.Error += Console.WriteLine;
            ret.Data += bytes => Console.WriteLine(Encoding.UTF8.GetString(bytes));
            return ret;
        };
        var dic = new Dictionary<string, string>
        {
            { "MEDIASOUP_VERSION", "3.12.4" },
            { "DEBUG", "*INFO* *WARN* *ERROR*" },
            { "INTERACTIVE", "'true'" },
            { "MEDIASOUP_LISTEN_IP", "0.0.0.0" },
            { "MEDIASOUP_ANNOUNCED_IP", "0.0.0.0" },
        };
        Process? process;
        try
        {
            process = Process.Spawn(new ProcessOptions
            {
                Detached = false,
                Arguments = new[]
                {
                    "--logLevel=debug", "--logTag=info",
                    "--logTag=ice", "--logTag=rtx",
                    "--logTag=bwe", "--logTag=score",
                    "--logTag=simulcast", "--logTag=svc",
                    "--logTag=sctp", "--logTag=message",
                    "--rtcMinPort=20000", "--rtcMaxPort=29999"
                },
                Environment = dic.Select(x => $"{x.Key}={x.Value}").ToArray(),
                CurrentWorkingDirectory = @".",
                File =
                    @"D:\Shared\WorkSpace\Git\ThirdPart\Tubumu.Mediasoup\src\Tubumu.Meeting.Web\mediasoup-worker.exe",
                Streams = new List<UVStream> { pipe(), pipe(), pipe(), pipe(), pipe(), pipe(), pipe(), }
            }, Console.WriteLine);
        }
        catch (Exception e)
        {
            throw e;
        }

        process.Closed += () => source.SetResult();
        //await source.Task;
    }
}