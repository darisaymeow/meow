using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
    using System.Security.Cryptography.X509Certificates;

    public class CapitalLetters
    {
        public string capital(string result)
        {
            char[] split = result.ToCharArray();
            split[0] = Char.ToUpper(split[0]);
            for (int n = 0; n < split.Length - 1; n++)
            {

                if (split[n] == ' ')
                {
                    split[n + 1] = Char.ToUpper(split[n + 1]);


                }

            }

            String result1 = new String(split);
            return result1;


        }
    }
}
