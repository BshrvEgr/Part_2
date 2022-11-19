using System;

namespace Part_2_Task_For_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 24;

            Console.WriteLine($"Start: {start}; End: {end}");

            for (int i = start + 1; i < end; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
