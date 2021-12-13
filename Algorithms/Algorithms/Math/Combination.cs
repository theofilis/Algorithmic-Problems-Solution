namespace Algorithms.Algorithms.Math;

public static class CombinationExtensions
{
    public static IEnumerable<IEnumerable<T>> GetPermutationsWithRepetition<T>(this IEnumerable<T> enumerable,
        int length)
    {
        if (length == 1) return enumerable.Select(t => new[] { t });
        var array = enumerable.ToArray();
        return GetPermutationsWithRepetition(array, length - 1)
            .SelectMany(t => array,
                (t1, t2) => t1.Concat(new[] { t2 }));
    }

    public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IEnumerable<T> enumerable, int length)
    {
        if (length == 1) return enumerable.Select(t => new[] { t });
        var array = enumerable.ToArray();
        return GetPermutations(array, length - 1)
            .SelectMany(t => array.Where(o => !t.Contains(o)),
                (t1, t2) => t1.Concat(new[] { t2 }));
    }

    public static IEnumerable<IEnumerable<T>> GetKCombinations<T>(IEnumerable<T> enumerable, int length)
        where T : IComparable
    {
        if (length == 1) return enumerable.Select(t => new[] { t });
        var array = enumerable.ToArray();
        return GetKCombinations(array, length - 1)
            .SelectMany(t => array.Where(o => o.CompareTo(t.Last()) > 0),
                (t1, t2) => t1.Concat(new[] { t2 }));
    }
}