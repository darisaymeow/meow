using System;
using System.Collections.Generic;
using System.Linq;


namespace DZ_8
{
    class Zeroer

    {
        public void OutputList(int rows, List<List<int>> list)
        {
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < list.Count; columnIndex++)
                {
                    Console.Write("{0,3} ", list[columnIndex][rowIndex].ToString());

                }

                Console.WriteLine();
            }
        }
        public double CalcAvgOfPositive(List<List<int>> columns)
        {
            return columns.SelectMany(row => row.FindAll(value => value > 0)).DefaultIfEmpty(0).Average();
        }
        public List<List<int>> MakeRandomList(int rows, int columns)
        {
            List<List<int>> Array = new List<List<int>>();
            Random rnd = new Random();
            for (int i = 0; i < columns; i++)
            {
                List<int> ArrayRow = new List<int>();
                for (int j = 0; j < rows; j++)
                {
                    ArrayRow.Add(rnd.Next(-10, 10));
                }
                Array.Add(ArrayRow);
            }
            return Array;
        }
        public List<int> MakeZeroColumn(int rows)
        {
            List<int> EmptyRow = new List<int>();
            for (int j = 0; j < rows; j++)
            {
                EmptyRow.Add(0);
            }
            return EmptyRow;
        }
    }
}
