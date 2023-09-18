using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void UvRandomCb(IntPtr req, int status, IntPtr buf, ulong buflen);