using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            Console.WriteLine(ReverseString(helloWorld));
            Console.WriteLine(IsPalindrome(helloWorld));
            Console.WriteLine(IsPalindrome("racecar"));
            // test github commit
        }
        static string ReverseString(string input)
        {
            char[] inputArray = input.ToCharArray();
            string answer = "";
            for (int i = inputArray.Length; i > 0; i--)
            {
                answer += inputArray[i - 1];
            }
            return answer;
        }
        static bool IsPalindrome(string input)
        {
            if (input.Length <= 0)
            {
                return false;
            }
            else
            {
                char[] inputArray = input.ToCharArray();
                int length = 0;
                if (inputArray.Length % 2 == 0)
                {
                    length = inputArray.Length;
                }
                else
                {
                    length = inputArray.Length - 1;
                }
                for(int i = 0; i < length / 2; i++)
                {
                    if (inputArray[i] != inputArray[inputArray.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
