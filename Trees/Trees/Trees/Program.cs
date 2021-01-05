using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BTree = new BinaryTree();
            BTree.Add(15);
            BTree.Add(5);
            BTree.Add(10);
            BTree.Add(75);
            BTree.Add(20);
            BTree.Add(11);
            BTree.Add(50);
            BTree.Add(1);
            BTree.Add(6);
            BTree.Add(32);
            BTree.Add(38);
            BTree.Add(26);
            BTree.Add(7);
            BTree.Add(200);

            Console.WriteLine(BTree.Contains(7));
            InOrder(BTree);
        }
        public static void InOrder(BinaryTree tree)
        {
            InOrder(tree.Root);
        }
        private static void InOrder(Node<int> node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }
            Console.WriteLine(node.Value);
            if (node.Right != null)
            {
                InOrder(node.Right);
            }
        }

        public static void PreOrder(BinaryTree tree)
        {
            PreOrder(tree.Root);
        }
        private static void PreOrder(Node<int> node)
        {
            Console.WriteLine(node.Value);
            if (node.Left != null)
            {
                PreOrder(node.Left);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right);
            }
        }

        public static void PostOrder(BinaryTree tree)
        {
            PostOrder(tree.Root);
        }
        private static void PostOrder(Node<int> node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }
            if (node.Right != null)
            {
                PostOrder(node.Right);
            }
            Console.WriteLine(node.Value);
        }
    }
}
