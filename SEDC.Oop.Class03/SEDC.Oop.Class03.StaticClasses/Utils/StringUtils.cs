using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class03.StaticClasses.Utils
{
    public static class StringUtils
    {
        public static string CapitaliseFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            if(str.Length == 1)
            {
                return str.ToUpper();
            }

            string capitalizedLatter = str[0].ToString().ToUpper();

            return $"{capitalizedLatter}{str.Substring(1)}";
        }

        public static int VerifyStringNumber (string str)
        {
            
            

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            if(int.TryParse(str, out int result))
            {
                return result;
            }
            else
            {
                return -1;
            }
            
        }
    }


}
