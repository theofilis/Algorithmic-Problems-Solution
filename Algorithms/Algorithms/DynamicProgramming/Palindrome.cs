namespace Algorithms.Algorithms.DynamicProgramming;

public static class Palindrome
{
    public static Dictionary<(int i, int j), bool> Search(string word)
    {
        var d = new Dictionary<(int i, int j), bool>();
        var n = word.Length;

        for (var i = 0; i < n; i++)
        {
            d[(i, i)] = true;
        }

        for (var i = 0; i < n - 1; i++)
        {
            d[(i, i + 1)] = word[i] == word[i + 1];
        }

        for (var s = 2; s < n - 1; s++)
        {
            for (var i = 0; i < n - s; i++)
            {
                d[(i, i + s)] = word[i] == word[i + s] && d[(i + 1, i + s - 1)];
            }
        }

        return d;
    }
}