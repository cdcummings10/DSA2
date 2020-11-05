using System;
using System.Collections.Generic;
using System.Transactions;

namespace DSA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array1 = { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 };
            int largest = FindLargest(array1);
            int smallest = FindSmallest(array1);
            int[] duplicates = FindDuplicates(array1);
            string duplicateString = "";
            Console.WriteLine("The largest integer in { 5, 3, 6, 8, 9, 10, 3, 7 } is " + largest);
            Console.WriteLine("The smallest integer in { 5, 3, 6, 8, 9, 10, 3, 7 } is " + smallest);
            for(int i = 0; i < duplicates.Length; i++)
            {
                duplicateString += " " + duplicates[i] + ",";  
            }
            Console.WriteLine("The duplicates in { 5, 3, 6, 8, 9, 10, 3, 7 } are" + duplicateString);

        }
        static int FindLargest(int[] arr)
        {
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }

        static int FindSmallest(int[] arr)
        {
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }

        static int[] FindDuplicates(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (!list.Contains(arr[i]))
                    {
                        if (arr[i] == arr[j])
                        {
                            list.Add(arr[i]);
                            break;
                        }
                    }
                }
            }
            int[] answer = new int[list.Count];
            for(int i = 0; i < answer.Length; i++)
            {
                answer[i] = list[i];
            }
            return answer;
        }
    }
}
