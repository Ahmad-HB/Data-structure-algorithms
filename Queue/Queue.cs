namespace Queue;

public class Queue : IQueue
{
    private Node front;
    private Node rear;
    private int count;

    public Queue()
    {
        front = rear = null;
        count = 0;
    }


    public void Enqueue(int data)
    {
        Node newNode = new Node(data);

        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }

        count++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        int value = front.Data;
        front = front.Next;

        if (front == null)
            rear = null;

        count--;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return front.Data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public int Size()
    {
        return count;
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Node current = front;
        Console.Write("Queue: ");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}