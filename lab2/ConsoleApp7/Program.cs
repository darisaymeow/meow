using System;

namespace ConsoleApp8

{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalLetters capitalizer = new CapitalLetters();
            Console.WriteLine("Введите строку с данными: ");
            string str = Console.ReadLine();
            string result = capitalizer.ToCapital(str);
            Console.ReadKey();
            Console.WriteLine($"До: {str}");
            Console.WriteLine($"После: {result}");
            Console.ReadLine();
        }
    }
}