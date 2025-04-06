using HashSet;

public class MyClass
{
    public static void Main(string[] args)
    {
        IMyHashSet<int> set = new MyHashSet<int>();
        set.Add(10);
        set.Add(20);
        set.Add(10); 

        Console.WriteLine(set.Contains(10)); 
        Console.WriteLine(set.Contains(30)); 

        set.Remove(10);
        Console.WriteLine(set.Contains(10)); 
    }
}