using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1011213_Assignment5_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int k=0;
           int i = 0;
           int j = 0;
          
           Console.Write("請問總共有幾個站：");
           int number= Convert.ToInt32( Console.ReadLine());

           string[] name = new string[number];
            int[,] price = new int[number,number];

            Console.WriteLine();

           for ( i = 0; i < number; i++)
           {

               Console.Write("請輸入站名：");
               name[i]= Console.ReadLine();
               k=i;
            
           }

           Console.WriteLine("\n請輸入票價：");

           for ( i = 0; i < number * (number - 1); i++)
           {
               for ( j = i+1; j < number; j++)
               {
                   
                   Console.Write("起站：{0} 終站：{1} 票價為：", name[i], name[j]);
                   price[i,j] =Convert.ToInt32( Console.ReadLine());
                   Console.Write("起站：{0} 終站：{1} 票價為：", name[j], name[i]);
                   price[j,i] = Convert.ToInt32(Console.ReadLine());
                  
     
               }
           
           }

           Console.WriteLine("\n起點 終點 票價");

           for (i = 0; i < number; i++)
           {
               for ( j = 0; j < number; j++)
               {
                   if (i != j)
                   {
                       Console.WriteLine("{0} {1} {2}", name[i], name[j], price[i, j]);
                       // Console.WriteLine("{0} {1} {2}", name[j], name[i],price[j,i]);
                   }
               }
             
           }
       
        }
    }
}
