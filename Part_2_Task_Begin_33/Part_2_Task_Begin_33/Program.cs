using System;

namespace Part_2_Task_Begin_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, a, y;

            Console.Write("X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y:");
            y = Convert.ToDouble(Console.ReadLine());

            double price = a / x;

            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Стоимость {y * price}");

            Console.ReadKey();
        }
    }
}
