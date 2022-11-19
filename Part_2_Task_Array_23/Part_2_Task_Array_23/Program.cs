using System;

namespace Part_2_Task_Array_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int k = 3;
            int n = 7;

            double middleArifmetic = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1) > k && (i + 1) < n)
                    continue;

                else
                    middleArifmetic += numbers[i];
            }

            Console.WriteLine($"{middleArifmetic / (numbers.Length - (n - k))}");

            Console.ReadKey();
        }
    }
}
