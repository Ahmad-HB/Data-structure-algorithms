namespace CircularDoublyLinkedList;

public interface ICircularDoublyLinkedList
{
    public void AddToEmpty(int data);

    public void AddFront(int data);

    public void AddEnd(int data);

    public void AddAfter(int item, int data);

    public void DeleteNode(int key);

    public void TraverseForward();

    public void TraverseBackward();
}