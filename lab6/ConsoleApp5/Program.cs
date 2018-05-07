using System;
using System.Collections.Generic;


namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            Console.WriteLine("Введите количество элементов: ");
            int amountOfElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfElements; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                int element = int.Parse(Console.ReadLine());
                array.Add(element);
            }

            DeleteFromArray deleteFromArray = new DeleteFromArray();
            array = deleteFromArray.DeleteElement(array);

            Console.WriteLine("Результат: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}