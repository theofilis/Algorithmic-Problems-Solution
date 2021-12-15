namespace Algorithms.Problems;

public abstract class ProblemBase<T, TResult>
{
    protected abstract string Year { get; }

    protected abstract string Day { get; }

    protected abstract T Parse(string path);

    protected abstract Task<TResult> SolvePartA(T input);

    protected abstract Task<TResult> SolvePartB(T instances);

    protected virtual Task PrintResult(TResult result)
    {
        Console.WriteLine($"Result {result?.ToString()}");
        return Task.CompletedTask;
    }

    public async ValueTask<TResult> Solve(Part part, bool isTest)
    {
        var input = isTest ? GetTestInput() : GetInput();

        var result = part switch
        {
            Part.PartA => await SolvePartA(input),
            Part.PartB => await SolvePartB(input),
            _ => throw new ArgumentOutOfRangeException(nameof(part), part, null)
        };

        await PrintResult(result);
        return result;
    }

    protected virtual T GetInput()
        => Parse(Path.Combine("Inputs", Year, "Inputs", $"{Day}.txt"));

    protected virtual T GetTestInput()
        => Parse(Path.Combine("Inputs", Year, "Tests", $"{Day}.txt"));
}