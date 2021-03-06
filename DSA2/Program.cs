﻿using System;
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
            int[] shuffle = Shuffle(array1);
            int[] arrayAddToFront = AddToFront(array1, 1500);
            int[] arrayAddToRear = AddToRear(array1, 4000);
            string duplicateString = "";
            Console.WriteLine("The largest integer in { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } is " + largest);
            Console.WriteLine("The smallest integer in { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } is " + smallest);
            for (int i = 0; i < duplicates.Length; i++)
            {
                duplicateString += " " + duplicates[i] + ",";
            }
            Console.WriteLine("The duplicates in { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } are" + duplicateString);
            string shuffleString = "";
            for (int i = 0; i < shuffle.Length; i++)
            {
                shuffleString += " " + shuffle[i] + ",";
            }
            Console.WriteLine("The array of { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } shuffled is" + shuffleString);
            string addToFrontString = "";
            for (int i = 0; i < arrayAddToFront.Length; i++)
            {
                addToFrontString += " " + arrayAddToFront[i] + ",";
            }
            Console.WriteLine("1500 added to the array of { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } is" + addToFrontString);
            string addToRearString = "";
            for (int i = 0; i < arrayAddToRear.Length; i++)
            {
                addToRearString += " " + arrayAddToRear[i] + ",";
            }
            Console.WriteLine("4000 added to the array of { 5, 3, 6, 8, 9, 3, 6, 11, 9, 10, 3, 7 } is" + addToRearString);

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
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (!dict.ContainsKey(arr[i]))
                    {
                        if (arr[i] == arr[j])
                        {
                            dict.Add(arr[i], true);
                            break;
                        }
                    }
                }
            }
            int[] answer = new int[dict.Count];
            int count = 0;
            foreach (var pair in dict)
            {
                answer[count] = pair.Key;
                count++;
            }
            return answer;
        }
        static int[] Shuffle(int[] arr)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            int[] answer = new int[arr.Length];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randomNumber = rand.Next(arr.Length);
                while (dict.ContainsKey(randomNumber))
                {
                    randomNumber = rand.Next(arr.Length);
                }
                answer[randomNumber] = arr[i];
                dict.Add(randomNumber, true);
            }
            return answer;
        }
        static int[] AddToFront(int[] arr, int value)
        {
            int[] answer = new int[arr.Length + 1];
            answer[0] = value;
            for (int i = 1; i < answer.Length; i++)
            {
                answer[i] = arr[i - 1];
            }
            return answer;
        }
        static int[] AddToRear(int[] arr, int value)
        {
            int[] answer = new int[arr.Length + 1];
            answer[answer.Length - 1] = value;
            for(int i = 0; i < answer.Length -1; i++)
            {
                answer[i] = arr[i];
            }
            return answer;
        }
    }
}
