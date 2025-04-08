using AVLTree;

public class MyClass
{
    public static void Main(string[] args)
    {
        IAVLTree<int> avlTree = new AVLTree<int>();
        avlTree.Insert(50);
        avlTree.Insert(30);
        avlTree.Insert(70);
        avlTree.Insert(20);
        avlTree.Insert(40);
        avlTree.Insert(60);
        avlTree.Insert(80);

        Console.WriteLine("InOrder Traversal:");
        avlTree.InOrderTraversal(val => Console.Write(val + " ")); // 20 30 40 50 60 70 80

        Console.WriteLine("\nContains 60: " + avlTree.Contains(60)); // True
        Console.WriteLine("Contains 90: " + avlTree.Contains(90)); // False

        avlTree.Delete(30); // Delete a node and maintain balance

        Console.WriteLine("After deleting 30:");
        avlTree.InOrderTraversal(val => Console.Write(val + " "));
    }
}
