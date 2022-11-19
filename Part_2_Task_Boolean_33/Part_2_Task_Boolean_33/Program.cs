using System;

namespace Part_2_Task_Boolean_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 4;

            bool flag = ((a < (b + c)) && (b < (a + c))
                && (c < (a + c)));

            if (flag)
                Console.WriteLine("Существует");

            else
                Console.WriteLine("Не существует");

            Console.ReadKey();
        }
    }
}
