using Algorithms.Problems;
using Algorithms.Problems.Y2020;

namespace Algorithms;

public class Program
{
    public static void Main()
    {
        // var word = "rapanaki";
        // var d = Palindrome.Search(word);
        // Console.WriteLine(d.ToPrettyString(word.Length));

        var d = new Day1();

        d.Solve(Part.PartA, false);
    }
}