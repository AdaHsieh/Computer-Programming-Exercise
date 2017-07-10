using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment3_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
                
                Console.Write("Enter the number: ");
                string large = Console.ReadLine();
                int large_n = Convert.ToInt32(large);
            
            int i =1;
            while (i < 10)
            {
                Console.Write("Enter the number: ");
                string a = Console.ReadLine();
                int a_n = Convert.ToInt32(a);
                i++;
                if (a_n > large_n)
                    large_n = a_n;
             
            }
                 Console.WriteLine("Largest number: {0}",large_n);
        }
    }
}
