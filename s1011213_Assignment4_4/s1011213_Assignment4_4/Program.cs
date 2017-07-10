using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment4_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ToDoList = { "準備統計小考", "領錢", "小工盃比賽", "看電影", "買文具","睡覺","吃飯" };
            string[] number = { "一", "二", "三", "四", "五", "六", "七" };
            int i = 0;

            Console.Write("請輸入欲查看事件的個數：");
            string a1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            Console.WriteLine();

            if (a > ToDoList.Length || a < 1)
            {
                Console.WriteLine("請輸入整數1~{0}", ToDoList.Length);
            }

                
            else
            {
                i = a - 1;
                Console.WriteLine("前 {0} 重要的事項有 : ", number[i]);
               
                for ( i = 1; i <= a; i++)
                {

                    Console.WriteLine("{0}：　{1}", number[i-1], ToDoList[i - 1]);

                }
            }
        }
    }
}
