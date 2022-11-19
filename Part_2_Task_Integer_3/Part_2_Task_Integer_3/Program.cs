using System;

namespace Part_2_Task_Integer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double _byte;
            double _kByte;


            Console.Write("B: ");
            _byte = Convert.ToInt32(Console.ReadLine());
            _kByte = _byte / 1024;
            Console.WriteLine("Kb: " + _kByte);

            Console.ReadKey();
        }
    }
}
