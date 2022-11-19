using System;
using System.Collections.Generic;

namespace Part_2_Task_Proc_13
{
    internal class Program
    {
        static void SortDec(double a, double b, double c, out double A, out double B, out double C)
        {
            List<double> numbers = new List<double>();
            numbers.Add(a);
            numbers.Add(b);
            numbers.Add(c);

            numbers.Sort();
            numbers.Reverse();

            A = numbers[0];
            B = numbers[1];
            C = numbers[2];
        }

        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;
            double c = 4;

            Console.WriteLine($"{a} {b} {c}");

            SortDec(a, b, c, out a, out b, out c);

            Console.WriteLine($"{a} {b} {c}");

            Console.ReadKey();
        }
    }
}
