namespace DoublyLinkedList;

public class Node
{
    public int data;
    public Node next;
    public Node prev;
    
    public Node(int val)
    {
        this.data = val;
        this.next = null;
        this.prev = null;
    }
}