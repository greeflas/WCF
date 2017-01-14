using System;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string Method();
    }

    class Contract : IContract, IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Destroy object {0}", this.GetHashCode());
        }

        public string Method()
        {
            Console.WriteLine("State size: {0}", new State().GetState());
            Console.WriteLine(OperationContext.Current.SessionId);

            return this.GetHashCode().ToString();
        }
    }
}
