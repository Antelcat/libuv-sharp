using System.Runtime.InteropServices;

namespace LibuvSharp.Internal;

[StructLayout(LayoutKind.Sequential)]
internal struct uv_handle_t
{
    // public
    public IntPtr data;

    // read only
    public IntPtr loop;

    public HandleType type;

    // private
    public IntPtr close_cb;

    // TODO: implement nginx queue
}
