namespace Solution;

public class Container<T>
{
    public int Count { get; set; }
    public void Add() => Count++;
    public int GetCount() => Count;
}
