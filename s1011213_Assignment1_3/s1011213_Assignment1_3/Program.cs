using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          班級:工管一A
          學號:1011213
          姓名:謝凱靜
          */ 
            Console.Write("Enter year: ");
            string year1 = Console.ReadLine();
            int a1 = Convert.ToInt32(year1);

            if (a1 % 400 == 0 || (a1 % 4 == 0 && a1 % 100 != 0))
                Console.WriteLine("{0} is a leap year!", a1);
            else
                Console.WriteLine("{0} is not a leap year!", a1);

        }
    }
}
