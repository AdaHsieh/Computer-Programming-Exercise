using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "丁六", "鄭七" };
            int[] Chinese = { 80, 45, 60, 90, 20, 50, 70 };

            Console.WriteLine("成績及姓名遞減排序");
            BubbleSort(Name,Chinese, 1);
            for (int i = 0; i < Chinese.Length; i++)
            {
                Console.WriteLine("{0},{1}",Name[i], Chinese[i]);
            }
            Console.WriteLine("===============");

            Console.WriteLine("成績及姓名遞增排序");
            BubbleSort(Name, Chinese, -1);
            for (int i = 0; i < Chinese.Length; i++)
            {
                Console.WriteLine("{0},{1}", Name[i], Chinese[i]);
            }
            Console.WriteLine("===============");
        }
        static void BubbleSort(string[] y,int[]x, int order)
        {
            if (order == 1)
            {
                int max = x[0];
                int a1;
                string b1;
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = i + 1; j < x.Length; j++)
                    {
                        if (x[j] > x[i])
                        {
                            a1 = x[i];
                            b1 = y[i];
                            x[i] = x[j];
                            y[i] = y[j];
                            x[j] = a1;
                            y[j] = b1;
                        }
                    }
                }

            }

            if (order == -1)
            {
                int max = x[0];
                int a1;
                string b1;
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = i + 1; j < x.Length; j++)
                    {
                        if (x[j] < x[i])
                        {
                            a1 = x[i];
                            b1 = y[i];
                            x[i] = x[j];
                            y[i] = y[j];
                            x[j] = a1;
                            y[j] = b1;
                        }
                    }
                }

            }
        }
    }
}
