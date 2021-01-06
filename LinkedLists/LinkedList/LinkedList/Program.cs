using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> lList = new LinkedList<int>();
            lList.Add(3);
            lList.Add(5);
            lList.Add(2);
            lList.Add(66);
            lList.Add(77);
            lList.Add(37);
            lList.Add(82);
            lList.Add(1);
            lList.Add(13);
            lList.Add(28);

            Console.WriteLine(Contains(25, lList));
        }
        static public bool Contains(int value, LinkedList<int> linkedList)
        {
            if(linkedList.Head == null)
            {
                return false;
            }
            else
            {
                Node<int> current = linkedList.Head;
                while(current.Next != null)
                {
                    if(current.Value == value)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }
    }
}
