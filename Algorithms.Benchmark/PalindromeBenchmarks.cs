using Algorithms.Algorithms.DynamicProgramming;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmark;

public class PalindromeBenchmarks
{
    [Benchmark]
    public void Scenario1()
    {
        var p = Palindrome.Search("rapanaki");
    }
}