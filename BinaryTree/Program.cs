using BinaryTree;

public class MyClass
{
    public static void Main(string[] args)
    {
        IBinaryTree<int> tree = new BinaryTree<int>();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("InOrder:");
        tree.InOrderTraversal(val => Console.Write(val + " ")); // 20 30 40 50 60 70 80

        Console.WriteLine("\nContains 60: " + tree.Contains(60)); // True
        Console.WriteLine("Contains 100: " + tree.Contains(100)); // False
    }
}