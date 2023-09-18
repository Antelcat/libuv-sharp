using System.Runtime.InteropServices;
using System.Security;
using CppSharp.Runtime;

namespace LibuvSharp;

[SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void UvFsEventCb(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] string filename, int events, int status);