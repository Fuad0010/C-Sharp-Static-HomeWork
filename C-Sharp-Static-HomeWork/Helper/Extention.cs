using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Static_HomeWork.Helper
{
    static class Extention
    {

        public static StringBuilder Reverse(this string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }return result;
        }
        
        public static int Pow(this int num1,int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }return result;
        }


        public static bool IsUpr(this string str)
        {
            bool result = false;
            foreach (var item in str)
            {
                
            if (char.IsUpper(item))
                {
                    result = true;
                }
            }return result;
        }


    
    }
}
