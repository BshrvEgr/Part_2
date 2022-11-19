using System;

namespace Part_2_Task_Series_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;

            double[] numbers = new double[n] { 2, 3, 2, 1, 4 };

            for (int k = 1; k <= n; k++)
            {
                Console.WriteLine($"{numbers[k - 1]}^{k} = {Math.Pow(numbers[k - 1], k)}");
            }

            Console.ReadKey();
        }
    }
}
