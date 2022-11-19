using System;

namespace Part_2_Task_For_24
{
    internal class Program
    {
        static long GetFactorial(int number)
        {
            long result = 0;

            for (int i = 1; i <= number; i++)
                result *= i;

            return result;
        }

        static void Main(string[] args)
        {
            double x = 0;
            int n = 0;

            Console.Write("X = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());

            long x1 = (long)x;
            long result = (long)x;

            for (int i = 1; i <= n; i++)
            {
                x1 *= (long)(Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / GetFactorial(2 * i));
                result += x1;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
