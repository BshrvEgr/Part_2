using System;

namespace Part_2_Task_Series_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] k = new int[n] { 2, 4, 5, 2, 1 };

            int number = Array.LastIndexOf(k, 2);

            if (number == -1)
                Console.WriteLine("0");

            else
                Console.WriteLine(number + 1);

            Console.ReadKey();
        }
    }
}
