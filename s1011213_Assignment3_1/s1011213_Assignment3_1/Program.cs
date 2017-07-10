using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mile1  , gallon1;
            double in_m=0,  in_g,t1=0, total=0 ,a=0,b=0;

            Console.Write("Enter miles driven (-1 to quit): ");
            mile1 = Console.ReadLine();
            in_m = Convert.ToDouble(mile1);

            while (in_m != -1)
            {
             
                Console.Write("Enter gallons used: ");
                gallon1 = Console.ReadLine();
                in_g = Convert.ToDouble(gallon1);
                t1 = in_m / in_g;
                a = t1 * in_g + a;
                b = in_g + b;
                total = a / b;

                Console.WriteLine("MPG this tankful: {0}", t1);
                Console.WriteLine("Total MPG: {0}", total);

                Console.WriteLine("");

                if(in_m != -1)
                    Console.Write("Enter miles driven (-1 to quit): ");
                mile1 = Console.ReadLine();
                in_m = Convert.ToDouble(mile1);
            }


                
       
        
        }
    }
}
