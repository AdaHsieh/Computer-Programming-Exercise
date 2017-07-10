using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            string number = Console.ReadLine();
            int number_n = Convert.ToInt32(number);

            Console.Write("The number in reverse order is: ");

            int a = 1;

            do
            {
                a = number_n % 10;
                number_n = number_n / 10;
                Console.Write("{0}", a);

            }

            while (number_n > 0);

            Console.WriteLine();
        }
    }
}
