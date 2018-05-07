using System;
using System.Collections.Generic;

namespace lab6
{
    public class DeleteFromArray
    {

        public List<int> DeleteElement(List<int> array)
        {
            int a = Math.Abs(array[0]);

            for (int i = 0; i < array.Count; i++)
            {

                if (array[i] % a == 0)
                {
                    array.RemoveAt(i);
                }
            }

            return array;
        }


    }
}