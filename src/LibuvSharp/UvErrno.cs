﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LibuvSharp;

internal static class UvErrorExtension
{
    public static void Check(this int error,[CallerMemberName] string name = "")
    {
        if (error >= 0) return;
        throw new ExternalException($"Libuv method : [ {name} ] throw an exception : [ {(UvErrno)error} ]");
    }
}

public enum UvErrno : long
{
    NOERROR = 0, // My defined
    
    
    UV_E2BIG           = -4093,
    UV_EACCES          = -4092,
    UV_EADDRINUSE      = -4091,
    UV_EADDRNOTAVAIL   = -4090,
    UV_EAFNOSUPPORT    = -4089,
    UV_EAGAIN          = -4088,
    UV_EAI_ADDRFAMILY  = -3000,
    UV_EAI_AGAIN       = -3001,
    UV_EAI_BADFLAGS    = -3002,
    UV_EAI_BADHINTS    = -3013,
    UV_EAI_CANCELED    = -3003,
    UV_EAI_FAIL        = -3004,
    UV_EAI_FAMILY      = -3005,
    UV_EAI_MEMORY      = -3006,
    UV_EAI_NODATA      = -3007,
    UV_EAI_NONAME      = -3008,
    UV_EAI_OVERFLOW    = -3009,
    UV_EAI_PROTOCOL    = -3014,
    UV_EAI_SERVICE     = -3010,
    UV_EAI_SOCKTYPE    = -3011,
    UV_EALREADY        = -4084,
    UV_EBADF           = -4083,
    UV_EBUSY           = -4082,
    UV_ECANCELED       = -4081,
    UV_ECHARSET        = -4080,
    UV_ECONNABORTED    = -4079,
    UV_ECONNREFUSED    = -4078,
    UV_ECONNRESET      = -4077,
    UV_EDESTADDRREQ    = -4076,
    UV_EEXIST          = -4075,
    UV_EFAULT          = -4074,
    UV_EFBIG           = -4036,
    UV_EHOSTUNREACH    = -4073,
    UV_EINTR           = -4072,
    UV_EINVAL          = -4071,
    UV_EIO             = -4070,
    UV_EISCONN         = -4069,
    UV_EISDIR          = -4068,
    UV_ELOOP           = -4067,
    UV_EMFILE          = -4066,
    UV_EMSGSIZE        = -4065,
    UV_ENAMETOOLONG    = -4064,
    UV_ENETDOWN        = -4063,
    UV_ENETUNREACH     = -4062,
    UV_ENFILE          = -4061,
    UV_ENOBUFS         = -4060,
    UV_ENODEV          = -4059,
    UV_ENOENT          = -4058,
    UV_ENOMEM          = -4057,
    UV_ENONET          = -4056,
    UV_ENOPROTOOPT     = -4035,
    UV_ENOSPC          = -4055,
    UV_ENOSYS          = -4054,
    UV_ENOTCONN        = -4053,
    UV_ENOTDIR         = -4052,
    UV_ENOTEMPTY       = -4051,
    UV_ENOTSOCK        = -4050,
    UV_ENOTSUP         = -4049,
    UV_EOVERFLOW       = -4026,
    UV_EPERM           = -4048,
    UV_EPIPE           = -4047,
    UV_EPROTO          = -4046,
    UV_EPROTONOSUPPORT = -4045,
    UV_EPROTOTYPE      = -4044,
    UV_ERANGE          = -4034,
    UV_EROFS           = -4043,
    UV_ESHUTDOWN       = -4042,
    UV_ESPIPE          = -4041,
    UV_ESRCH           = -4040,
    UV_ETIMEDOUT       = -4039,
    UV_ETXTBSY         = -4038,
    UV_EXDEV           = -4037,
    UV_UNKNOWN         = -4094,
    UV_EOF             = -4095,
    UV_ENXIO           = -4033,
    UV_EMLINK          = -4032,
    UV_EHOSTDOWN       = -4031,
    UV_EREMOTEIO       = -4030,
    UV_ENOTTY          = -4029,
    UV_EFTYPE          = -4028,
    UV_EILSEQ          = -4027,
    UV_ESOCKTNOSUPPORT = -4025,
    UV_ENODATA         = -4024,
    UV_EUNATCH         = -4023,
    UV_ERRNO_MAX       = -4096
}