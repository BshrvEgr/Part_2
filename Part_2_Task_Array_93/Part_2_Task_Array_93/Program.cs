using System;
using System.Collections.Generic;

namespace Part_2_Task_Array_93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 3, 5, 6, 7, 8, 1, 2, 3, 4 };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != numbers.Count)
                    numbers.Remove(i + 1);
            }

            foreach (var n in numbers)
                Console.Write($"{n} ");

            Console.ReadKey();
        }
    }
}
