using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml;
using LibuvSharp.Extensions;

namespace LibuvSharp;

public unsafe partial class UvPipe : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct __Internal
    {
        internal UvStdioFlags    flags;
        internal Data.__Internal data;

        [SuppressUnmanagedCodeSecurity,
         DllImport(LibuvSharp.libuv, EntryPoint = "??0uv_stdio_container_s@@QEAA@AEBU0@@Z",
             CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
    }

    public partial struct Data
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

        internal static Data __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Data(native.ToPointer(), skipVTables);
        }

        internal static Data __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Data(native, skipVTables);
        }

        private Data(__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Data(void* native, bool skipVTables = false) : this()
        {
            __instance = *(__Internal*)native;
        }

        public Data(Data __0)
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
        stream = new();
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

    private Data data
    {
        get => Data.__CreateInstance(((__Internal*)__Instance)->data);

        set => ((__Internal*)__Instance)->data = value.__Instance;
    }

    internal         UvBufT?         Buffer { get; set; }
    private          UvPipeS?        pipe;
    internal         UvStreamS?      stream;
    private          UvHandleS       handle;
    private readonly UvWriteS        write    = new();
    private readonly UvShutdownS     shutdown = new();
    private          UvOutputBuffer? firstBuffer;
    private          UvOutputBuffer? lastBuffer;
    private          UvProcess?     process;
    private          bool            closed;
    
    internal void NewAndInit(UvLoop loop, UvProcess process, UvBufT.__Internal buffer)
    {
        this.process = process;
        Buffer       = UvBufT.__CreateInstance(buffer);
        pipe         = new();
        stream       = UvStreamS.__CreateInstance(pipe.__Instance);
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
                Uv.UvWrite(write, stream, Buffer, static (req, result) => { result.Check(); }).Check();
            }

            Uv.UvShutdown(shutdown, stream,static  (req, result) => { result.Check(); }).Check();
        }

        if (Writable)
        {
            Uv.UvReadStart(stream,
                (_, suggestedSize, buf) =>
                {
                    if (lastBuffer == null)
                    {
                        firstBuffer = new();
                        lastBuffer  = firstBuffer;
                    }
                    else if (lastBuffer.Available == 0)
                    {
                        lastBuffer      = new UvOutputBuffer();
                        lastBuffer.Next = lastBuffer;
                    }

                    lastBuffer.OnAlloc(suggestedSize, buf.As<UvBufT.__Internal>());
                },
                (_, nRead, buf) =>
                {
                    if (nRead == (long)UvErrno.UV_EOF)
                    {
                        
                    }
                    else if (nRead < 0)
                    {
                        SetError((int)nRead);
                        Uv.UvReadStop(stream);
                    }
                    else
                    {
                        var header = buf.As<UvBufT.__Internal>();
                        lastBuffer?.OnRead(buf.As<UvBufT.__Internal>(), (ulong)nRead);
                        process?.IncrementBufferSizeAndCheckOverflow((ulong)nRead);
                    }
                }).Check();
        }
    }

    internal void Close()
    {
        Uv.UvClose(handle,  (_) =>
        {
            closed = true;
        });
    }

    public bool Readable
    {
        get => Flags.HasFlag(UvStdioFlags.UV_READABLE_PIPE);
        set
        {
            if (value)
            {
                Flags |= UvStdioFlags.UV_READABLE_PIPE | UvStdioFlags.UV_CREATE_PIPE;
            }
            else
            {
                if ((Flags & UvStdioFlags.UV_READABLE_PIPE) != 0)
                    Flags -= UvStdioFlags.UV_READABLE_PIPE;
            }
        }
    }

    public bool Writable
    {
        get => Flags.HasFlag(UvStdioFlags.UV_WRITABLE_PIPE);
        set
        {
            if (value)
            {
                Flags |= UvStdioFlags.UV_WRITABLE_PIPE | UvStdioFlags.UV_CREATE_PIPE;
            }
            else
            {
                if ((Flags & UvStdioFlags.UV_WRITABLE_PIPE) != 0)
                    Flags -= UvStdioFlags.UV_WRITABLE_PIPE;
            }
        }
    }

    private void SetError(int error) => process?.SetPipeError((UvErrno)error);
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
        }

        Used += nRead;
    }

    private readonly sbyte[]         data = new sbyte[BufferSize];
    internal         uint            Available => (uint)(data.Length - (uint)Used);
    internal         ulong           Used      { get; private set; }
    internal         UvOutputBuffer? Next      { get; set; }
}