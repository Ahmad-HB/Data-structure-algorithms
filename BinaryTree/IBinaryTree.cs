namespace BinaryTree;

public interface IBinaryTree<T> where T : IComparable<T>
{
    public void Insert(T value);
    public bool Contains(T value);
    public void InOrderTraversal(Action<T> action);
    public void PreOrderTraversal(Action<T> action);
    public void PostOrderTraversal(Action<T> action);
}