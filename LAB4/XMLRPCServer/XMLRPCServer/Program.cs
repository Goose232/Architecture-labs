using System;
using System.Collections;
using Nwc.XmlRpc;

namespace XMLRPCServer
{
    class Server
    {
        const int port = 8301;

        static void Main(string[] args)
        {
            XmlRpcServer server = new XmlRpcServer(port);
            server.Add("sample", new Server());
            Console.WriteLine("Сервер запущен");
            server.Start(); //Запуск сервера
        }

        [XmlRpcExposed]
        public ArrayList Matrix(ArrayList mtrx, int size)//функция для обработки матрицы
        {
            int min1 = 99999999; 
            int min2 = 99999999; 
            int count = 0;
            int count1 = size-1;
            int i, j;

            /////////////////////////////////////////////////////////////////////////  поиск минимального значения в двух диагоналях
            for (i = 0; i < size*size; i=i+size+1) 
            {
                
                    if ((int)mtrx[i] <= min1)
                    {

                        
                        min1 = (int)mtrx[i];
                    }
                
            }

            for (i = size-1; i < size * size - (size - 1); i = i + (size - 1))
            {

                if ((int)mtrx[i] <= min2)
                {

                    min2 = (int)mtrx[i];
                }

            }
            /////////////////////////////////////////////////////////////////////////
            if (min1 < min2) // если минимальное число в главной диагонали
            {
                for (i = 0; i < size * size; i = i + size + 1)
                {
                    mtrx[i] = 0; // заменяем диагональ на нули
                }
                for (i=1; i < size; i++)
                {
                    count = count + size + 1;
                   
                        for(j = i * size; j < count; j++)
                        {
                        mtrx[j] = (int)mtrx[j] * (int)mtrx[j]; // возводим в квадрат все что ниже диагонали
                        }
                    

                }
            }
           
            if (min2 < min1) //если минимальное число в побочной диагонали
            {
                for (i = size - 1; i < size * size - (size - 1); i = i + (size - 1))
                {
                    mtrx[i] = 0;  // заменяем диагональ на нули
                }
                for (i = 2; i < size+1; i++)
                {
                    count1 = count1 + size-1;

                    for (j = i * size - 1; j > count1; j--)
                    {
                        mtrx[j] = (int)mtrx[j] * (int)mtrx[j]; // возводим в квадрат все что ниже диагонали
                    }

                }

            }

            if (min1==min2)
            {
                for (i = size - 1; i < size * size - (size - 1); i = i + (size - 1))
                {
                    mtrx[i] = 0;  // заменяем диагональ на нули
                }
                for (i = 0; i < size * size; i = i + size + 1)
                {
                    mtrx[i] = 0; // заменяем диагональ на нули
                }
                for (i = size; i < size*size; i++)
                {
                             
                        mtrx[i] = (int)mtrx[i] * (int)mtrx[i]; // возводим в квадрат все что ниже диагонали
                    

                }


            }

            if (min1 <= min2) // добавляем минимальное число в конец массива
            {
                mtrx.Add(min1);
            }else
            {
                mtrx.Add(min2);
            }
            return mtrx;
        }
    }
}
