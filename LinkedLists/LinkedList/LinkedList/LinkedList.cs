using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
    }
}
