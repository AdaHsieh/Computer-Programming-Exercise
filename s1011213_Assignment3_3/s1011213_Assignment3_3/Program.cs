using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type in the first number: ");
            string n1 = Console.ReadLine();
            double n11 = Convert.ToDouble(n1);

            Console.Write("Please type in the second number: ");
            string n2 = Console.ReadLine();
            double n22 = Convert.ToDouble(n2);

            Console.WriteLine("Enter one of the following code");
            Console.WriteLine("1 for addition");
            Console.WriteLine("2 for multiplication");
            Console.WriteLine("3 for division");
            Console.Write("You selection: ");
            string s1 = Console.ReadLine();
            int s = Convert.ToInt32(s1);

           
            double sum = n11 + n22,
                mul = n11 * n22,
                div = n11/n22;

            switch(s)
            {case 1:
                    Console.WriteLine("The sum of the numbers entered is: {0}",sum);
                    break;
                case 2:
                    Console.WriteLine("The product of the numbers entered is: {0}",mul);
                    break;
                case 3:
                    Console.WriteLine("Thes first number divided by the second number is: {0}",div);
                    break;
            }

        }
    }
}
