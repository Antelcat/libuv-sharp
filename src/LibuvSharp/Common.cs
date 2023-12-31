using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

[StructLayout(LayoutKind.Sequential)]
internal struct sockaddr
{
    public short sin_family;
    public ushort sin_port;
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
internal struct sockaddr_in
{
    public int a, b, c, d;
}

[StructLayout(LayoutKind.Sequential, Size = 28)]
internal struct sockaddr_in6
{
    public int a, b, c, d, e, f, g;
}

public static class UV
{
    internal static readonly unsafe int PointerSize = sizeof(IntPtr) / 4;

    internal static bool isUnix = Environment.OSVersion.Platform == PlatformID.Unix ||
                                  Environment.OSVersion.Platform == PlatformID.MacOSX;

    internal static bool IsUnix => isUnix;

    internal static sockaddr_in ToStruct(string ip, int port)
    {
        sockaddr_in address;
        var r = uv_ip4_addr(ip, port, out address);
        r.Success();
        return address;
    }

    internal static sockaddr_in6 ToStruct6(string ip, int port)
    {
        sockaddr_in6 address;
        var r = uv_ip6_addr(ip, port, out address);
        r.Success();
        return address;
    }


    internal static ushort ntohs(ushort bytes)
    {
        return isUnix ? ntohs_unix(bytes) : ntohs_win(bytes);
    }


    private static bool IsMapping(byte[] data)
    {
        if (data.Length != 16)
        {
            return false;
        }

        for (var i = 0; i < 10; i++)
        {
            if (data[i] != 0)
            {
                return false;
            }
        }

        return data[10] == data[11] && data[11] == 0xff;
    }

    private static IPAddress GetMapping(byte[] data)
    {
        var ip = new byte[4];
        for (var i = 0; i < 4; i++)
        {
            ip[i] = data[12 + i];
        }

        return new IPAddress(ip);
    }

    internal static unsafe IPEndPoint GetIPEndPoint(IntPtr sockAddr, bool map)
    {
        var sa = (sockaddr*)sockAddr;
        var addr = new byte[64];
        var r = sa->sin_family == 2
            ? uv_ip4_name(sockAddr, addr, (IntPtr)addr.Length)
            : uv_ip6_name(sockAddr, addr, (IntPtr)addr.Length);
        r.Success();

        var ip = IPAddress.Parse(Encoding.ASCII.GetString(addr, 0, strlen(addr)));

        var bytes = ip.GetAddressBytes();
        if (map && ip.AddressFamily == AddressFamily.InterNetworkV6 && IsMapping(bytes))
        {
            ip = GetMapping(bytes);
        }

        return new IPEndPoint(ip, ntohs(sa->sin_port));
    }

    private static int strlen(IReadOnlyList<byte> bytes)
    {
        var i = 0;
        while (i < bytes.Count && bytes[i] != 0)
        {
            i++;
        }

        return i;
    }


    internal static int Sizeof(RequestType type)
    {
        return uv_req_size(type);
    }

#if DEBUG
    private static readonly HashSet<IntPtr> Pointers = new();
#endif

    internal static IntPtr Alloc(RequestType type)
    {
        return Alloc(Sizeof(type));
    }

    internal static IntPtr Alloc(HandleType type)
    {
        return Alloc(Handle.Size(type));
    }

    internal static IntPtr Alloc(int size)
    {
        var ptr = Marshal.AllocHGlobal(size);
#if DEBUG
        Pointers.Add(ptr);
#endif
        return ptr;
    }

    internal static void Free(IntPtr ptr)
    {
#if DEBUG
        if (Pointers.Contains(ptr))
        {
            Pointers.Remove(ptr);
            Marshal.FreeHGlobal(ptr);
        }
        else
        {
            Console.WriteLine("{0} not allocated", ptr);
        }
#else
			Marshal.FreeHGlobal(ptr);
#endif
    }
#if DEBUG
    public static int PointerCount => Pointers.Count;

    public static void PrintPointers()
    {
        var e = Pointers.GetEnumerator();
        Console.Write("[");
        if (e.MoveNext())
        {
            Console.Write(e.Current);
            while (e.MoveNext())
            {
                Console.Write(", ");
                Console.Write(e.Current);
            }
        }

        Console.WriteLine("]");
    }
#endif


    public static void GetVersion(out int major, out int minor, out int patch)
    {
        var version = uv_version();
        major = (int)(version & 0xFF0000) >> 16;
        minor = (int)(version & 0xFF00) >> 8;
        patch = (int)(version & 0xFF);
    }

    public static Version Version
    {
        get
        {
            int major, minor, patch;
            GetVersion(out major, out minor, out patch);
            return new Version(major, minor, patch);
        }
    }

    public static unsafe string VersionString => new(uv_version_string());

    public static bool IsPreRelease => VersionString.EndsWith("-pre");

    internal delegate int uv_getsockname(IntPtr handle, IntPtr addr, ref int length);

    internal static unsafe IPEndPoint GetSockname(Handle handle, uv_getsockname getsockname)
    {
        sockaddr_in6 addr;
        var ptr = new IntPtr(&addr);
        var length = sizeof(sockaddr_in6);
        var r = getsockname(handle.NativeHandle, ptr, ref length);
        r.Success();
        return GetIPEndPoint(ptr, true);
    }

    internal delegate int bind(IntPtr handle, ref sockaddr_in sockaddr, uint flags);

    internal delegate int bind6(IntPtr handle, ref sockaddr_in6 sockaddr, uint flags);

    internal static void Bind(Handle handle, bind bind, bind6 bind6, IPAddress ipAddress, int port, bool dualstack)
    {
        Ensure.AddressFamily(ipAddress);

        int r;
        if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
        {
            var address = ToStruct(ipAddress.ToString(), port);
            r = bind(handle.NativeHandle, ref address, 0);
        }
        else
        {
            var address = ToStruct6(ipAddress.ToString(), port);
            r = bind6(handle.NativeHandle, ref address, (uint)(dualstack ? 0 : 1));
        }

        r.Success();
    }

    internal delegate int callback(IntPtr handle, ref IntPtr size);

    internal static string ToString(int size, callback func)
    {
        var ptr = IntPtr.Zero;
        try
        {
            ptr = Marshal.AllocHGlobal(size);
            var sizePointer = (IntPtr)size;
            var r = func(ptr, ref sizePointer);
            r.Success();
            return Marshal.PtrToStringAuto(ptr, sizePointer.ToInt32());
        }
        finally
        {
            if (ptr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }

    internal static string ToString(int size, Func<IntPtr, IntPtr, int> func)
    {
        var ptr = IntPtr.Zero;
        try
        {
            ptr = Marshal.AllocHGlobal(size);
            var r = func(ptr, (IntPtr)size);
            r.Success();
            return Marshal.PtrToStringAuto(ptr);
        }
        finally
        {
            if (ptr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}