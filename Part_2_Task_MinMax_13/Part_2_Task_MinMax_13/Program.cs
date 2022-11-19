using System;

namespace Part_2_Task_MinMax_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;

            int[] numbers = new int[n] { 3, 6, 13, 2, 11 };

            int max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
            }

            Console.WriteLine($"{Array.IndexOf(numbers, max) + 1}");

            Console.ReadKey();
        }
    }
}
