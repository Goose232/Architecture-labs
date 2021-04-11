using System;
using System.Collections;

namespace XMLRPCClient
{
    class Program
    {
        static ServObj serv;

        static void Main(string[] args)
        {
            serv = new ServObj("http://127.0.0.1:8301");
            ArrayList mtrx = new ArrayList();
            ArrayList response_arr = null;
            Console.Write("Введите размер квадратной матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Заполните  матрицу: ");
            string[] tmp_arr = new string[size*size] ;
            for (int i = 0; i < size*size; ++i)
            {
                Console.WriteLine("№" + (i+1)+ ":" );
                tmp_arr[i] = Console.ReadLine();
                mtrx.Add(Convert.ToInt32(tmp_arr[i]));
            }
            Console.WriteLine("=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");


            Console.WriteLine("=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Исходная матрица\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(mtrx[j + i * size] + "\t");
                Console.WriteLine("\n");
            }
            Console.WriteLine("=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            Console.WriteLine("Ожидайте ответа от сервера...\n");
            response_arr = serv.SendMatrix(mtrx, size); //Отправляем матрицу


            Console.WriteLine("\nМинимальный элемент: " + response_arr[size * size] + "\n");
            response_arr.RemoveAt(size * size);

            Console.WriteLine("Результат:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(response_arr[j + i * size] + "\t");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
