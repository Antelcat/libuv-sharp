using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using LibuvSharp.Extensions;

namespace LibuvSharp;

public unsafe partial class UvPipe : IDisposable , IUvState
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    internal struct __Internal
    {
        internal UvStdioFlags    flags;
        internal PipeData.__Internal data;

        [SuppressUnmanagedCodeSecurity,
         DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_stdio_container_s@@QEAA@AEBU0@@Z",
             CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    internal partial struct PipeData
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct __Internal
        {
            [FieldOffset(0)] internal IntPtr stream;

            [FieldOffset(0)] internal int fd;

            [SuppressUnmanagedCodeSecurity,
             DllImport(LibuvSharp.libuv, EntryPoint = "??0<unnamed-type-data>@uv_stdio_container_s@@QEAA@AEBT01@@Z",
                 CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr __0);
        }

        private  __Internal __instance;
        internal __Internal __Instance => __instance;

        internal static PipeData __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new PipeData(native.ToPointer(), skipVTables);
        }

        internal static PipeData __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PipeData(native, skipVTables);
        }

        private PipeData(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private PipeData(void* native, bool skipVTables = false) : this()
        {
            __instance = *(__Internal*)native;
        }

        public PipeData(PipeData __0)
            : this()
        {
            var ____arg0 = __0.__Instance;
            var __arg0   = new IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new IntPtr(__instancePtr), __arg0);
            }
        }

        public UvStream Stream
        {
            get
            {
                var __result0 = UvStream.__GetOrCreateInstance(__instance.stream);
                return __result0;
            }

            set => __instance.stream = value is null ? IntPtr.Zero : value.__Instance;
        }

        public int Fd
        {
            get => __instance.fd;

            set => __instance.fd = value;
        }
    }


    internal static readonly ConcurrentDictionary<IntPtr, UvPipe> NativeToManagedMap = new();

    public void Dispose()
    {
        write.Dispose();
        shutdown.Dispose();
    }

    internal UvStdioFlags Flags
    {
        get
        {
            var ret = UvStdioFlags.UV_IGNORE;
            if (!Readable && !Writable) return ret;
            ret = UvStdioFlags.UV_CREATE_PIPE;
            if (Readable)
            {
                ret |= UvStdioFlags.UV_READABLE_PIPE;
            }

            if (Writable)
            {
                ret |= UvStdioFlags.UV_WRITABLE_PIPE;
            }

            return ret;
        }
    }
    
    private          UvBufT.__Internal Buffer { get; set; }
    private          IntPtr            pipe;
    internal         IntPtr            Stream => pipe;
    private          IntPtr            handle => pipe;
    private readonly UvWriteS          write    = new();
    private readonly UvShutdownS       shutdown = new();
    private          UvOutputBuffer?   firstBuffer;
    private          UvOutputBuffer?   lastBuffer;
    private          UvProcess?        process;
    
    internal void NewAndInit(UvLoop loop, UvProcess process, UvBufT.__Internal buffer)
    {
        this.process = process;
        Buffer       = buffer;
        pipe = Marshal.AllocHGlobal(sizeof(UvPipeS.__Internal));
        Uv.__Internal.UvPipeInit(loop.__Instance, pipe, 0).Check();
        Status = UvStatus.INITIALIZED;
    }

    internal void Start()
    {
        if (Status != UvStatus.INITIALIZED) return;
        Status = UvStatus.STARTED;
        if (Readable)
        {
            if (Buffer.len > 0)
            {
                if (Buffer.@base == IntPtr.Zero)
                    throw new Exception();

                Uv.__Internal.UvWrite(write.__Instance,
                    Stream,
                    Buffer.GetAddress(),
                    static (_, result) =>
                    {
                        result.Check();
                    }).Check();
            }


            Uv.__Internal.UvShutdown(shutdown.__Instance,
                Stream,
                static (_, result) =>
                {
                    result.Check();
                }).Check();
        }

        if (Writable)
        {
            Uv.__Internal.UvReadStart(Stream, OnAlloc, OnRead).Check();
        }
    }

    private void OnAlloc(IntPtr _, ulong suggestedSize, IntPtr buffer)
    {
        if (lastBuffer == null)
        {
            lastBuffer = firstBuffer = new UvOutputBuffer();
        }
        else if (lastBuffer.Available == 0)
        {
            var next = new UvOutputBuffer();
            lastBuffer.Next = next;
            lastBuffer      = next;
        }

        lastBuffer.OnAlloc(suggestedSize, buffer.As<UvBufT.__Internal>());
    }
    private void OnRead(IntPtr _, long nRead, IntPtr buffer)
    {
        switch (nRead)
        {
            case (long)UvErrno.UV_EOF:
                break;
            case < 0:
                SetError((int)nRead);
                Uv.__Internal.UvReadStop(Stream);
                break;
            default:
            {
                var data = lastBuffer?.OnRead(buffer.As<UvBufT.__Internal>(), (ulong)nRead);
                process?.IncrementBufferSizeAndCheckOverflow((ulong)nRead);
                if (data != null)
                {
                    Data?.Invoke(new ArraySegment<byte>(data));
                }
                break;
            }
        }
    }
    
    public void Close()
    {
        if (!Status.HasFlag(UvStatus.INITIALIZED)) return;
        Uv.__Internal.UvClose(handle, _ =>
        {
            Status = UvStatus.CLOSED;
        });
        Status = UvStatus.CLOSING;
    }

    public void Write(byte[] data)
    {
        
    }

    public bool Readable { get; init; }
    public bool Writable { get; init; }

    private void SetError(int error) => process?.SetPipeError((UvErrno)error);


    public event Action<Exception>?          Error;
    public event Action<ArraySegment<byte>>? Data;
    public event Action?                     Closed;
    public UvStatus                          Status { get; private set; } = UvStatus.UNINITIALIZED;


    public static UvPipe Ignore { get; } = new() { Writable = false, Readable = false };
}

public class UvOutputBuffer
{
    private const uint BufferSize = 65536;

    internal unsafe void OnAlloc(ulong suggestedSize, UvBufT.__Internal* buf)
    {
        if (Used == BufferSize)
            *buf = Uv.__Internal.UvBufInit(null, 0);
        else
        {
            fixed (sbyte* head = data)
            {
                *buf = Uv.__Internal.UvBufInit(head + Used, Available);
            }
        }
    }

    internal unsafe byte[]? OnRead(UvBufT.__Internal* buf, ulong nRead)
    {
        fixed (sbyte* head = data)
        {
            if (buf->@base != IntPtr.Add(new IntPtr(head), (int)Used))
            {
                // Sequence length not match
            }

            var     count = (int)nRead;
            var ret   = new byte[count];
            Array.Copy(data, (int)Used, ret, 0, count);
#if DEBUG
            var str = Encoding.UTF8.GetString(ret);
            Console.WriteLine(str);
#endif
            Used += nRead;
            return ret;
        }

    }

    private readonly sbyte[]         data = new sbyte[BufferSize];
    internal         uint            Available => (uint)(data.Length - (uint)Used);
    internal         ulong           Used      { get; private set; }
    internal         UvOutputBuffer? Next      { get; set; }
}