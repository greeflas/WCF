using System;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ContractService));

            host.Open();
            Console.WriteLine("Service started...");
            Console.ReadKey();
            host.Close();
        }
    }
}
