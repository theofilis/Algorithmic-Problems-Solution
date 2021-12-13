namespace Algorithms.Extensions;

public static class InputExtensions
{
    public static int[] ToIntegerArray(this string input) =>
        input.Split(Environment.NewLine).Select(int.Parse).ToArray();
}