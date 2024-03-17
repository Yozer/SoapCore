using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services;

[ServiceContract]
public interface INonNullableListUsingXmlElement
{
	[OperationContract]
	void Method(NonNullableListUsingXmlElementType x);
}

public class NonNullableListUsingXmlElement : INonNullableListUsingXmlElement
{
	public void Method(NonNullableListUsingXmlElementType x)
	{
	}
}

public class NonNullableListUsingXmlElementType
{
	[XmlElement("Profile", IsNullable = false)]
	public List<NonNullableListUsingXmlElementInnerType> SpaProfiles { get; set; }

	[XmlElement("Company", IsNullable = true)]
	public List<NonNullableListUsingXmlElementInnerType> Companies { get; set; }

	[XmlElement("Other")]
	public List<NonNullableListUsingXmlElementInnerType> Others { get; set; }
}

public class NonNullableListUsingXmlElementInnerType
{
	public string Name { get; set; }
}
