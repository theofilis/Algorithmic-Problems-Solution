using BenchmarkDotNet.Running;

namespace Algorithms.Benchmark;

public class Program
{
    public static int Main(string[] args)
    {
        try
        {
            BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(args);

            return 0;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            return 1;
        }
    }
}