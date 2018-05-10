using System.Collections.Generic;
using System.Linq;

namespace DZ_9
{
    class Sorting
    {
        public List<int> SortRow(int[,] m)
        {
            List<int> t = new List<int>();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    t.Add(m[i, j]);
                }
                t = t.OrderByDescending(x => x).ToList();
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = t[j];
                }
                t.Clear();
            }
            return t;
        }

        public List<int> SortCol(int[,] m)
        {
            List<int> t = new List<int>();
            for (int i = 0; i < m.GetLength(1); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++) t.Add(m[j, i]);
                t = t.OrderByDescending(x => x).ToList();
                for (int j = 0; j < m.GetLength(0); j++) m[j, i] = t[j];
                t.Clear();
            }
            return t;
        }
    }
}
