using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "丁六", "鄭七" };
            int[] Chinese = { 80, 45, 60, 90, 20, 50, 70 };
            int a;
            string b;
            for (int j = 0; j < Name.Length; j++)
            {
                for (int i = j + 1; i < Name.Length; i++)
                {
                    if (Chinese[i] > Chinese[j])
                    {
                        a = Chinese[j];
                        Chinese[j] = Chinese[i];
                        Chinese[i] = a;

                        b = Name[j];
                        Name[j] = Name[i];
                        Name[i] = b;
                    }
                }
            }
            for (int k = 0; k < Name.Length; k++)
            {
                Console.WriteLine("{0}：{1}", Name[k], Chinese[k]);
            }
        }
    }
}
