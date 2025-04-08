namespace BinarySearchTree;
using System;

public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable<T>
{
    private BinarySearchTreeNode<T> root;

    public void Insert(T value)
    {
        root = InsertRecursive(root, value);
    }

    private BinarySearchTreeNode<T> InsertRecursive(BinarySearchTreeNode<T> node, T value)
    {
        if (node == null)
            return new BinarySearchTreeNode<T>(value);

        int cmp = value.CompareTo(node.Value);
        if (cmp < 0)
            node.Left = InsertRecursive(node.Left, value);
        else if (cmp > 0)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }

    public bool Contains(T value)
    {
        return SearchRecursive(root, value);
    }

    private bool SearchRecursive(BinarySearchTreeNode<T> node, T value)
    {
        if (node == null)
            return false;

        int cmp = value.CompareTo(node.Value);
        if (cmp == 0)
            return true;
        else if (cmp < 0)
            return SearchRecursive(node.Left, value);
        else
            return SearchRecursive(node.Right, value);
    }

    public void Delete(T value)
    {
        root = DeleteRecursive(root, value);
    }

    private BinarySearchTreeNode<T> DeleteRecursive(BinarySearchTreeNode<T> node, T value)
    {
        if (node == null)
            return null;

        int cmp = value.CompareTo(node.Value);
        if (cmp < 0)
        {
            node.Left = DeleteRecursive(node.Left, value);
        }
        else if (cmp > 0)
        {
            node.Right = DeleteRecursive(node.Right, value);
        }
        else
        {
            // Node to be deleted found
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;

            // Node with two children
            BinarySearchTreeNode<T> minNode = FindMin(node.Right);
            node.Value = minNode.Value;
            node.Right = DeleteRecursive(node.Right, minNode.Value);
        }

        return node;
    }

    private BinarySearchTreeNode<T> FindMin(BinarySearchTreeNode<T> node)
    {
        while (node.Left != null)
            node = node.Left;
        return node;
    }

    public void InOrderTraversal(Action<T> action)
    {
        TraverseInOrder(root, action);
    }

    private void TraverseInOrder(BinarySearchTreeNode<T> node, Action<T> action)
    {
        if (node == null)
            return;

        TraverseInOrder(node.Left, action);
        action(node.Value);
        TraverseInOrder(node.Right, action);
    }
}
