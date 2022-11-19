using System;

namespace Part_2_Task_If_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            if (a > 0)
                a += 1;

            else if (a < 0)
                a -= 2;

            else
                a = 10;

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
