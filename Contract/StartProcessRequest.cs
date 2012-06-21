using System.Runtime.Serialization;

namespace Chris.Blog.MsmqWorkflow.Contract
{
    [DataContract]
    public class StartProcessRequest
    {
        [DataMember]
        public string MessageText { get; set; }
    }
}
