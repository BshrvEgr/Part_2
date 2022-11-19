using System;

namespace Part_2_Task_Integer_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds = 0;
            int minutes = 0;

            Console.Write($"Seconds: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            minutes = seconds / 60;

            Console.WriteLine($"Minutes: {minutes}");

            Console.ReadKey();
        }
    }
}
