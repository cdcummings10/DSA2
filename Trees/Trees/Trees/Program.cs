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
        }
    }
}
