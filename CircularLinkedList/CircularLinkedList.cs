namespace CircularLinkedList;

public class CircularLinkedList : ICircularLinkedList
{
    private Node head;

    public CircularLinkedList()
    {
        head = null;
    }
    
    public Node addToEmpty(Node last, int Data) {
        if (last != null)
            return last;
        
        Node newNode = new Node(Data);
        
        newNode.Data = Data;
        
        last = newNode;
        
        newNode.Next = last;

        return last;
    }
    
    public Node addFront(Node last, int Data) {
    if (last == null)
      return addToEmpty(last, Data);

    Node newNode = new Node(Data);

    newNode.Data = Data;

    newNode.Next = last.Next;

    last.Next = newNode;

    return last;
  }

  public Node addEnd(Node last, int Data) {
    if (last == null)
      return addToEmpty(last, Data);
    
    Node newNode = new Node(Data);

    newNode.Data = Data;

    newNode.Next = last.Next;

    last.Next = newNode;
    
    last = newNode;

    return last;
  }

  public Node addAfter(Node last, int Data, int item) {
    if (last == null)
      return null;

    Node newNode, p;
    p = last.Next;
    do {
      
      if (p.Data == item) {
        
        newNode = new Node(Data);

        newNode.Data = Data;

        newNode.Next = p.Next;
        
        p.Next = newNode;
        
        if (p == last)
          last = newNode;
        return last;
      }
      p = p.Next;
    } while (p != last.Next);

    Console.WriteLine(item + "The given node is not present in the list");
    return last;

  }
  
  public Node deleteNode(Node last, int key) {
    
    if (last == null)
      return null;

    if (last.Data == key && last.Next == last) {
      last = null;
      return last;
    }

    Node temp = last, d = new Node();
    
    
    if (last.Data == key) {
      
      while (temp.Next != last) {
        temp = temp.Next;
      }

      temp.Next = last.Next;
      last = temp.Next;
    }

    while (temp.Next != last && temp.Next.Data != key) {
      temp = temp.Next;
    }

    if (temp.Next.Data == key) {
      d = temp.Next;
      temp.Next = d.Next;
    }
    return last;
  }

  public void traverse(Node last) {
    Node p;

    if (last == null) {
      Console.WriteLine("List is empty.");
      return;
    }

    p = last.Next;

    do {
      Console.WriteLine(p.Data + " ");
      p = p.Next;

    }
    while (p != last.Next);

  }
    
    
    
    
}