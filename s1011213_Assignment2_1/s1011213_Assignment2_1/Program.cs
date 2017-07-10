using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {/*
          班級:工管一A
          學號:1011213
          姓名:謝凱靜
          */

            string year ,weight ;
            int year1 ,weight1;

            Console.Write("Please enter a year: ");
            year = Console.ReadLine();
            year1 = Convert.ToInt32(year);

            Console.Write("Please enter a weight: ");
            weight = Console.ReadLine();
            weight1 = Convert.ToInt32(weight);

            
            if (year1<=1990 & weight1<2700)
                Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 1, 26.5);

            if (year1 <= 1990 & weight1 >= 2700 & weight1 < 3800)
                Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 2, 35.5);
             if (year1<=1990 & weight1 >3800)
                Console.Write("The weight class is {0} and the fee is {1:C2}",3,56.5);

             if (year1>1990 & year1 <= 1999 & weight1<2700)
                Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 4, 35);

            if (year1> 1990 & year1 <= 1999 & weight1 >= 2700 & weight1 < 3800)
                Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 5, 45.5);

             if (year1>1990 & year1 <= 1999 & weight1 >3800)
                Console.Write("The weight class is {0} and the fee is {1:C2}",6,62.5);

             if (year1 >= 2000 & weight1 < 3500)
                 Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 7, 49.5);

             if (year1 >= 2000 & weight1 >= 3500)
                 Console.WriteLine("The weight class is {0} and the fee is {1:C2}", 8, 62.5);
             




        }
    }
}
