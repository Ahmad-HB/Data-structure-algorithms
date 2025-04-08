namespace AVLTree;

public class AVLTreeNode<T>
{
    public T Value { get; set; }
    public AVLTreeNode<T> Left { get; set; }
    public AVLTreeNode<T> Right { get; set; }
    public int Height { get; set; }  // Height of the node

    public AVLTreeNode(T value)
    {
        Value = value;
        Left = null;
        Right = null;
        Height = 1;
    }
}