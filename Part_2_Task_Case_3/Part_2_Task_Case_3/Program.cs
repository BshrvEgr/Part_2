using System;

namespace Part_2_Task_Case_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Введите номер месяца: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Месяц: январь");
                    Console.WriteLine("Время года: зима");
                    break;
                case 2:
                    Console.WriteLine("Месяц: февраль");
                    Console.WriteLine("Время года: зима");
                    break;
                case 3:
                    Console.WriteLine("Месяц: март");
                    Console.WriteLine("Время года: весна");
                    break;
                case 4:
                    Console.WriteLine("Месяц: апрель");
                    Console.WriteLine("Время года: весна");
                    break;
                case 5:
                    Console.WriteLine("Месяц: май");
                    Console.WriteLine("Время года: весна");
                    break;
                case 6:
                    Console.WriteLine("Месяц: июнь");
                    Console.WriteLine("Время года: лето");
                    break;
                case 7:
                    Console.WriteLine("Месяц: июль");
                    Console.WriteLine("Время года: лето");
                    break;
                case 8:
                    Console.WriteLine("Месяц: август");
                    Console.WriteLine("Время года: лето");
                    break;
                case 9:
                    Console.WriteLine("Месяц: сентябрь");
                    Console.WriteLine("Время года: осень");
                    break;
                case 10:
                    Console.WriteLine("Месяц: октябрь");
                    Console.WriteLine("Время года: осень");
                    break;
                case 11:
                    Console.WriteLine("Месяц: ноябрь");
                    Console.WriteLine("Время года: осень");
                    break;
                case 12:
                    Console.WriteLine("Месяц: декабрь");
                    Console.WriteLine("Время года: зима");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
