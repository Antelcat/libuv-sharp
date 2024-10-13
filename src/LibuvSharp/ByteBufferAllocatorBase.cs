using LibuvSharp.Internal;

namespace LibuvSharp;

public abstract class ByteBufferAllocatorBase : IDisposable
{
    internal Handle.alloc_callback AllocCallback { get; set; }

    protected ByteBufferAllocatorBase()
    {
        AllocCallback = Alloc;
    }

    ~ByteBufferAllocatorBase()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Alloc(IntPtr data, int size, out uv_buf_t buf)
    {
        size = Alloc(size, out var ptr);
        buf  = new uv_buf_t(ptr, size);
    }

    protected abstract int Alloc(int size, out IntPtr pointer);

    protected abstract void Dispose(bool disposing);

    public abstract ArraySegment<byte> Retrieve(int size);
}
