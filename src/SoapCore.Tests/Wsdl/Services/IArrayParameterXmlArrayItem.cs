using System.ServiceModel;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services;

[ServiceContract]
public interface IArrayParameterXmlArrayItem
{
	[OperationContract]
	void Method([XmlArrayItem("Item")] int[] i);
}

public class ArrayParameterXmlArrayItem : IArrayParameterXmlArrayItem
{
	public void Method(int[] i)
	{
	}
}
