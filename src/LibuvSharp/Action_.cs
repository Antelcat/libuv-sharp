using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp.Delegates;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void Action_();