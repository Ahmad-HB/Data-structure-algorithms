namespace CircularDoublyLinkedList;

public class Node
{
    public int Data;
    public Node Next;
    public Node Prev;

    public Node(int data)
    {
        Data = data;
        Next = Prev = null;
    }
}