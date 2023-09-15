using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void UvGetnameinfoCb(IntPtr req, int status, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string hostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string service);