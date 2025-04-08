using System;

namespace AVLTree;

public class AVLTree<T> : IAVLTree<T> where T : IComparable<T>
{
    private AVLTreeNode<T> root;

    public void Insert(T value)
    {
        root = InsertRecursive(root, value);
    }

    private AVLTreeNode<T> InsertRecursive(AVLTreeNode<T> node, T value)
    {
        if (node == null)
            return new AVLTreeNode<T>(value);

        int cmp = value.CompareTo(node.Value);
        if (cmp < 0)
            node.Left = InsertRecursive(node.Left, value);
        else if (cmp > 0)
            node.Right = InsertRecursive(node.Right, value);
        else
            return node;

        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

        return Balance(node);
    }

    public bool Contains(T value)
    {
        return ContainsRecursive(root, value);
    }

    private bool ContainsRecursive(AVLTreeNode<T> node, T value)
    {
        if (node == null)
            return false;

        int cmp = value.CompareTo(node.Value);
        if (cmp == 0)
            return true;
        else if (cmp < 0)
            return ContainsRecursive(node.Left, value);
        else
            return ContainsRecursive(node.Right, value);
    }

    public void Delete(T value)
    {
        root = DeleteRecursive(root, value);
    }

    private AVLTreeNode<T> DeleteRecursive(AVLTreeNode<T> node, T value)
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
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;

            AVLTreeNode<T> minNode = FindMin(node.Right);
            node.Value = minNode.Value;
            node.Right = DeleteRecursive(node.Right, minNode.Value);
        }

        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        return Balance(node);
    }

    private AVLTreeNode<T> FindMin(AVLTreeNode<T> node)
    {
        while (node.Left != null)
            node = node.Left;
        return node;
    }

    public void InOrderTraversal(Action<T> action)
    {
        TraverseInOrder(root, action);
    }

    private void TraverseInOrder(AVLTreeNode<T> node, Action<T> action)
    {
        if (node == null)
            return;

        TraverseInOrder(node.Left, action);
        action(node.Value);
        TraverseInOrder(node.Right, action);
    }

    private int GetHeight(AVLTreeNode<T> node)
    {
        return node == null ? 0 : node.Height;
    }

    private int GetBalance(AVLTreeNode<T> node)
    {
        return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
    }

    private AVLTreeNode<T> Balance(AVLTreeNode<T> node)
    {
        int balance = GetBalance(node);

        // Left heavy
        if (balance > 1)
        {
            // Left-Left case
            if (GetBalance(node.Left) >= 0)
                return RightRotate(node);
            // Left-Right case
            else
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }
        }
        // Right heavy
        if (balance < -1)
        {
            // Right-Right case
            if (GetBalance(node.Right) <= 0)
                return LeftRotate(node);
            // Right-Left case
            else
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }
        }

        return node;
    }

    private AVLTreeNode<T> LeftRotate(AVLTreeNode<T> z)
    {
        AVLTreeNode<T> y = z.Right;
        AVLTreeNode<T> T2 = y.Left;

        // Perform rotation
        y.Left = z;
        z.Right = T2;

        // Update heights
        z.Height = Math.Max(GetHeight(z.Left), GetHeight(z.Right)) + 1;
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

        return y;
    }

    private AVLTreeNode<T> RightRotate(AVLTreeNode<T> y)
    {
        AVLTreeNode<T> x = y.Left;
        AVLTreeNode<T> T2 = x.Right;

        // Perform rotation
        x.Right = y;
        y.Left = T2;

        // Update heights
        y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
        x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

        return x;
    }
}
