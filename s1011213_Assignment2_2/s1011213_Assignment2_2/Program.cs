using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment2_2
{
    class Program
    { /*
       * 學號:1011213
       * 班級:工管1A
       * 姓名:謝凱靜
       */ 
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("                    END-OF-YEAR   ACCUMULATED");
            Console.WriteLine("YEAR  DEPRECIATION    VALUE       DEPRECIATION");
            Console.WriteLine("----  ------------  -----------   ------------");

            int year = 1, dep = 4000, end = 24000, acc = 4000;
            while (year <= 7)
            {
                Console.WriteLine("{0}     {1,11}  {2,10}   {3,13}", year, dep,end,acc);
                year = year + 1;
                end= end-4000;
                acc = acc + 4000;
            }
        }
    }
}
