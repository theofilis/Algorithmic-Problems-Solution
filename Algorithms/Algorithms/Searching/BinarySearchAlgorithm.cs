namespace Algorithms.Algorithms.Searching;

public class BinarySearchAlgorithm<T>
{
    private readonly T[] _items;

    public BinarySearchAlgorithm(T[] items)
    {
        _items = items;
    }

    public int Search(IEnumerable<T> item, Func<IEnumerable<T>, T, int> predicate)
    {
        var minPosition = 0;
        var maxPosition = _items.Length - 1;

        while (minPosition <= maxPosition)
        {
            var mid = (minPosition + maxPosition) / 2;
            var score = predicate(item, _items[mid]);
            switch (score)
            {
                case 0:
                    return mid;
                case > 0:
                    maxPosition = mid - 1;
                    break;
                default:
                    minPosition = mid + 1;
                    break;
            }
        }

        return -1;
    }

    public int Search(T item, Func<T, T, int> predicate)
    {
        return Search(new[] { item }, ((aItems, b) => predicate(aItems.First(), b)));
    }
}