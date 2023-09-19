using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;

namespace LibuvSharp;

internal struct uv_cpu_times_t
{
	public ulong user;
	public ulong nice;
	public ulong sys;
	public ulong idle;
	public ulong irq;
}

internal struct uv_cpu_info_t
{
	public IntPtr model;
	public int speed;
	public uv_cpu_times_t cpu_times;
}

public class CpuTimes
{
	internal CpuTimes(uv_cpu_times_t times)
	{
		User = times.user;
		Nice = times.nice;
		System = times.sys;
		Idle = times.idle;
		IRQ = times.irq;
	}

	public ulong User { get; protected set; }
	public ulong Nice { get; protected set; }
	public ulong System { get; protected set; }
	public ulong Idle { get; protected set; }
	public ulong IRQ { get; protected set; }
}

public unsafe class CpuInformation
{
	internal CpuInformation(uv_cpu_info_t *info)
	{
		Name = Marshal.PtrToStringAnsi(info->model);
		Speed = info->speed;
		Times = new CpuTimes(info->cpu_times);
	}

	public string Name { get; protected set; }
	public int Speed { get; protected set; }
	public CpuTimes Times { get; protected set; }
	
	internal static CpuInformation[] GetInfo()
	{
		IntPtr info;
		int count;
		var r = uv_cpu_info(out info, out count);
		r.Success();

		CpuInformation[] ret = new CpuInformation[count];

		for (var i = 0; i < count; i++) {
			var cpuinfo = (uv_cpu_info_t *)(info.ToInt64() + i * sizeof(uv_cpu_info_t));
			ret[i] = new CpuInformation(cpuinfo);
		}

		uv_free_cpu_info(info, count);

		return ret;
	}
}

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct uv_interface_address_t
{
	public IntPtr name;
	public fixed byte phys_addr[6];
	public int is_internal;
	public sockaddr_in6 sockaddr;
	public sockaddr_in6 netmask;
}

public unsafe class NetworkInterface
{
	internal NetworkInterface(uv_interface_address_t *iFace)
	{
		Name = Marshal.PtrToStringAnsi(iFace->name)!;
		Internal = iFace->is_internal != 0;
		var physAddr = new byte[6];
		for (var i = 0; i < physAddr.Length; i++) {
			physAddr[i] = iFace->phys_addr[i];
		}
		PhysicalAddress = new PhysicalAddress(physAddr);
		Address = UV.GetIPEndPoint(new IntPtr(&iFace->sockaddr), false).Address;
		Netmask = UV.GetIPEndPoint(new IntPtr(&iFace->netmask), false).Address;
	}

	public string Name { get; protected set; }
	public bool Internal { get; protected set; }
	public PhysicalAddress PhysicalAddress { get; protected set; }
	public IPAddress Address { get; protected set; }
	public IPAddress Netmask { get; protected set; }

	internal static NetworkInterface[] GetInterfaces()
	{
		uv_interface_addresses(out var interfaces, out var count).Success();
		var ret = new NetworkInterface[count];
		for (var i = 0; i < count; i++)
		{
			var iFace = (uv_interface_address_t*)(interfaces.ToInt64() + i * sizeof(uv_interface_address_t));
			ret[i] = new NetworkInterface(iFace);
		}

		uv_free_interface_addresses(interfaces, count);
		return ret;
	}
}

public unsafe class LoadAverage
{

	internal LoadAverage()
	{
		var ptr = Marshal.AllocHGlobal(sizeof(double) * 3);
		uv_loadavg(ptr);
		Last    = *(double*)ptr;
		Five    = *(double*)(ptr.ToInt64() + sizeof(double));
		Fifteen = *(double*)(ptr.ToInt64() + sizeof(double) * 2);
		Marshal.FreeHGlobal(ptr);
	}

	public double Last { get; protected set; }
	public double Five { get; protected set; }
	public double Fifteen { get; protected set; }

}

public static class Computer
{
	public static class Memory
	{
		public static long Free => uv_get_free_memory();

		public static long Total => uv_get_total_memory();

		public static long Used => Total - Free;
	}

	public static ulong HighResolutionTime => uv_hrtime();

	public static LoadAverage Load => new();

	public static NetworkInterface[] NetworkInterfaces => NetworkInterface.GetInterfaces();

	public static CpuInformation[] CpuInfo => CpuInformation.GetInfo();

	public static double Uptime {
		get {
			uv_uptime(out var uptime).Success();
			return uptime;
		}
	}
}