using System;

namespace BinaryTree;

public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> root;

    public void Insert(T value)
    {
        root = InsertRecursive(root, value);
    }

    private BinaryTreeNode<T> InsertRecursive(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
            return new BinaryTreeNode<T>(value);

        if (value.CompareTo(node.Value) < 0)
            node.Left = InsertRecursive(node.Left, value);
        else if (value.CompareTo(node.Value) > 0)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }

    public bool Contains(T value)
    {
        return ContainsRecursive(root, value);
    }

    private bool ContainsRecursive(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
            return false;

        if (value.CompareTo(node.Value) == 0)
            return true;

        if (value.CompareTo(node.Value) < 0)
            return ContainsRecursive(node.Left, value);
        else
            return ContainsRecursive(node.Right, value);
    }

    public void InOrderTraversal(Action<T> action)
    {
        InOrder(root, action);
    }

    private void InOrder(BinaryTreeNode<T> node, Action<T> action)
    {
        if (node == null) return;
        InOrder(node.Left, action);
        action(node.Value);
        InOrder(node.Right, action);
    }

    public void PreOrderTraversal(Action<T> action)
    {
        PreOrder(root, action);
    }

    private void PreOrder(BinaryTreeNode<T> node, Action<T> action)
    {
        if (node == null) return;
        action(node.Value);
        PreOrder(node.Left, action);
        PreOrder(node.Right, action);
    }

    public void PostOrderTraversal(Action<T> action)
    {
        PostOrder(root, action);
    }

    private void PostOrder(BinaryTreeNode<T> node, Action<T> action)
    {
        if (node == null) return;
        PostOrder(node.Left, action);
        PostOrder(node.Right, action);
        action(node.Value);
    }
}
