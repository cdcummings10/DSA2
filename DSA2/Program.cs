using System;

namespace DSA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array1 = { 5, 3, 6, 8, 9, 10, 3, 7 };
            int largest = FindLargest(array1);
            int smallest = FindSmallest(array1);
            Console.WriteLine("The largest integer in { 5, 3, 6, 8, 9, 10, 3, 7 } is " + largest);
            Console.WriteLine("The smallest integer in { 5, 3, 6, 8, 9, 10, 3, 7 } is " + smallest);

        }
        static int FindLargest(int[] arr)
        {
            int largest = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }

        static int FindSmallest(int[] arr)
        {
            int smallest = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] <= smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }
    }
}
