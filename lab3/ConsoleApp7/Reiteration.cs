using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    public class Reiteration
    {
        public int ArrReiteration(int[] array)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    dict[array[i]]++;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }

            int maxCount = 0;
            int maxValue = 0;
            foreach (var element in dict)
            {
                if (element.Value > maxCount)
                {
                    maxValue = element.Key;
                    maxCount = element.Value;
                }
            }

            return maxValue;

        }
    }
}