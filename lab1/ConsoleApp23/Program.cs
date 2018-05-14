using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            int days = 0;
            Console.WriteLine("Введите год: ");
            year = int.Parse(Console.ReadLine());
            DaysСountering counter = new DaysСountering();
            days = counter.countering(year);
            Console.WriteLine(days);
            Console.Read();
        }
    }
}