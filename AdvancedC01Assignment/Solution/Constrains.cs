namespace Solution;

public static class Constrains
{
    public static List<T>? SafeList<T>(List<T> items)
    {
        if (items.Count == 0) return default;
        return items;
    }
}
