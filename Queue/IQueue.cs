namespace Queue;

public interface IQueue
{
    public void Enqueue(int data);

    public int Dequeue();

    public int Peek();

    public bool IsEmpty();

    public int Size();

    public void Display();
    
    
}