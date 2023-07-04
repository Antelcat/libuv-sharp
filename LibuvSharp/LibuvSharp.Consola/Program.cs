using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Parser;
using CppSharp.Passes;
using ClangParser = CppSharp.ClangParser;


namespace LibuvSharp.Consola;

public class Program
{
    public static async Task Main(string[] args)
    {
        await Run();
        //ConsoleDriver.Run(new Library());
        //ParseSourceFile(@"D:\Shared\WorkSpace\Git\libuv-sharp\LibuvSharp\libuv\include\uv.h");
    }

    internal static async Task Run()
    {
        TaskCompletionSource source = new();
        UvExitCb onExit = (ptr, status, signal) =>
        {
            Console.WriteLine(ptr);
            Console.WriteLine(status);
            Console.WriteLine(signal);
            source.SetResult();
        };
        var handle = new UvProcessS();
        var gen = (int i) =>
        {
            return new UvStdioContainerS
            {
                Flags = UvStdioFlags.UV_NONBLOCK_PIPE,
                data = new UvStdioContainerS.Data()
                {
                    Fd = i,
                    Stream = new UvStreamS()
                    {
                        ReadCb = (a, b, c) =>
                        {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                    }
                }
            };
        };
        var ios = new[]  
        {
            new UvStdioContainerS
            {
                Flags = UvStdioFlags.UV_IGNORE
            },
            gen(1),
            gen(2),
            gen(3),
            gen(4),
            gen(5),
            gen(6),
            gen(7),
        };
        var options = new UvProcessOptionsS
        {
            //File = @"D:\Shared\WorkSpace\Git\libuv-sharp\LibuvSharp\Debug\process.exe",
            File = @"D:\Shared\WorkSpace\Git\ThirdPart\Tubumu.Mediasoup\src\Tubumu.Meeting.Web\mediasoup-worker.exe",
            Stdio =  ios
        };
        //Console.WriteLine(options.Stdio);
        var id = uv.UvSpawn(new UvLoopS(), handle, options);
        Console.WriteLine(id); 
        await source.Task;
    }
    
    public class Library : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {
            driver.Options.GeneratorKind = GeneratorKind.CSharp; 
            var module = new Module("libuv");
            module.IncludeDirs.Add(@"D:\Shared\WorkSpace\Git\libuv-sharp\LibuvSharp\libuv\include\");
            module.Headers.Add(@"D:\Shared\WorkSpace\Git\libuv-sharp\LibuvSharp\libuv\include\uv.h");
            //module.Libraries.Add(@"D:\Shared\WorkSpace\Git\libuv-sharp\LibuvSharp\LibuvSharp.Test\bin\Debug\net7.0\runtimes\win-x64\native\libuv.dll");
            driver.Options.Modules.Add(module);
        }

        public void SetupPasses(Driver driver)
        {
        }
    }
    
    public static bool ParseSourceFile(string file)
    {
        // Lets setup the options for parsing the file.
        var parserOptions = new ParserOptions
        {
            LanguageVersion = LanguageVersion.CPP11,

            // Verbose here will make sure the parser outputs some extra debugging
            // information regarding include directories, which can be helpful when
            // tracking down parsing issues.
            Verbose = true
        };

        // This will setup the necessary system include paths and arguments for parsing.
        // It will probe into the registry (on Windows) and filesystem to find the paths
        // of the system toolchains and necessary include directories.
        parserOptions.Setup(TargetPlatform.Windows);

        // We create the Clang parser and parse the source code.
        var parserResult = CppSharp.Parser.ClangParser.ParseHeader(parserOptions);

        // If there was some kind of error parsing, then lets print some diagnostics.
        if (parserResult.Kind != ParserResultKind.Success)
        {
            if (parserResult.Kind == ParserResultKind.FileNotFound)
                Console.Error.WriteLine($"{file} was not found.");

            for (uint i = 0; i < parserResult.DiagnosticsCount; i++)
            {
                var diag = parserResult.GetDiagnostics(i);

                Console.WriteLine("{0}({1},{2}): {3}: {4}",
                    diag.FileName, diag.LineNumber, diag.ColumnNumber,
                    diag.Level.ToString().ToLower(), diag.Message);
            }

            parserResult.Dispose();
            return false;
        }

        // Now we can consume the output of the parser (syntax tree).

        // First we will convert the output, bindings for the native Clang AST,
        // to CppSharp's managed AST representation.
        var astContext = ClangParser.ConvertASTContext(parserOptions.ASTContext);

        // After its converted, we can dispose of the native AST bindings.
        parserResult.Dispose();

        // Now we can finally do what we please with the syntax tree.
        foreach (var sourceUnit in astContext.TranslationUnits)
            Console.WriteLine(sourceUnit.FileName);

        return true;
    }

}