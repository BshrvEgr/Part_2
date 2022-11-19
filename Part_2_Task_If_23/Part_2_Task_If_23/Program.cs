using System;

namespace Part_2_Task_If_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;

            Console.Write("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            if (x2 == x3)
                Console.WriteLine($"x4: {x1}");

            else if (x3 == x1)
                Console.WriteLine($"x4: {x2}");

            else
                Console.WriteLine($"x4: {x3}");

            if (y2 == y3)
                Console.WriteLine($"y4: {y1}");

            else if (y3 == y2)
                Console.WriteLine($"y4: {y2}");

            else
                Console.WriteLine($"y4: {y3}");

            Console.ReadKey();
        }
    }
}
