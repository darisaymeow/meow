using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Switch
    {
        public int[] ArrSwitch(int[] mass)
        {
            int imin = mass.Select((v, i) => v == mass.Min() ? i + 1 : 0).OrderBy(v => v).Where(v => v != 0).First() - 1; //индекс первого минимального
            int imax = mass.Length - mass.Reverse().Select((v, i) => v == mass.Max() ? i + 1 : 0).OrderBy(v => v).Where(v => v != 0).First();//индекс последнего максимального
            int imin1 = mass.Select((v, i) => v == mass.Max() ? i + 1 : 0).OrderBy(v => v).Where(v => v != 0).First() - 1; //индекс первого минимального
            int imax1 = mass.Length - mass.Reverse().Select((v, i) => v == mass.Min() ? i + 1 : 0).OrderBy(v => v).Where(v => v != 0).First();//индекс последнего максимального
            if (imin < imax)
            {
                int[] rev = mass.Skip(imin + 1).Take(imax - imin - 1).Reverse().ToArray();//выделяем нужные элементы и инвертируем
                int[] before = mass.Where((v, i) => i <= imin).ToArray();//элементы до минимального (включая минимальный)
                int[] after = mass.Where((v, i) => i >= imax).ToArray();//элементы после максимального (включая максимальный)
                mass = before.Concat(rev).ToArray().Concat(after).ToArray();//объединяем

            }
            if (imin1 < imax1)
            {
                int[] rev = mass.Skip(imin1 + 1).Take(imax1 - imin1 - 1).Reverse().ToArray();//выделяем нужные элементы и инвертируем
                int[] before = mass.Where((v, i) => i <= imin1).ToArray();//элементы до минимального (включая минимальный)
                int[] after = mass.Where((v, i) => i >= imax1).ToArray();//элементы после максимального (включая максимальный)
                mass = before.Concat(rev).ToArray().Concat(after).ToArray();//объединяем

            }

            return mass;
        }
    }
}
