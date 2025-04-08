namespace BinarySearchTree;

public interface IBinarySearchTree<T> where T : IComparable<T>
{
    public void Insert(T value);
    public bool Contains(T value);
    public void Delete(T value);
    public void InOrderTraversal(Action<T> action);
}