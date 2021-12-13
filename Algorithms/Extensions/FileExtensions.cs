namespace Algorithms.Extensions;

public static class FileExtensions
{
    public static string ReadInput(this string path)
    {
        return !File.Exists(path) ? "" : File.ReadAllText(path);
    }
}