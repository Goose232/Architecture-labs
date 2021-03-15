using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
  static class Program
    {
        static void Main(string[] args)
        {
          
            Zadanie1.z1(args); // Задание 1. Передача аргументов в командной строке.
            int a = 0;
            while (a!=9) // Цикл для вывода меню и выбора задания.
            {

                // --Меню----------------------------------------------------------
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1--Задание 1 - Аргументы в командной строке");
                Console.WriteLine("2--Задание 2 - Високосные года");
                Console.WriteLine("3--Задание 3 - Числа Фибоначи");
                Console.WriteLine("4--Задание 4 - Факториал чиста");
                Console.WriteLine("5--Задание 5 - Решето Эратосфена");
                Console.WriteLine("9--Выход");
                // ----------------------------------------------------------------

                switch (a = Convert.ToInt32(Console.ReadLine())) // выбор задания от 1 до 5.
                {
                    case 1:
                        Zadanie1.z1(args);
                        break;

                    case 2:
                        Zadanie2.z2();
                        break;

                    case 3:
                        Zadanie3.z3();
                        break;

                    case 4:
                        Zadanie4.z4();
                        break;
                    
                    case 5:
                        Zadanie5.z5();
                        break;
                }
              
            }

        }

    }
    
}

