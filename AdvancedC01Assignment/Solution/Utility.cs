namespace Solution;

public static class Utility
{
    public static void Swap<T>(T a, T b) => (_, _) = (b, a);

    public static void FindMax<T>(List<T> list) where T : IComparable
    {
        if (list.Count == 0) return;
        T max = list[0];
        foreach (T i in list)
        {
            if (i.CompareTo(max) > 0) max = i;
        }
        Console.WriteLine(max);
    }
}
