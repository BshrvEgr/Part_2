using System;

namespace Part_2_Task_Begin_3
{
    internal class Program
    {
        static double Perimeter(double a, double b) => 2 * (a + b);

        static double Area(double a, double b) => a * b;

        static void Main(string[] args)
        {
            double a = 3.2;
            double b = 2.5;

            Console.WriteLine($"S = {Area(a, b)}\n" +
                $"P = {Perimeter(a, b)}");

            Console.ReadKey();
        }
    }
}
