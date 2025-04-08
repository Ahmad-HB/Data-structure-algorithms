namespace BinarySearchTree;

public class BinarySearchTreeNode<T>
{
    public T Value { get; set; }
    public BinarySearchTreeNode<T> Left { get; set; }
    public BinarySearchTreeNode<T> Right { get; set; }

    public BinarySearchTreeNode(T value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}