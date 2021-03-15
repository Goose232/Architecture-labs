using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   static class Zadanie1
    {

      public  static void z1 (string[] args)
        {
            Console.WriteLine("Задание 1");

            Console.WriteLine("Количество аргументов: " + args.Length); //выводит количество аргументов
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]); // выводит все аргументы, переданные в командной строке
            }
            Console.WriteLine("");
        }

    }
}
