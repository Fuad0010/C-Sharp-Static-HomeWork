using C_Sharp_Static_HomeWork.Helper;
using C_Sharp_Static_HomeWork.Models;
using System;

namespace C_Sharp_Static_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region static
            Person p1 = new Person();
            Console.WriteLine($"Id: {p1.Id} Count: {Person.Count}");

            Person p2 = new Person();
            Console.WriteLine($"Id: {p2.Id} Count: {Person.Count}");

            Person p3 = new Person();
            Console.WriteLine($"Id: {p3.Id} Count: {Person.Count}");

            Program program = new Program();
            program.GetInfo();

            #endregion
            string word = "lorem";
            Console.WriteLine(word.Reverse());

            int num = 10;
            Console.WriteLine(num.Pow(3));

            string word2 = "Lorem";
            Console.WriteLine(word2.IsUpr());







        }
        #region static class constructor
        public void GetInfo() // Program program = Program();  
        {                     // program.GetInfo();                 Bele cagrilir.

        }

        public static void getInfo() // getinfo();         bele cagrilir, zaten eyni seyfede olduguna gore "Program.getinfo();" defaultu beledir. 
        {

        }
        #endregion
    }
}
