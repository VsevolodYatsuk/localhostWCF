using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet(UriTemplate = "GetData?value={value}", ResponseFormat = WebMessageFormat.Json)]
    string GetData(int value);

    [OperationContract]
    [WebInvoke(UriTemplate = "GetDataUsingDataContract", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    CompositeType GetDataUsingDataContract(CompositeType composite);
}

[DataContract]
public class CompositeType
{
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}
