using System;

namespace Part_2_Task_Array_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 4, 6, 2, 1, 6 };
            int[] arrayB = { 3, 3, 5, 8, 9 };
            int[] arrayC = { };

            for (int i = 0; i < 5; i++)
            {
                arrayC[i] = arrayA[i];
            }

            for (int i = 5; i < 10; i++)
            {
                arrayC[i] = arrayB[i];
            }

            Array.Sort(arrayC);

            foreach (var n in arrayC)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
