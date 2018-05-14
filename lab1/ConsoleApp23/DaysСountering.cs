using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class DaysСountering 
    {
        public int countering(int year)
        {
            int days = 0;

            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))

            {
                days = 366;
            }
            else
            {
                days = 365;
            }

            return days;
        }
        
    }
}
