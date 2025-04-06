

public class MyClass
{
    public static void Main(string[] args)
    {
        CircularDoublyLinkedList.CircularDoublyLinkedList list = new CircularDoublyLinkedList.CircularDoublyLinkedList();

        list.AddToEmpty(10);
        list.AddEnd(20);
        list.AddFront(5);
        list.AddAfter(10, 15);

        Console.WriteLine("Forward Traversal:");
        list.TraverseForward();

        Console.WriteLine("Backward Traversal:");
        list.TraverseBackward();

        Console.WriteLine("After Deletion:");
        list.DeleteNode(10);
        list.TraverseForward();
    }
}