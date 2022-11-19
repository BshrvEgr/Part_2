using System;

namespace Part_2_Task_Boolean_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            bool flag = a % 2 == 0;

            Console.WriteLine($"Число а четное: {flag}");

            Console.ReadKey();
        }
    }
}
