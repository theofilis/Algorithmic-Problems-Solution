using Algorithms.Algorithms.Math;
using Algorithms.Algorithms.Searching;
using Algorithms.Extensions;

namespace Algorithms.Problems.Y2020;

public class Day1 : ProblemBase<int[], int>
{
    protected override string Year => "2020";

    protected override string Day => "01";

    protected override int[] Parse(string path)
    {
        return path
            .ReadInput()
            .ToIntegerArray()
            .OrderByDescending(line => line)
            .ToArray();
    }

    protected override Task<int> SolvePartA(int[] numbers)
    {
        foreach (var number in numbers)
        {
            var strategy = new BinarySearchAlgorithm<int>(numbers);
            var position = strategy.Search(number, (a, b) => 2020 - (a + b));
            if (position <= 0) continue;
            // Console.WriteLine($"A = {numbers[position]}, B = {number}, O = {numbers[position] * number}");
            return Task.FromResult(numbers[position] * number);
        }

        return Task.FromResult(-1);
    }

    protected override Task<int> SolvePartB(int[] instances)
    {
        var permutations = instances
            .GetPermutations(2)
            .Where(c => c.Sum() < 2020)
            .ToArray();

        foreach (var permutation in permutations)
        {
            var strategy = new BinarySearchAlgorithm<int>(instances);
            var numbers = permutation.ToArray();
            var position = strategy.Search(numbers, (a, b) => 2020 - (a.Sum() + b));
            if (position <= 0) continue;
            // Console.WriteLine($"A={numbers[0]}, B={numbers[1]}, C={inputs[position]} S={numbers[0] * numbers[1] * inputs[position]}");
            return Task.FromResult(numbers[0] * numbers[1] * instances[position]);
        }

        return Task.FromResult(-1);
    }
}