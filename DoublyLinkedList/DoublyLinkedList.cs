namespace DoublyLinkedList;

public class DoublyLinkedList : IDoublyLinkedList
{
    Node head;
    int length;

    public DoublyLinkedList() {
        this.head = null;
    }
    
    
    public bool isEmpty() {
        return head == null;
    }

    public void addFirst(int data) {
        Node newNode = new Node(data);
        if (isEmpty()) {
            head = newNode;
        } else {
            head.prev = newNode;
            newNode.next = head;
            head = newNode;
        }
        length++;
    }

    public void addLast(int data) {
        Node newNode = new Node(data);
        if (isEmpty()) {
            addFirst(data);
        } else {
            Node loopingNode = head;
            while (loopingNode.next != null) {
                loopingNode = loopingNode.next;
            }
            loopingNode.next = newNode;
            newNode.prev = loopingNode;
            length++;
        }
    }

    public void deleteFirst() {
        if (!isEmpty()) {
            head = head.next;
            head.prev = null;
            length--;
        } else {
            Console.WriteLine("List is empty");
        }
    }
    
    public void deleteLast() {
        if (isEmpty()) {
            Console.WriteLine("List is already empty");
        } else if (head.next == null) {
            head.prev = null;
            head = null;
            length--;
        } else {
            Node loopingNode = head;
            while (loopingNode.next != null) {
                loopingNode = loopingNode.next;
            }
            loopingNode.prev.next = null;
            loopingNode.prev = null;
            length--;
        }
    }

    public void printForward() {
        if (!isEmpty()) {
            Node loopingNode = head;
            while (loopingNode != null) {
                Console.WriteLine(loopingNode.data);
                loopingNode = loopingNode.next;
            }
        }
    }

    public void printBackward() {
        Node loopingNode = head;
        while (loopingNode.next != null) {
            loopingNode = loopingNode.next;
        }
        while (loopingNode != null) {
            Console.WriteLine(loopingNode.data);
            loopingNode = loopingNode.prev;
        }
    }
}