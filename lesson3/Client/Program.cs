using System;
using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter new name: ");
            string name = Console.ReadLine();

            ContractClient client = new ContractClient();
            client.UpdateData(name);
        }
    }
}
