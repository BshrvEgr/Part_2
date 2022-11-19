using System;

namespace Part_2_Task_Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int d = 2;
            int a = 3;

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = a + d * i;
                Console.WriteLine($"{numbers[i]} - {i + 1} член прогрессии");
            }

            Console.ReadKey();
        }
    }
}
