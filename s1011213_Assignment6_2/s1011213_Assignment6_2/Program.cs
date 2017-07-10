using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Chinese = { 80, 45, 60, 90, 20, 50, 70 };
       

            Console.WriteLine("成績遞減排序");
            BubbleSort(Chinese, 1);
            for (int i = 0; i < Chinese.Length; i++)
            {
                Console.WriteLine("{0}", Chinese[i]);
            }
            Console.WriteLine("===============");

            Console.WriteLine("成績遞增排序");
            BubbleSort(Chinese, -1);
            for (int i = 0; i < Chinese.Length; i++)
            {
                Console.WriteLine("{0}", Chinese[i]);
            }
            Console.WriteLine("===============");
        }

        static void BubbleSort(int[] x, int order)
        {
            if (order == 1)
            {
                int max = x[0];
                int a1;
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = i + 1; j < x.Length; j++)
                    {
                        if (x[j] > x[i])
                        {
                            a1 = x[i];
                            x[i] = x[j];
                            x[j] = a1;
                        }
                    }
                }

            }

            if (order == -1)
            {
                int max = x[0];
                int a1;
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = i + 1; j < x.Length; j++)
                    {
                        if (x[j] < x[i])
                        {
                            a1 = x[i];
                            x[i] = x[j];
                            x[j] = a1;
                        }
                    }
                }

            }
        }
    }
}
