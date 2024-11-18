namespace LinkedList;

public class LinkedList : ILinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void addFirst(int val)
    {
        Node newNode = new Node(val);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    public void addLast(int val)
    {
        Node newNode = new Node(val);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void printLinkedList()
    {
        if (head == null)
        {
            Console.WriteLine("The List is Empty");
        }
        else
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    public void removeFirst()
    {
        if (head == null)
        {
            Console.WriteLine("The List is Empty");
        }
        else
        {
            Node current = head;
            head = head.Next;
            Console.WriteLine("The deleted item is: " + current.Data);
        }
    }

    public void removeLast()
    {
        if (head == null)
        {
            Console.WriteLine("The List is Empty");
            return;
        }
        if (head.Next == null)
        {
            Console.WriteLine("The deleted item is: " + head.Data);
            head = null;
            return;
        }
        Node current = head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        Node deletedNode = current.Next;
        current.Next = null;
        Console.WriteLine("The deleted item is: " + deletedNode.Data);
    }

    public bool search(int val)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == val)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void deleteSpecificElement(int val)
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        if (head.Data == val)
        {
            removeFirst();
            return;
        }

        Node current = head;
        Node previous = null;

        while (current != null && current.Data != val)
        {
            previous = current;
            current = current.Next;
        }

        if (current != null)
        {
            previous.Next = current.Next;
            Console.WriteLine("Deleted element: " + current.Data);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    public void addAtPosition(int val, int pos)
    {
        Node newNode = new Node(val);

        if (pos == 1)
        {
            addFirst(val);
            return;
        }

        Node current = head;
        Node previous = null;
        int count = 1;

        while (current != null && count < pos)
        {
            previous = current;
            current = current.Next;
            count++;
        }

        if (previous != null)
        {
            newNode.Next = current;
            previous.Next = newNode;
        }
        else
        {
            Console.WriteLine("Position out of range.");
        }
    }

    public void addZeroNode()
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data > 5)
            {
                Node newNode = new Node(0);

                newNode.Next = current.Next;
                current.Next = newNode;
                current = current.Next; // Move to the new node to avoid infinite loop
            }
            current = current.Next;
        }
    }
}
