using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {/*
          班級:工管一A
          學號:1011213
          姓名:謝凱靜
          */
            string n1;
            double a;


            Console.Write("Enter a number: ");
            n1 = Console.ReadLine();
            a = Convert.ToDouble(n1);

            Console.Write("Enter a second number: ");
            string n2 = Console.ReadLine();
            double b = Convert.ToDouble(n2);

            Console.Write("Enter a third number: ");
            string n3 = Console.ReadLine();
            double c = Convert.ToDouble(n3);

            Console.Write("Enter a fourth number: ");
            string n4 = Console.ReadLine();
            double d = Convert.ToDouble(n4);

            Console.WriteLine("The four numbers are:  \" {0} \",\" {1} \" ,\" {2} \" ,\" {3} \"", a, b, c, d);

            double e = a + b + c + d;
            Console.WriteLine("The sum of the four numbers are: {0,10}", e);

            double f = e / 4.000;
            Console.WriteLine("The average of the four numbers are: {0,10:N3}", f);

        }
    }
}
