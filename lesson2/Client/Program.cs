using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    interface IHello
    {
        [OperationContract]
        string sayHello(string name);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";

            // TCP
            ChannelFactory<IHello> cfNet = new ChannelFactory<IHello>(
                new NetTcpBinding(),
                new EndpointAddress(@"net.tcp://localhost:3121/Hello")
            );

            IHello HelloTcp = cfNet.CreateChannel();
            string TcpResult = HelloTcp.sayHello("TCP");

            Console.WriteLine(TcpResult);

            // PIPE
            ChannelFactory<IHello> cfPipe = new ChannelFactory<IHello>(
                new NetNamedPipeBinding(),
                new EndpointAddress(@"net.pipe://localhost/Hello")
            );

            IHello HelloPipe = cfPipe.CreateChannel();
            string PipeResult = HelloPipe.sayHello("PIPE");

            Console.WriteLine(PipeResult);
        }
    }
}
