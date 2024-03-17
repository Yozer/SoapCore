using System.ServiceModel;

namespace SoapCore.Tests.Wsdl.Services;

[ServiceContract]
public interface INullableArrayOfService
{
	[OperationContract]
	void Method(string[] s, int[] i);
}

public class NullableArrayOfService : INullableArrayOfService
{
	public void Method(string[] s, int[] i)
	{
	}
}
