namespace HashTable;

public interface IMyHashTable<K, V>
{
    void Add(K key, V value);
    bool Remove(K key);
    bool TryGetValue(K key, out V value);
    bool ContainsKey(K key);
}