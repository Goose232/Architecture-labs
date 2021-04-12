using System;
using System.Collections;
using Nwc.XmlRpc;

namespace XMLRPCClient
{
    class ServObj
    {
        XmlRpcRequest client;
        String host = "http://127.0.0.1:8301";

        public ServObj()
        {
            client = new XmlRpcRequest();
        }
        public ServObj(String host)
        {
            this.host = host;
            client = new XmlRpcRequest();
        }

        public ArrayList SendMatrix(ArrayList mtrx, int size) //Отправка запроса
        {
            XmlRpcResponse response;
            ArrayList matrix = null;
            client.MethodName = "sample.Matrix";
            client.Params.Clear();
            client.Params.Add(mtrx);
            client.Params.Add(size);
            response = client.Send(host); //Отправляем запрос
            if (response.IsFault)
            {
                Console.WriteLine("Fault {0}: {1}", response.FaultCode, response.FaultString);
                return null;
            }
            else
            {
                matrix = (ArrayList)response.Value;
                return matrix;
            }
        }
    }
}
