using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    static class Zadanie3
    {
       public static void z3()
        {
            Console.WriteLine("Задание 3");

            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine()); //ввод числа

            int perv = 1;
            Console.Write(perv + " "); // вывод первого числа
            int vtor = 1;
            Console.Write(vtor + " "); // вывод второго числа
            int sum = 0; // сумма чисел

            while (number > sum) // пока число больше суммы 
            {
                sum = perv + vtor; // складываем первое и второе число

                Console.Write(sum + " "); // выводим эту сумму

                perv = vtor; // теперь первое число становится вторым 
                vtor = sum; // второе становится суммой первых двух

            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
