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
            ServiceHost host = new ServiceHost(
                typeof(Hello),
                new Uri[]
                {
                    new Uri(@"net.tcp://localhost:3121/Hello"),
                    new Uri(@"net.pipe://localhost/Hello")
                }
            );

            host.AddServiceEndpoint(typeof(IHello), new NetTcpBinding(), "net.tcp://localhost:3121/Hello");
            host.AddServiceEndpoint(typeof(IHello), new NetNamedPipeBinding(), "net.pipe://localhost/Hello");

            host.Open();
        }
    }
}
