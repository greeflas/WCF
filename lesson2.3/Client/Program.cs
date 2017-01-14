using System;
using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";

            ContractClient clientTcp = new ContractClient("NetTcpBinding_IContract", "net.tcp://localhost:2131/Contract");

            for(int i = 0; i < 5; i++)
            {
                string hash = clientTcp.Method();

                Console.WriteLine("Hash code: {0}", hash);
                Console.WriteLine("Session ID: {0}", clientTcp.InnerChannel.SessionId);
                Console.WriteLine();
            }
        }
    }
}
