using System;
using System.Collections.Generic;

namespace DZ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int str, stol;
            Console.WriteLine("Введите количество столбцов:");
            str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк:");
            stol = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[str, stol];
            Console.Clear();
            Random ran = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stol; j++)
                {
                    arr[i, j] = ran.Next(1, 10);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Заданный массив \n \n");
            Show(arr);
            Sorting sorter = new Sorting();
            List<int> SortRow = sorter.SortRow(arr);
            Console.WriteLine("Сортировка слева направо  \n \n");
            Show(arr);
            List<int> SortCol = sorter.SortCol(arr);
            Console.WriteLine("Сортировка сверху вниз  \n \n");
            Show(arr);
            Console.ReadKey();
        }

        static void Show(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
