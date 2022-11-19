using System;

namespace Part_2_Task_If_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 2;

            if ((b <= a) && (a <= c) || (b >= a) && (a >= c))
                Console.WriteLine(a);

            else if ((a <= b) && (b <= c) || (a >= b) && (b >= c))
                Console.WriteLine(b);

            else
                Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
