using System;

namespace Part_2_Task_Boolean_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -2;
            int b = 3;
            int c = -4;

            bool flag = a > 0 || b > 0 || c > 0;

            Console.WriteLine($"{flag}");

            Console.ReadKey();
        }
    }
}
