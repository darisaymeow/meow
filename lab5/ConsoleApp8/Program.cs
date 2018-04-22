using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8

{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalLetters object1 = new CapitalLetters();
            Console.WriteLine("Введите строку с данными: "); string str = Console.ReadLine();
            string result = object1.capital(str);
            Console.ReadKey();
            Console.WriteLine("До: {0}", str);
            Console.WriteLine("После: {0}", result);
            Console.ReadLine();
        }
    }
}