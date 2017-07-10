using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment6_1
{

    class Program
    {

       
        static string[] SamplingWithReplacement(string[] x, int number)
        {
            Random r = new Random();
            int w = x.Length;
            for (int i = 0; i < number; i++)
            {
                int e = r.Next(w);
                Console.WriteLine("{0}", x[e]);
                if (x[e] == x[w - 1])
                {
                }
                else
                {
                    x[e] = x[w - 1];
                }
                w--;               
            }        
            return x;
            
        }
        static void Main(string[] args)
        {
            string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "丁六", "鄭七" };
            Console.Write("請輸入人數：");
            int number = Convert.ToInt32(Console.ReadLine());
            SamplingWithReplacement(Name, number);
 
        }
    }
}
