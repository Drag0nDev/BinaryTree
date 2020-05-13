using System;

namespace Binary_Tree.BinaryTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }

        ~Node()
        {
            Console.WriteLine("node with value {0} deleted!", value);
        }
    }
}