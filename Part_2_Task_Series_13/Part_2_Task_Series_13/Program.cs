using System;

namespace Part_2_Task_Series_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 3, 3, 4, 4, 2, 1, 1, 6, 7 };

            double result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    result += numbers[i];
            }

            if (result != 0)
                Console.WriteLine("Sum: " + result);

            else
                Console.WriteLine("0");

            Console.ReadKey();
        }
    }
}
