using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp.Delegates;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate uint Func_uint___IntPtr___IntPtr_uint(IntPtr __0, IntPtr __1, uint __2);