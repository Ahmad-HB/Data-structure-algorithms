

class MyClass
{
    static void Main(string[] args)
    {
        Queue.Queue queue = new Queue.Queue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Display();

        Console.WriteLine("Dequeued: " + queue.Dequeue());

        queue.Display();

        Console.WriteLine("Peek: " + queue.Peek());
        Console.WriteLine("Size: " + queue.Size());
    }
}