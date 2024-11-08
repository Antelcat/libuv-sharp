using Antelcat.LibuvSharp.Extensions;

namespace Antelcat.LibuvSharp.Threading.Tasks;

public static class UVDirectoryAsync
{
    public static Task Create(string name)
    {
        return Create(Loop.Constructor, name);
    }

    public static Task Create(Loop loop, string name)
    {
        return WrapExtensions.Wrap(loop, name, UVDirectory.Create);
    }

    public static Task Create(string name, int mode)
    {
        return Create(Loop.Constructor, name, mode);
    }

    public static Task Create(Loop loop, string name, int mode)
    {
        return WrapExtensions.Wrap(loop, name, mode, UVDirectory.Create);
    }

    public static Task Delete(string path)
    {
        return Delete(Loop.Constructor, path);
    }

    public static Task Delete(Loop loop, string path)
    {
        return WrapExtensions.Wrap(loop, path, UVDirectory.Delete);
    }

    public static Task Rename(string path, string newPath)
    {
        return Rename(Loop.Constructor, path, newPath);
    }

    public static Task Rename(Loop loop, string path, string newPath)
    {
        return WrapExtensions.Wrap(loop, path, newPath, UVDirectory.Rename);
    }

    public static Task<UVDirectoryEntity[]?> Read(string path)
    {
        return Read(Loop.Constructor, path);
    }

    public static Task<UVDirectoryEntity[]?> Read(this Loop loop, string path)
    {
        return WrapExtensions.Wrap<Loop, string, UVDirectoryEntity[]>(loop, path, UVDirectory.Read);
    }
}
