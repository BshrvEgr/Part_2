using System;

namespace Part_2_Task_Series_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 3.4, 3.3, 5, 2, 4, 1, 2.2, 4, 9.9, 12 };
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[0];
            }

            Console.WriteLine($"Middle Arifmetic: {result / array.Length}");

            Console.ReadKey();
        }
    }
}
