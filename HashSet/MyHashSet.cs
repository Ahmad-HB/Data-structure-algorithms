using HashTable;

namespace HashSet;

public class MyHashSet<T> : IMyHashSet<T>
{
    private readonly IMyHashTable<T, bool> table;

    public MyHashSet()
    {
        table = new MyHashTable<T, bool>();
    }

    public void Add(T item)
    {
        table.Add(item, true);
    }

    public bool Remove(T item)
    {
        return table.Remove(item);
    }

    public bool Contains(T item)
    {
        return table.ContainsKey(item);
    }
}