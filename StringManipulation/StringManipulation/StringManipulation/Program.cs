using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            Console.WriteLine(ReverseString(helloWorld));
        }
        static string ReverseString(string input)
        {
            char[] inputArray = input.ToCharArray();
            string answer = "";
            for(int i = inputArray.Length; i > 0; i--)
            {
                answer += inputArray[i -1];
            }
            return answer;
        }
    }
}
