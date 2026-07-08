namespace Solution;

public class CacheItem<TValue>(TValue value, DateTime expirationTime)
{
    public TValue Value { get; set; } = value;
    public DateTime ExpirationTime { get; set; } = expirationTime;
}

public class Cache<TKey, TValue> where TKey : notnull
{
    private readonly Dictionary<TKey, CacheItem<TValue>> cache = [];
    public void Add(TKey key, TValue value, TimeSpan duration)
    {
        cache[key] = new CacheItem<TValue>
        (
            value,
            DateTime.Now.Add(duration)
        );
    }
    public TValue? Get(TKey key)
    {
        if (!cache.TryGetValue(key, out CacheItem<TValue>? item))
            return default;

        if (DateTime.Now > item.ExpirationTime)
        {
            cache.Remove(key);
            return default;
        }
        return item.Value;
    }
    public bool Remove(TKey key) => cache.Remove(key);
    public bool Contains(TKey key) => cache.ContainsKey(key);
}