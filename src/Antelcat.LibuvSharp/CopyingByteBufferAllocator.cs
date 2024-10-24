using Antelcat.LibuvSharp.Internal;

namespace Antelcat.LibuvSharp;

public class CopyingByteBufferAllocator : ByteBufferAllocatorBase
{
    private BufferPin? pin;

    public byte[] Buffer => pin == null ? throw new NullReferenceException(nameof(pin)) : pin.Buffer;

    protected override int Alloc(int size, out IntPtr ptr)
    {
        if(pin == null)
        {
            pin = new BufferPin(size);
        }
        else if(pin.Buffer.Length < size)
        {
            pin.Dispose();
            pin = new BufferPin(size);
        }
        ptr = pin.Start;
        return pin.Count.ToInt32();
    }

    protected override void Dispose(bool disposing)
    {
        pin?.Dispose();
        pin = null;
    }

    public override ArraySegment<byte> Retrieve(int size)
    {
        var ret = new byte[size];
        Array.Copy(Buffer, 0, ret, 0, size);
        return new ArraySegment<byte>(ret);
    }
}
