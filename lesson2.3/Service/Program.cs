using System;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Service";

            Console.WriteLine("Service started...");

            ServiceHost host = new ServiceHost(typeof(Contract));
            host.Open();

            Console.WriteLine("Press any key for exit...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
