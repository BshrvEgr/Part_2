using System;

namespace Part_2_Task_MinMax_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int a = 0;
            int b = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());

                int p = 2 * (a + b);

                if (max < p)
                    max = p;
            }

            Console.WriteLine($"Максимальный периметр: {max}");

            Console.ReadKey();
        }
    }
}
