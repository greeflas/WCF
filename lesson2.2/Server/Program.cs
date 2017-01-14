using System;
using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    interface IHello
    {
        [OperationContract]
        string sayHello(string name);
    }

    public class Hello : IHello
    {
        public string sayHello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage.ToString());

            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Service started...");

            ServiceHost host = new ServiceHost(typeof(Hello));
            host.Open();

            Console.WriteLine("Press any key for exit...");
            Console.ReadKey();
        }
    }
}
