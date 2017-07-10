using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
            string[] station = { "台北", "桃園", "台中", "高雄" };
            bool a = false;
            int j=0,k = 0;
           

            Console.Write("請輸入起站站名：");
            string Name = Console.ReadLine();

            for (int i = 0; i < station.Length; i++)
            {
                if (Name == station[i])
                {
                    a = true;
                    //     continue;
                    j = i;
                }
            }

            if (a == false)
            {
                for (int t = 1; t > 0; t++)
                {
                    Console.WriteLine("起站名輸入錯誤...\n");
                    Console.Write("請輸入起站站名：");
                    Name = Console.ReadLine();
                    for (int i = 0; i < station.Length; i++)
                    {
                        if (Name == station[i])
                        {
                            a = true;
                            j = i;
                            break;
                        }
                    }
                    
                    if (a == true)

                    { break; }
                }
            }

            a = false;

            Console.Write("請輸入終站站名：");
            string Name1 = Console.ReadLine();

            for (int i = 0; i < station.Length; i++)
            {
                if (Name1 == station[i])
                {
                    a = true;
                    k = i;
                }
            }


            if (a == false)
            {
                for (int t = 1; t > 0; t++)
                {
                    Console.WriteLine("終站名輸入錯誤...\n");
                    Console.Write("請輸入終站站名：");
                    Name1 = Console.ReadLine();
                    for (int i = 0; i < station.Length; i++)
                    {
                        if (Name1 == station[i])
                        {
                            a = true;
                            k = i;
                            break;
                        }
                    }

                    if (a == true)

                    { break; }
                }
            }

            Console.Write("\n起站為：{0},終站為：{1},票價為：{2} \n", Name, Name1,price[j,k]);


        }
    }
}
