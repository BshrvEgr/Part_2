using System;

namespace Part_2_Task_Boolean_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 4224;
            string copyNum = number.ToString();
            string reverse = "";

            for (int i = copyNum.Length - 1; i >= 0; i--)
            {
                reverse += copyNum[i].ToString();
            }

            bool flag = copyNum == reverse;

            Console.WriteLine($"{flag}");

            Console.ReadKey();
        }
    }
}
