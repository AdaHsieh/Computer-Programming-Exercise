using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; // e = 0; //設置i變數;
            string b = "";

            int[] number = new int[10]; //建立一個單位10的矩陣
            string[] name = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int max = 0; //假設最大值max

            //  Console.Write("Emter a number : "); //輸入第一個數值
            // string x = Console.ReadLine();
            // number[0] = Convert.ToInt32(x);
            max = number[0]; //使第一個數值為最大值


            for (i = 0; i < number.Length; i++) //進入迴圈
            {
                Console.Write("Enter a number : ");
                string y = Console.ReadLine();
                number[i] = Convert.ToInt32(y);

                if (number[i] >= max)
                {
                    max = number[i];
                   // e = i;
                }
            }

            for (i = 0; i < number.Length; i++)
            {

                if (number[i] == max)
                {
                   // e = i;
                    b = name[i];

                }
            }

            Console.WriteLine("\nLargest number is : {0}", max);
            Console.WriteLine("It's element number(s) is : {0}",b);

        }
    }
}
