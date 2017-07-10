using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {/*
          班級:工管一A
          學號:1011213
          姓名:謝凱靜
          */
            Console.Write("Enter length: ");
            string length = Console.ReadLine();
            double lint = Convert.ToDouble(length);

            Console.Write("Enter width: ");
            string width = Console.ReadLine();
            double lwid = Convert.ToDouble(width);

            Console.Write("Enter depth: ");
            string depth = Console.ReadLine();
            double ldep = Convert.ToDouble(depth);

            Console.WriteLine("========== The Answer is ==========");

            double a1 = lint * lwid;
            double a2 = lint + lwid;
            double a3 = lint * ldep;
            double a4 = ldep * lwid;
            Console.WriteLine("Perimeter: {0}", a2 * 2);
            Console.WriteLine("Volume: {0}", a1 * ldep);
            Console.WriteLine("Underground Surface area: {0}", 2 * (a3 + a4) + a1);

        }
    }
}
