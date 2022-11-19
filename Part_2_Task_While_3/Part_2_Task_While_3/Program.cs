using System;

namespace Part_2_Task_While_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;

            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("K = ");
            k = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            while (n >= k)
            {
                n -= k;
                result++;
            }

            Console.WriteLine($"Результат: {result}\nОстаток: {n}");

            Console.ReadKey();
        }
    }
}
