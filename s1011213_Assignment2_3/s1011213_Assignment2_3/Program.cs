using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment2_3
{
    class Program
    {/*
      * 學號:1011213
      * 班級:工管1A
      * 姓名:謝凱靜
      */
   
        static void Main(string[] args)
        {
            string a1,d1,n1 ;
            int an,dn,nn;
            Console.Write("Please enter the value of a: ");
            a1=Console.ReadLine();
            an = Convert.ToInt32(a1);

            Console.Write("Please enter the value of d: ");
            d1 = Console.ReadLine();
            dn = Convert.ToInt32(d1);

            Console.Write("Please enter the value of n: ");
            n1 = Console.ReadLine();
            nn = Convert.ToInt32(n1);

            Console.WriteLine(" n       Tern   Sum");
            Console.WriteLine("---      ----   ---");
            
            int n=1,t=1,sum=1;
            while (n <= nn)
            { 
                Console.WriteLine("{0,3}      {1,2}     {2,-3}",n,t,sum); 
            n = n +1;
            t = t + dn;
            sum = sum + t;
            }

        }
    }
}
