using System;
using System.ServiceModel;

namespace Service
{
    class ContractService : IContractService
    {
        public double Method(string str)
        {
            Console.WriteLine($"Query: {str}");
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage);

            return (str == "double") ? 888 : 0;
        }

        public string test(string s)
        {
            return s;
        }
    }
}
