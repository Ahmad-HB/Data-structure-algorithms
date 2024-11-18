// See https://aka.ms/new-console-template for more information

class Myclass
{
    static void Main(string [] args )
    {
        LinkedList.LinkedList l1 = new LinkedList.LinkedList();
		
		
        l1.addFirst(2);
        l1.addFirst(7);
        l1.addFirst(3);
        l1.addLast(6);
        l1.addLast(5);
        l1.addLast(9);
        l1.printLinkedList();
        Console.WriteLine("============");
        Console.WriteLine(l1.search(5));
        Console.WriteLine("============");
        l1.deleteSpecificElement(7);
        l1.printLinkedList();
        Console.WriteLine("============");
        l1.addAtPosition(17, 3);
        l1.printLinkedList();
        Console.WriteLine("============");
        l1.addZeroNode();
        l1.printLinkedList();
        
    }
}