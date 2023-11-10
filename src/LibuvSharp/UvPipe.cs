using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Xml;
using LibuvSharp.Extensions;

namespace LibuvSharp;

public unsafe partial class UvPipe : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal UvStdioFlags    flags;
        internal PipeData.__Internal data;

        [SuppressUnmanagedCodeSecurity,
         DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_stdio_container_s@@QEAA@AEBU0@@Z",
             CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct PipeData
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

        public UvStreamS Stream
        {
            get
            {
                var __result0 = UvStreamS.__GetOrCreateInstance(__instance.stream);
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

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, UvPipe> NativeToManagedMap = new();

    internal static void __RecordNativeToManagedMapping(IntPtr native, UvPipe managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out UvPipe managed)
    {
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static UvPipe? __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        return native == IntPtr.Zero
            ? null
            : new UvPipe(native.ToPointer(), skipVTables);
    }

    internal static UvPipe? __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (UvPipe)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static UvPipe __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new UvPipe(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*)ret = native;
        return ret.ToPointer();
    }

    private UvPipe(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected UvPipe(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public UvPipe()
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        Flags  = UvStdioFlags.UV_IGNORE;
    }

    public UvPipe(UvPipe _0)
    {
        __Instance           = Marshal.AllocHGlobal(sizeof(__Internal));
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
        *(__Internal*)__Instance = *(__Internal*)_0.__Instance;
    }

    public void Dispose()
    {
        Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
    }

    partial void DisposePartial(bool disposing);

    protected internal virtual void Dispose(bool disposing, bool callNativeDtor)
    {
        if (__Instance == IntPtr.Zero)
            return;
        NativeToManagedMap.TryRemove(__Instance, out _);
        DisposePartial(disposing);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    private UvStdioFlags Flags
    {
        get => ((__Internal*)__Instance)->flags;

        set => ((__Internal*)__Instance)->flags = value;
    }
    
    private          UvBufT?         Buffer { get; set; }
    private          UvPipeS?        pipe;
    internal         UvStreamS?      Stream;
    private          UvHandleS?      handle;
    private readonly UvWriteS        write    = new();
    private readonly UvShutdownS     shutdown = new();
    private          UvOutputBuffer? firstBuffer;
    private          UvOutputBuffer? lastBuffer;
    private          UvProcess?      process;
    private          bool            closed;
    
    internal void NewAndInit(UvLoop loop, UvProcess process, UvBufT.__Internal buffer)
    {
        this.process = process;
        Buffer       = UvBufT.__CreateInstance(buffer);
        pipe         = new UvPipeS();
        Stream       = UvStreamS.__CreateInstance(pipe.__Instance);
        handle       = UvHandleS.__CreateInstance(pipe.__Instance);
        Uv.UvPipeInit(loop, pipe, 0).Check();
        pipe.Data = __Instance;
    }

    internal void Start()
    {
        if (Readable)
        {
            if (Buffer!.Len > 0)
            {
                Uv.UvWrite(write, Stream, Buffer, static (req, result) => { result.Check(); }).Check();
            }

            Uv.UvShutdown(shutdown, Stream,static  (req, result) => { result.Check(); }).Check();
        }

        if (Writable)
        {
            Uv.UvReadStart(Stream,
                (_, suggestedSize, buf) =>
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

                    lastBuffer.OnAlloc(suggestedSize, buf.As<UvBufT.__Internal>());
                },
                (_, nRead, buf) =>
                {
                    switch (nRead)
                    {
                        case (long)UvErrno.UV_EOF:
                            break;
                        case < 0:
                            SetError((int)nRead);
                            Uv.UvReadStop(Stream);
                            break;
                        default:
                        {
                            lastBuffer?.OnRead(buf.As<UvBufT.__Internal>(), (ulong)nRead);
                            process?.IncrementBufferSizeAndCheckOverflow((ulong)nRead);
                            break;
                        }
                    }
                }).Check();
        }
    }

    public void Close()
    {
        if(closed)return;
        Uv.UvClose(handle,  (_) =>
        {
            closed = true;
        });
    }

    public void Write(byte[] data)
    {
        
    }
    
    public bool Readable
    {
        get => Flags.HasFlag(UvStdioFlags.UV_READABLE_PIPE);
        init
        {
            if (value)
            {
                Flags |= UvStdioFlags.UV_READABLE_PIPE | UvStdioFlags.UV_CREATE_PIPE;
            }
        }
    }

    public bool Writable
    {
        get => Flags.HasFlag(UvStdioFlags.UV_WRITABLE_PIPE);
        init
        {
            if (value)
            {
                Flags |= UvStdioFlags.UV_WRITABLE_PIPE | UvStdioFlags.UV_CREATE_PIPE;
            }
        }
    }

    private void SetError(int error) => process?.SetPipeError((UvErrno)error);


    public event Action<Exception>?          Error;
    public event Action<ArraySegment<byte>>? Data;
    public event Action?                     Closed;

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

    internal unsafe void OnRead(UvBufT.__Internal* buf, ulong nRead)
    {
        fixed (sbyte* head = data)
        {
            if (buf->@base != IntPtr.Add(new IntPtr(head), (int)Used))
            {
                Debugger.Break();
            }

            var count = (int)nRead;
            var msg   = new byte[count];
            for (var start = 0; start < count; start++)
            {
                msg[start] = (byte)data[(int)Used + start];
            }

            var str = Encoding.UTF8.GetString(msg);
            Debugger.Break();
        }

        Used += nRead;
    }

    private readonly sbyte[]         data = new sbyte[BufferSize];
    internal         uint            Available => (uint)(data.Length - (uint)Used);
    internal         ulong           Used      { get; private set; }
    internal         UvOutputBuffer? Next      { get; set; }
}