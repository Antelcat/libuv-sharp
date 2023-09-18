using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp.Delegates;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void Action___IntPtr_int(IntPtr w, int status);