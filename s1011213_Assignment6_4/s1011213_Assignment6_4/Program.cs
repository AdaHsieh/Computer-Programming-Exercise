using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment6_4
{
    class MyMath
    {

        static long Factorial(int n)
        {
            int a = n;
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                a = 1 * i;
                sum = sum * a;
            }
            return sum;
        }
        static long Permutation(int x, int y)
        {
            long a = x;
            long b = y;
            long sum = 1;
            long sum1 = 1;
            long c = x - y;
            for (int i = 1; i <= x; i++)
            {
                a = 1 * i;
                sum = sum * a;
            }
            for (int i = 1; i <= (x - y); i++)
            {

                c = 1 * i;
                sum1 = sum1 * c;
            }
            a = sum / sum1;
            return a;
        }
        static long Combination(int x, int y)
        {

            long a = x;
            long b = y;
            long sum = 1;
            long sum1 = 1;
            long sum2 = 1;
            long c = x - y;
            for (int i = 1; i <= x; i++)
            {
                a = 1 * i;
                sum = sum * a;
            }
            for (int i = 1; i <= y; i++)
            {
                b = 1 * i;
                sum2 = sum2 * b;
            }
            for (int i = 1; i <= (x - y); i++)
            {
                c = 1 * i;
                sum1 = sum1 * c;
            }
            a = sum / sum1 / sum2;

            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("元智童軍團共有15個成員，全體團員排成一列共有幾種排法？");
            int n = 15;
            Factorial(n);
            Console.WriteLine(Factorial(n));

            Console.WriteLine("從15 個團員中挑選8 個，排成一列共有幾種排法？");
            int m = 15;
            int k = 8;
            Permutation(m, k);
            Console.WriteLine(Permutation(m, k));

            Console.WriteLine("從15 個團員中挑選8 個，排成一列共有幾種排法？");
            int c = 15;
            int d = 8;
            Permutation(c, d);
            Console.WriteLine(Combination(c, d));

        }

    }
    class Program
    {
        static void Min(string[] args)
        {
        }
    }
}
