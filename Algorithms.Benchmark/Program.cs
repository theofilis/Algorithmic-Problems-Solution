using BenchmarkDotNet.Running;

namespace Algorithms.Benchmark;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<PalindromeBenchmarks>();
    }
}