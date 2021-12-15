using Algorithms.Algorithms.DynamicProgramming;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmark;

public class PalindromeBenchmarks
{
    [Benchmark]
    public void Scenario1()
    {
        const string word = "rapanaki";
        var result = Palindrome.Search(word);
    }
}