using System;

namespace Part_2_Task_For_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int temp1 = 1;
            int temp2 = 1;
            int a = 0;

            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{temp1} {temp2} ");

            for (int i = 3; i <= n; i++)
            {
                a = temp1 + temp2;
                temp1 = temp2;
                temp2 = a;
                Console.Write($"{a} ");
            }

            Console.ReadKey();
        }
    }
}
