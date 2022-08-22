using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw15.Task1.Extensions
{
    internal static class StringExtensions
    {
        public static int Number(this string str)
        {

                if (str.ToUpper().Equals("TRUE"))
                    return 1;
                else if (str.ToUpper().Equals("FALSE"))
                    return 0;
                else
                    throw new Exception("Не правильный формат ввода");

        }


        public static string CutString(this string str2)
        {
            StringBuilder stringBuilder = new StringBuilder(str2);
            string str3 = "...";
            stringBuilder.Remove(9, stringBuilder.Length - 9);
            stringBuilder.AppendFormat("{0}", str3);
            return stringBuilder.ToString();
        }
             
 
    }
}
