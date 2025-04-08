using BinarySearchTree;

public class MyClass
{
    public static void Main(string[] args)
    {
        IBinarySearchTree<int> bst = new BinarySearchTree<int>();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        Console.WriteLine("InOrder Traversal:");
        bst.InOrderTraversal(val => Console.Write(val + " ")); // 20 30 40 50 60 70 80

        Console.WriteLine("\nContains 60: " + bst.Contains(60)); // True
        Console.WriteLine("Contains 90: " + bst.Contains(90)); // False

        bst.Delete(70); // Delete a node with one or two children

        Console.WriteLine("After deleting 70:");
        bst.InOrderTraversal(val => Console.Write(val + " "));
    }
}