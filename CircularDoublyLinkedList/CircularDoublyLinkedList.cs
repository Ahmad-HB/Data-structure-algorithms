namespace CircularDoublyLinkedList;

public class CircularDoublyLinkedList : ICircularDoublyLinkedList
{
    private Node last;

    public CircularDoublyLinkedList()
    {
        last = null;
    }
    
    public void AddToEmpty(int data)
    {
        if (last != null) return;

        Node newNode = new Node(data);
        newNode.Next = newNode;
        newNode.Prev = newNode;
        last = newNode;
    }

    public void AddFront(int data)
    {
        if (last == null)
        {
            AddToEmpty(data);
            return;
        }

        Node newNode = new Node(data);
        newNode.Next = last.Next;
        newNode.Prev = last;
        last.Next.Prev = newNode;
        last.Next = newNode;
    }

    public void AddEnd(int data)
    {
        if (last == null)
        {
            AddToEmpty(data);
            return;
        }

        Node newNode = new Node(data);
        newNode.Next = last.Next;
        newNode.Prev = last;
        last.Next.Prev = newNode;
        last.Next = newNode;
        last = newNode;
    }

    public void AddAfter(int item, int data)
    {
        if (last == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = last.Next;

        do
        {
            if (current.Data == item)
            {
                Node newNode = new Node(data);
                newNode.Next = current.Next;
                newNode.Prev = current;
                current.Next.Prev = newNode;
                current.Next = newNode;

                if (current == last)
                    last = newNode;

                return;
            }

            current = current.Next;

        } while (current != last.Next);

        Console.WriteLine($"Node with value {item} not found.");
    }

    public void DeleteNode(int key)
    {
        if (last == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = last.Next;

        // Only one node
        if (current == last && current.Data == key)
        {
            last = null;
            return;
        }

        do
        {
            if (current.Data == key)
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;

                if (current == last)
                    last = current.Prev;

                return;
            }

            current = current.Next;

        } while (current != last.Next);

        Console.WriteLine($"Node with value {key} not found.");
    }

    public void TraverseForward()
    {
        if (last == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = last.Next;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != last.Next);

        Console.WriteLine();
    }

    public void TraverseBackward()
    {
        if (last == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = last;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Prev;
        } while (current != last);

        Console.WriteLine();
    }
}