// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main(string[] args)
    {
        
        Stack.Stack s = new Stack.Stack();
        s.push(10);
        s.push(20);
        s.push(60);
        s.push(30);
        s.push(80);
        s.push(70);
        s.push(90);
        s.print();
        Console.WriteLine("=============");
        Console.WriteLine(s.pop() + " Popped from stack");
        Console.WriteLine("=============");
        s.print();
        Console.WriteLine("=============");
        Console.WriteLine("Top element is :" + s.peek());
        Console.WriteLine("=============");
        s.print();
        Console.WriteLine("=============");
        Console.WriteLine(s.search(80));
        Console.WriteLine("=============");
        s.print();
    }
}