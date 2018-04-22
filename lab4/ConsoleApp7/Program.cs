
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {

            Switch arrswitch1 = new Switch();
            Console.WriteLine("Введите размерность массива:");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];
            Random ran = new Random();
            for (int i = 0; i < input; i++)
            {
                array[i] = ran.Next(-15, 15);
                Console.Write("{0} ", array[i]);

            }
            int[] result = arrswitch1.ArrSwitch(array);
            Console.WriteLine();

            foreach (int i in result)

            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
    }
}