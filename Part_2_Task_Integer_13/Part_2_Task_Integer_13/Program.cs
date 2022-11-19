using System;

namespace Part_2_Task_Integer_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("A: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = (a % 100 / 10 * 100) + (a % 10) * 10 + a / 100;
            Console.WriteLine("B: {0}", b);

            Console.ReadKey();
        }
    }
}
