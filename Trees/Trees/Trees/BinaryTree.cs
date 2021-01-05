using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class BinaryTree
    {
        public Node<int> Root { get; set; }


        public void Add(int value)
        {
            Node<int> newNode = new Node<int>(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Add(Root, newNode);
            }
        }
        private void Add(Node<int> node, Node<int> newNode)
        {
            if (newNode.Value >= node.Value && node.Right != null)
            {
                Add(node.Right, newNode);
            }
            else if (newNode.Value <= node.Value && node.Left != null)
            {
                Add(node.Left, newNode);
            }
            else
            {
                if (newNode.Value >= node.Value)
                {
                    node.Right = newNode;
                }
                else
                {
                    node.Left = newNode;
                }
            }
        }
        public bool Contains(int value)
        {
            if (Root.Value == value)
            {
                return true;
            }
            else
            {
                return Contains(Root, value);
            }
        }
        private bool Contains(Node<int> node, int value)
        {
            if (value == node.Value)
            {
                return true;
            }
            else if (value > node.Value && node.Right != null)
            {
                return Contains(node.Right, value);
            }
            else if (value < node.Value && node.Left != null)
            {
                return Contains(node.Left, value);
            }
            return false;
        }
    }
}
