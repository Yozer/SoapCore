using System.ServiceModel;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services;

[ServiceContract]
public interface IArrayParameterXmlArray
{
	[OperationContract]
	void Method([XmlArray("Test")] int[] i);
}

public class ArrayParameterXmlArray : IArrayParameterXmlArray
{
	public void Method(int[] i)
	{
	}
}
