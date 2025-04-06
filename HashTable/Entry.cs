namespace HashTable;

public class Entry<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
    public Entry<K, V> Next { get; set; }

    public Entry(K key, V value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}