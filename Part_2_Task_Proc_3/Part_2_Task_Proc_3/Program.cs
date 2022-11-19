using System;

namespace Part_2_Task_Proc_3
{
    internal class Program
    {
        static void Mean(int x, int y, out double AMean, out double GMean)
        {
            AMean = (x + y) / (double)2;
            GMean = Math.Sqrt(x * y);
        }

        static void Main(string[] args)
        {
            double am = 0;
            double gm = 0;

            int a = 2;
            int b = 3;
            int c = 4;
            int d = 5;

            Mean(a, b, out am, out gm);
            Console.WriteLine($"{am} {gm}");

            Mean(a, c, out am, out gm);
            Console.WriteLine($"{am} {gm}");

            Mean(a, d, out am, out gm);
            Console.WriteLine($"{am} {gm}");

            Console.ReadKey();
        }
    }
}
