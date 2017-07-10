using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "丁六", "鄭七" };

            Console.Write("請輸入人數: ");
            int p = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < p; i++)
            {
                int e = r.Next(7);
                Console.WriteLine("{0}", Name[e]);

            }
        }
    }
}
