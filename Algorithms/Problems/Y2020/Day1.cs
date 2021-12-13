using Algorithms.Algorithms.Math;
using Algorithms.Algorithms.Searching;
using Algorithms.Extensions;

namespace Algorithms.Problems.Y2020;

public class Day1 : ProblemBase<int[], int>
{
    protected override int[] GetInput()
    {
        return Path.Combine("Inputs", "2020", "Day1", "Input.txt")
            .ReadInput()
            .ToIntegerArray()
            .OrderByDescending(line => line)
            .ToArray();
    }

    protected override int[] GetTestInput()
    {
        return Path.Combine("Inputs", "2020", "Day1", "Test.txt")
            .ReadInput()
            .ToIntegerArray()
            .OrderByDescending(line => line)
            .ToArray();
    }

    protected override int SolvePartA(int[] numbers)
    {
        foreach (var number in numbers)
        {
            var strategy = new BinarySearchAlgorithm<int>(numbers);
            var position = strategy.Search(number, (a, b) => 2020 - (a + b));
            if (position <= 0) continue;
            Console.WriteLine($"A = {numbers[position]}, B = {number}, O = {numbers[position] * number}");
            return numbers[position] * number;
        }

        return -1;
    }

    protected override int SolvePartB(int[] inputs)
    {
        var permutations = inputs
            .GetPermutations(2)
            .Where(c => c.Sum() < 2020)
            .ToArray();

        foreach (var permutation in permutations)
        {
            var strategy = new BinarySearchAlgorithm<int>(inputs);
            var numbers = permutation.ToArray();
            var position = strategy.Search(numbers, (a, b) => 2020 - (a.Sum() + b));
            if (position <= 0) continue;
            Console.WriteLine(
                $"A={numbers[0]}, B={numbers[1]}, C={inputs[position]} S={numbers[0] * numbers[1] * inputs[position]}");
            return numbers[0] * numbers[1] * inputs[position];
        }

        return -1;
    }
}