﻿using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;

namespace l3
{
    class ChatClient
    {
        public static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        public static string message;

       public static void func()
        {
           /* Console.Write("Введите свое имя: ");*/
            
            client = new TcpClient();
            try
            {
                client.Connect(host, port); //подключение клиента
                stream = client.GetStream(); // получаем поток

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока
                /*Console.WriteLine("Добро пожаловать, {0}", userName);*/
                SendMessage();
            }
            catch (Exception ex)
            {
              /*  Console.WriteLine(ex.Message);*/
            }
            finally
            {
                Disconnect();
            }
        }
        // отправка сообщений
       public static void SendMessage()
        {
           /* Console.WriteLine("Введите сообщение: ");*/

            while (true)
            {
                message = "";
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
        }
        // получение сообщений
       public static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    message = builder.ToString();
                    /*Console.WriteLine(message);*///вывод сообщения
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }
}