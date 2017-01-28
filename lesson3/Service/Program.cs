using System;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Contract));
            host.Open();

            Console.WriteLine("[service]: started...");
            Console.ReadKey();

            host.Close();
        }
    }
}
