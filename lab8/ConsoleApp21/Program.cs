using System;
using System.Collections.Generic;

namespace DZ_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Zeroer zeroer = new Zeroer();
            List<int> EmptyRow = zeroer.MakeZeroColumn(rows);
            List<List<int>> list = zeroer.MakeRandomList(rows, columns);

            zeroer.OutputList(rows, list);

            double average = zeroer.CalcAvgOfPositive(list);
            if (average != 0)
            {
                Console.WriteLine("Средние значение положительных элементов равно = " + average);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Exists(value => Math.Abs(value) > average))
                    {
                        list.Insert(i + 1, EmptyRow);
                    }
                }
                Console.WriteLine("Выводим новый массив");
                zeroer.OutputList(rows, list);
            }
            else
            {
                Console.WriteLine("Нет положительных элементов.");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }

    }
}

