using System;
using System.Collections.Generic;
using System.Linq;

namespace Part_2_Task_Array_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 7, 3, 7 };
            List<int> unique = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                unique.Add(numbers[i]);
            }

            var l = unique.Distinct();

            Console.WriteLine($"Кол-во различных элементов: {l.Count()}");

            Console.ReadKey();
        }
    }
}
