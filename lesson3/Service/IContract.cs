using System.ServiceModel;

namespace Service
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    interface IContract
    {
        [OperationContract]
        void UpdateData(string name);
        [OperationContract]
        void UpdateFirstDb(string str);
        [OperationContract]
        void UpdateSecondDb(string str);
    }
}
