using System;

namespace Part_2_Task_Array_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 43, 32, 5, 3, 4, 6, 7, 8, 11 };

            int localMax = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (localMax < numbers[i])
                    localMax = numbers[i];
            }

            Console.WriteLine($"Local max: {localMax}\n" +
                $"{numbers[Array.IndexOf(numbers, localMax) - 1]} < " +
                $"{localMax} > {numbers[Array.IndexOf(numbers, localMax) + 1]}");

            Console.ReadKey();
        }
    }
}
