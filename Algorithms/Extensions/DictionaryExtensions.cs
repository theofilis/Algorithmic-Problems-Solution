using System.Text;

namespace Algorithms.Extensions;

public static class DictionaryExtensions
{
    public static string ToPrettyString(this Dictionary<(int i, int j), bool> dictionary, int n)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (dictionary.ContainsKey((i, j)))
                {
                    sb.Append($"{Convert.ToInt16(dictionary[(i, j)])} ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }

            sb.AppendLine();
        }

        return sb.ToString();
    }
}