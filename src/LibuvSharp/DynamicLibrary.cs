using System.Runtime.InteropServices;
using static LibuvSharp.Libuv;


namespace LibuvSharp;

public abstract class DynamicLibrary
{
	public static string Decorate(string name)
	{
		return UV.isUnix ? $"lib{name}.so" : $"{name}.dll";
	}

	public static DynamicLibrary Open(string name)
	{
		if (UV.isUnix) {
			return new LibuvDynamicLibrary(name);
		}

		return new WindowsDynamicLibrary(name);
	}

	public static DynamicLibrary Open()
	{
		if (UV.isUnix) {
			return new LibuvDynamicLibrary();
		}

		return new WindowsDynamicLibrary();
	}

	public abstract bool Closed { get; }
	public abstract void Close();
	public abstract bool TryGetSymbol(string name, out IntPtr pointer);
	public abstract IntPtr GetSymbol(string name);
}

internal class LibuvDynamicLibrary : DynamicLibrary
{
	private IntPtr handle = IntPtr.Zero;

	public override bool Closed => handle == IntPtr.Zero;

	private void Check(int ret)
	{
		if (ret < 0) {
			throw new Exception(Marshal.PtrToStringAnsi(uv_dlerror(handle)));
		}
	}

	public LibuvDynamicLibrary()
	{
		handle = Marshal.AllocHGlobal(28);
		Check(uv_dlopen(IntPtr.Zero, handle));
	}

	public LibuvDynamicLibrary(string library)
	{
		library.NotNull("library");

		handle = Marshal.AllocHGlobal(28);
		Check(uv_dlopen(library, handle));
	}

	public override void Close()
	{
		if (!Closed) {
			uv_dlclose(handle);
			handle = IntPtr.Zero;
		}
	}

	public override bool TryGetSymbol(string name, out IntPtr pointer)
	{
		pointer = IntPtr.Zero;
		return uv_dlsym(handle, name, out pointer) == 0;
	}

	public override IntPtr GetSymbol(string name)
	{
		var ptr = IntPtr.Zero;
		if (uv_dlsym(handle, name, out ptr) < 0) {
			throw new Exception(Marshal.PtrToStringAnsi(uv_dlerror(handle)));
		}
		return ptr;
	}
}

internal class WindowsDynamicLibrary : DynamicLibrary
{
	private IntPtr handle = IntPtr.Zero;

	public void Check(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero) {
			throw new Exception();
		}

		handle = ptr;
	}

	public WindowsDynamicLibrary()
	{
		Check(LoadLibraryEx(IntPtr.Zero, IntPtr.Zero, LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH));
	}

	public WindowsDynamicLibrary(string name)
	{
		name.NotNull("name");

		Check(LoadLibraryEx(name, IntPtr.Zero, LoadLibraryFlags.LOAD_WITH_ALTERED_SEARCH_PATH));
	}

	public override bool Closed => handle == IntPtr.Zero;

	public override void Close()
	{
		if (!Closed) {
			FreeLibrary(handle);
			handle = IntPtr.Zero;
		}
	}

	public override IntPtr GetSymbol(string name)
	{
		var ptr = GetProcAddress(handle, name);
		if (ptr == IntPtr.Zero) {
			throw new Exception();
		}
		return ptr;
	}

	public override bool TryGetSymbol(string name, out IntPtr pointer)
	{
		pointer = GetProcAddress(handle, name);
		return pointer != IntPtr.Zero;
	}
}