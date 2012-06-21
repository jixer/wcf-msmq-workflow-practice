using System.ServiceModel;

namespace Chris.Blog.MsmqWorkflow.Contract
{
    [ServiceContract]
    public interface IMsmqService
    {
        [OperationContract(IsOneWay = true)]
        void StartProcess(StartProcessRequest req);
    }
}
