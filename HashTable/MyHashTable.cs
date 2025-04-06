namespace HashTable;

public class MyHashTable<K, V> : IMyHashTable<K,V>
{
    private readonly int size = 100;
    private Entry<K, V>[] buckets;

    public MyHashTable()
    {
        buckets = new Entry<K, V>[size];
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % size;
    }

    public void Add(K key, V value)
    {
        int index = GetBucketIndex(key);
        Entry<K, V> head = buckets[index];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                head.Value = value;
                return;
            }
            head = head.Next;
        }

        Entry<K, V> newEntry = new Entry<K, V>(key, value)
        {
            Next = buckets[index]
        };

        buckets[index] = newEntry;
    }

    public bool TryGetValue(K key, out V value)
    {
        int index = GetBucketIndex(key);
        Entry<K, V> head = buckets[index];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                value = head.Value;
                return true;
            }
            head = head.Next;
        }

        value = default;
        return false;
    }

    public bool Remove(K key)
    {
        int index = GetBucketIndex(key);
        Entry<K, V> head = buckets[index];
        Entry<K, V> prev = null;

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                if (prev == null)
                    buckets[index] = head.Next;
                else
                    prev.Next = head.Next;
                return true;
            }

            prev = head;
            head = head.Next;
        }

        return false;
    }

    public bool ContainsKey(K key)
    {
        return TryGetValue(key, out _);
    }
}