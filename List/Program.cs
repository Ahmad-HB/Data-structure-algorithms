
class MyClass
{
    static void Main(string[] args)
    {
        List.List l1 = new List.List(2);
    
        l1.add(1);
        l1.add(2);
        l1.add(3);
        l1.add(4);

        l1.print();

        Console.WriteLine("===========");
        Console.WriteLine(l1.size());
        Console.WriteLine("===========");
        Console.WriteLine(l1.removeLastIndex());
        Console.WriteLine("===========");
        Console.WriteLine(l1.size());
        Console.WriteLine("===========");
        l1.print();
        Console.WriteLine("===========");
        Console.WriteLine(l1.get(2));
        Console.WriteLine("===========");
        Console.WriteLine(l1.removeAtIndex(1));
        Console.WriteLine("===========");
        l1.print();
    
    }
}