using HashTable;

public class MyClass
{
    public static void Main(string[] args)
    {
        IMyHashTable<string, int> table = new MyHashTable<string, int>();
        table.Add("one", 1);
        table.Add("two", 2);

        if (table.TryGetValue("two", out var value))
            Console.WriteLine("Found: " + value);

        Console.WriteLine(table.ContainsKey("one"));
        table.Remove("one");
        Console.WriteLine(table.ContainsKey("one"));
    }
}