using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
            string[] station = { "台北", "桃園", "台中", "高雄" };
            int i1 = 0, j1 = 0;
            bool a = false;

            Console.WriteLine("起點 終點 票價");
            for (int i = 0; i < price.GetLength(0); i++)
            {
                a = false;
                for (int j = 0; j < price.GetLength(0); j++)
                {

                   

                    if (price[i, j] < 300)
                    {
                        price[i, j] = price[i, j] * 1.4;
                        a = false;
                    }

                    if (price[i, j] > 300 && price[i, j] < 600)
                    {
                        price[i, j] = price[i, j] * 1.2;
                        a = false;
                    }
                    if (price[i, j] == 0)
                    {
                        a = true;
                    }


                    i1 = i;
                    j1 = j;

                    if (a == false)
                    {
                        Console.WriteLine("{0} {1} {2}", station[i1], station[j1], price[i, j]);
                    }
                }

            }
       


        }
    }
}
