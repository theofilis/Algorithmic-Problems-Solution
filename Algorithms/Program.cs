using Algorithms.Problems;
using Algorithms.Problems.Y2020;

namespace Algorithms;

public class Program
{
    public static async Task Main()
    {
        // var word = "rapanaki";
        // var d = Palindrome.Search(word);
        // Console.WriteLine(d.ToPrettyString(word.Length));

        var d = new Day2();
        await d.Solve(Part.PartB, false);
    }
}