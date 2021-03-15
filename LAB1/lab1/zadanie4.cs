using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    static class Zadanie4 
    {
       public static void z4()
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Факториал какого числа надо найти?");
            int numFact = Convert.ToInt32(Console.ReadLine()); 
            int result = 0;

            if (numFact == 0) // если введенное число равно нулю
            {
                result = 1; 
                Console.WriteLine("Result: " + result); // выводим результат 1.
            }
            else // если число не равно нулю
            {
                int resultFact = 1; 
                for (int u = 1; u <= numFact; u++)
                {

                    resultFact = resultFact * u; // умножаем числа от 1 до введенного resultFact.


                }
                Console.WriteLine("Result: " + resultFact);
            }
            Console.WriteLine("");
        }
    }
}
