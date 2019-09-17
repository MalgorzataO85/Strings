using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public static class Extensions
    {
        public static void PrintTxt(this Print val)  //this bo rozszerzamy Print, this - ten obiekt, parametr
        {
            Console.WriteLine("TXT");
        }

        public static string Left(this string val, int digits = 1)
        {
            try
            {
                return val.Substring(0, digits);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new Exception("Błędna długość");
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
