using System;
using ClientServiceReference.ClientServiceReference;

namespace ClientServiceReference
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloClient clientTcp = new HelloClient("NetTcpBinding_IHello", "net.tcp://localhost:3121/Hello");
            string result = clientTcp.sayHello("Vladimir");

            Console.WriteLine(result);
        }
    }
}
