using Algorithms.Extensions;

namespace Algorithms.Problems.Y2020;

public readonly record struct Instance(int Min, int Max, char Character, string Password);

public class Day2 : ProblemBase<Instance[], int>
{
    protected override string Year => "2020";

    protected override string Day => "02";

    protected override Instance[] Parse(string path)
    {
        return path
            .ReadInput()
            .Split(Environment.NewLine)
            .Select(c =>
            {
                var parts = c.Split(":");
                var password = parts[1].Trim();
                var rule = parts[0].Split(" ");
                var character = rule[1];
                var limits = rule[0].Split("-");
                return new Instance(int.Parse(limits[0]), int.Parse(limits[1]), character[0], password);
            })
            .ToArray();
    }

    protected override Task<int> SolvePartA(Instance[] instances)
    {
        return Algorithm(instances, ValidatePartA);
    }

    protected override Task<int> SolvePartB(Instance[] instances)
    {
        return Algorithm(instances, ValidatePartB);
    }

    private Task<int> Algorithm(IEnumerable<Instance> instances, Func<Instance, bool> validate)
    {
        var valid = instances
            .AsParallel()
            .Select(c => validate(c) ? 1 : 0)
            .Sum();
        return Task.FromResult(valid);
    }

    private bool ValidatePartA(Instance instance)
    {
        var count = instance.Password.ToArray().Select(c => (c == instance.Character) ? 1 : 0).Sum();
        return instance.Min <= count && count <= instance.Max;
    }

    private bool ValidatePartB(Instance instance)
    {
        var pass = instance.Password.ToArray();

        var count = 0;

        if (pass[instance.Min - 1] == instance.Character)
        {
            count++;
        }

        if (pass[instance.Max - 1] == instance.Character)
        {
            count++;
        }

        return count == 1;
    }
}