using System;

namespace Part_2_Task_Array_103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 6, 1, 8, 5, 7, 0, 2 };

            int maxNumber = numbers[0];
            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                    maxNumber = numbers[i];

                if (minNumber > numbers[i])
                    minNumber = numbers[i];
            }

            numbers[Array.IndexOf(numbers, minNumber) - 1] = 0;
            numbers[Array.IndexOf(numbers, maxNumber) + 1] = 0;

            foreach (var num in numbers)
                Console.Write($"{num} ");

            Console.ReadKey();
        }
    }
}
