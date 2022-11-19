using System;

namespace Part_2_Task_Array_113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 6, 1, 8, 5, 7, 0, 2 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                int min = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }

                int temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;
            }

            foreach (var num in numbers)
                Console.Write($"{num} ");

            Console.ReadKey();
        }
    }
}
