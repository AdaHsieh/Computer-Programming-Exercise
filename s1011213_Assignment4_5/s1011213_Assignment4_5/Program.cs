using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "丁六", "鄭七" };
            int[] Chinese = { 80, 45, 60, 90, 20, 50, 70 };

            Console.Write("成績分割點 (只能輸入0~100 的整數)：");
            string x1 = Console.ReadLine();
            int x = Convert.ToInt32(x1);

            Console.WriteLine();

            Console.WriteLine("國文成績大於及等於{0}者：", x);
            Console.WriteLine("姓名　成績");
            for(int i=0;i< Chinese.Length;i++)
            {
                if (Chinese[i]>=x)

                {   
                    Console.WriteLine("{0} 　{1}",Name[i],Chinese[i]); }

               
            }

            Console.WriteLine();

            Console.WriteLine("國文成績小於{0}者：", x);
            Console.WriteLine("姓名　成績");
            for (int i = 0; i < Chinese.Length; i++)
            {
                if (Chinese[i] < x)
                {
                    Console.WriteLine("{0} 　{1}", Name[i], Chinese[i]);
                }


            }
        }
    }
}
