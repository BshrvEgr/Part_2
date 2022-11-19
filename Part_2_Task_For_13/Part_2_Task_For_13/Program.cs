using System;

namespace Part_2_Task_For_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double result = 0;

            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(-1, i + 1) * (1.0 + (double)i / 10);
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
