using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   static class Zadanie2
   {
      public static void z2() 
      {
            Console.WriteLine("Задание 2");


            /*Console.WriteLine("1900 - Не високосный год");*/
            for (int j = 1900; j <= 2000; j++) // перебираем все года от 1900 до 2000
            {
                if ((j % 4 == 0) && (j % 400 != 300))
                {
                    Console.WriteLine(j + " - Високосный год"); // каждый 4 год - високосный кроме 1900 по григорианскому календарю
                }
                else
                {
                    Console.WriteLine(j + " - Не високосный год");
                }

            }
            Console.WriteLine("");
      }
   }
}
