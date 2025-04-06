namespace CircularLinkedList;

public interface ICircularLinkedList
{
    public Node addToEmpty(Node last, int Data);
    public Node addFront(Node last, int Data);
    public Node addEnd(Node last, int Data);
    public Node addAfter(Node last, int Data, int item);
    public Node deleteNode(Node last, int Data);
    public void traverse(Node last);
}