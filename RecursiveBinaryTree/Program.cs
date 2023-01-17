using System;

namespace RecursiveBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 90 };
            //var index = FindIndex_Iteration(numbers, 477, 0);
            var index = FindIndex_Recursive(numbers, 5, 0);

            Console.WriteLine($"Index: {index}");
            Console.ReadLine();










        }

        public static int FindIndex_Recursive(int[] numbers, int val, int startIndex)
        {
            //Exit Contidion
            if (startIndex >= numbers.Length )
            {
                return -1;
            }
            //Actual Process
            if (numbers[startIndex] == val)
            {
                return startIndex;
            }
            //Re-Calling
            return FindIndex_Recursive(numbers, val, startIndex + 1);

        }


        public static int FindIndex_Iteration(int[] numbers, int val, int startIndex)
        {
            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (numbers[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
