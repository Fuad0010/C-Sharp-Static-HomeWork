using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Static_HomeWork.Models
{
    internal class Person
    {
       public static int Count; 
       
       public int Id;
        public Person()
        {
            Count++;
            Id++;
        }

        public class test
        {
            public int b;
            public static int a;   // konstraktora null instans yerlewdirmek olar.


            public static void Get()
            { 
            // public int f;      // static metoda instans yerlewdirmek olmaz.
            }
        
        
        }

        public static class test1
        {
         // public int c;          // static konstraktora instans yerlewdire bilmerik. 
            public static int b;
        }


        //public class test : test1  // konstraktor static konstraktordan miras ala bilmez, 
        //{                          // ve ya onun ekside bir birinden miras ala bilmez.
        
        //}




    }
    
}
