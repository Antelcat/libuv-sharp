using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace LibuvSharp.Generator;

public partial class Generator : ILibrary
{
    private readonly string dir = Assembly.GetExecutingAssembly().Location;
    
    public void Preprocess(Driver driver, ASTContext ctx)
    {
        var options = driver.Options;
        options.OutputDir = Path.Combine(
            Path.GetDirectoryName( Path.GetDirectoryName(
                LibuvSharpRegex().Matches(dir).FirstOrDefault()!.Value)
            ),$"{nameof(LibuvSharp)}");
        Debugger.Break();
    }

    public void Postprocess(Driver driver, ASTContext ctx)
    {
        
    }

    public void Setup(Driver driver)
    {
        var include = Path.Combine(LibuvRegex().Matches(dir).FirstOrDefault()!.Value, "libuv");
        var options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;
        var module = options.AddModule(nameof(LibuvSharp));
        module.IncludeDirs.Add(include);
        module.Headers.Add("uv.h");
    }

    public void SetupPasses(Driver driver)
    {
    }

    [GeneratedRegex(@"\S*libuv-sharp[\\|/]")]
    private static partial Regex LibuvRegex();
    
    [GeneratedRegex($@"\S*{nameof(LibuvSharp)}.{nameof(Generator)}[\\|/]")]
    private static partial Regex LibuvSharpRegex();
}