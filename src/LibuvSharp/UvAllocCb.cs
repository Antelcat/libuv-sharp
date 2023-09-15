using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

/// <summary>
/// <para>It should be possible to cast uv_buf_t[] to WSABUF[]</para>
/// <para>see http://msdn.microsoft.com/en-us/library/ms741542(v=vs.85).aspx</para>
/// </summary>
[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void UvAllocCb(IntPtr handle, ulong suggested_size, IntPtr buf);