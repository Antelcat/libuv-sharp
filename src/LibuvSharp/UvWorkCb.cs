using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void UvWorkCb(IntPtr req);