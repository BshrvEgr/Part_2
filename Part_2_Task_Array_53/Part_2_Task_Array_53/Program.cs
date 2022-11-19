using System;

namespace Part_2_Task_Array_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[] arrayA = new int[n] { 1, 3, 5, 6, 7, 9 };
            int[] arrayB = new int[n] { 2, 4, 6, 2, 8, 10 };
            int[] arrayC = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (arrayA[i] < arrayB[i])
                {
                    arrayC[i] = arrayB[i];
                }

                else
                {
                    arrayC[i] = arrayA[i];
                }
            }

            foreach (var num in arrayC)
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }
    }
}
