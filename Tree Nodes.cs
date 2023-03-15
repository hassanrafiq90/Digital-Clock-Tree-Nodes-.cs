using System;

class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int data)
    {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}

class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return;
        }

        Node current = root;
        Node parent = null;

        while (true)
        {
            parent = current;
            if (data <= current.data)
            {
                current = current.left;
                if (current == null)
                {
                    parent.left = new Node(data);
                    return;
                }
            }
            else
            {
                current = current.right;
                if (current == null)
                {
                    parent.right = new Node(data);
                    return;
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(12);
        tree.Insert(17);
    }
}