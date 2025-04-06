namespace HashSet;

public interface IMyHashSet<T>
{
    void Add(T item);
    bool Remove(T item);
    bool Contains(T item);
    
}