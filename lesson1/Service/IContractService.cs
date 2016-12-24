using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    interface IContractService
    {
        [OperationContract]
        double Method(string str);

        string test(string s);
    }
}
