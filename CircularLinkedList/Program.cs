using CircularLinkedList;

public class MyClass
{
    static void Main(string[] args)
    {
        
        CircularLinkedList.CircularLinkedList list = new CircularLinkedList.CircularLinkedList();
        Node last = null;

        last = list.addToEmpty(last, 10);
        last = list.addEnd(last, 20);
        last = list.addFront(last, 5);
        last = list.addAfter(last, 15, 10);

        Console.WriteLine("Traversal:");
        list.traverse(last);

        Console.WriteLine("After Deletion:");
        last = list.deleteNode(last, 10);
        list.traverse(last);
        
    }
}