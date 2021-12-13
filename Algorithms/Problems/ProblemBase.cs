namespace Algorithms.Problems;

public abstract class ProblemBase<T, TResult>
{
    protected abstract T GetInput();
    protected abstract T GetTestInput();

    protected abstract TResult SolvePartA(T input);
    protected abstract TResult SolvePartB(T input);

    protected virtual void PrintResult(TResult result)
    {
        Console.WriteLine($"Result {result?.ToString()}");
    }

    public void Solve(Part part, bool isTest)
    {
        var input = isTest ? GetTestInput() : GetInput();

        var result = part switch
        {
            Part.PartA => SolvePartB(input),
            Part.PartB => SolvePartB(input),
            _ => throw new ArgumentOutOfRangeException(nameof(part), part, null)
        };

        PrintResult(result);
    }
}

public enum Part
{
    PartA,
    PartB
}