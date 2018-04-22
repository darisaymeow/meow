using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Reiteration arreiteration1 = new Reiteration();
            Console.WriteLine("Введите размерность массива:");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];
            Random ran = new Random();
            for (int i = 0; i < input; i++)
            {
                array[i] = ran.Next(-15, 15);
                Console.Write("{0} ", array[i]);

            }
            int result = arreiteration1.ArrReiteration(array);
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}