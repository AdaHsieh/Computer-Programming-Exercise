using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double sum = 0 ,averge = 0;
           
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Experiment {0} ", i);

                sum = 0;

                for (int j = 1; j < 7; j++)
                {
                    
                    Console.Write("Enter test result {0}:", j);
                    string a = Console.ReadLine();
                    double a1 = Convert.ToDouble(a);
                   
                    sum = a1 + sum;
                    averge = sum / 6;

                    
                   
                }
                
                
                Console.WriteLine("The average of Experiment {0}: {1}", i, averge);
               

               

                
            }
        }
    }
}
