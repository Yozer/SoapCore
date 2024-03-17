using System.ServiceModel;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services;

[ServiceContract]
public interface IXmlElementNullableService
{
	[OperationContract]
	TypeWithXmlElementNullableString Method(TypeWithXmlElementNullableString argument);
}

public class XmlElementNullableService : IXmlElementNullableService
{
	public TypeWithXmlElementNullableString Method(TypeWithXmlElementNullableString argument)
	{
		return new TypeWithXmlElementNullableString();
	}
}

public class TypeWithXmlElementNullableString
{
	[XmlElement(IsNullable = true)]
	public string StringProperty { get; set; }
}
