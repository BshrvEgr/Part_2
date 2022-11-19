using System;

namespace Part_2_Task_While_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
            double a = 0;
            double i = 0;
            Console.Write("A = ");

            a = Convert.ToDouble(Console.ReadLine());

            while (temp <= a)
            {
                i++;
                temp += 1 / i;
            }

            Console.WriteLine($"{i}\n{temp}");

            Console.ReadKey();
        }
    }
}
