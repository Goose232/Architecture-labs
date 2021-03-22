using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    static class Zadanie5
    {
      public static void z5()
        {
            Console.WriteLine("Задание 5");  
            int numberErat = Convert.ToInt32(Console.ReadLine()); // Ввод числа, до которого требуется искать простые числа
            Console.WriteLine();

            Console.WriteLine(" 2");
            bool isCasual = false;   // переменная для проверки числа 
            for (int i = 1; i <= numberErat; ++i)  // Выбираем все числа до заданного 
            {
                for (int j = i - 1; j >= 2; j--) // Перебираем все числа меньше заданного
                {
                    if (i % j == 0)  //Проверяем простое число или нет
                    {
                        isCasual = false; //Число не простое
                        break;
                    }
                    else
                        isCasual = true; //Число простое
                }
                if (isCasual)
                    Console.WriteLine(" " + i); // Выводим простое число
                isCasual = false;
            }
            Console.WriteLine("");

        }
    }
}
