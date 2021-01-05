using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class Node<T>
    {
        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public T Value { get; set; }
    }
}
