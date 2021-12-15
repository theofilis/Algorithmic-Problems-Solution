using Algorithms.Problems;
using Algorithms.Problems.Y2020;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmark;

public class ProblemBenchmark
{
    [Benchmark]
    public void SolvePart1() =>
        new Day2().Solve(Part.PartA, false);

    [Benchmark]
    public void SolvePart2() =>
        new Day2().Solve(Part.PartB, false);
}