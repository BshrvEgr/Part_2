using System;

namespace Part_2_Task_Begin_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 7;

            Console.WriteLine($"{a}{b}{c}");

            int temp = b;
            b = a;
            a = c;
            c = temp;

            Console.WriteLine($"{a}{b}{c}");

            Console.ReadKey();
        }
    }
}
