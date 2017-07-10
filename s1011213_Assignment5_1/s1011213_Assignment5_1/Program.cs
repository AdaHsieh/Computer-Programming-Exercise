using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
            string[] station = { "台北", "桃園", "台中", "高雄" };
            int i1=0,j1=0;
            double minn =price[0, 1];
            for(int i=0;i<price.GetLength(0);i++)
            {
                for (int j = 0; j < price.GetLength(0); j++)
                {
                    if (price[i, j] < minn && price[i, j] != 0)
                    {
                        minn = price[i, j];
                        i1 = i;
                        j1 = j;
                    }
                }
            }
            Console.WriteLine("最便宜的票價:{0}", minn);
            Console.WriteLine("起始站為:{0}",station[i1]); 
            Console.WriteLine("終點站站為:{0}",station[j1]);

        }

    }
}
