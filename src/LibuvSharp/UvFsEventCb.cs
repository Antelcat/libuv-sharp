using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void UvFsEventCb(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string filename, int events, int status);