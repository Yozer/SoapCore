using System;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IArrayParameterWithXmlElement
	{
		[OperationContract]
		void Test([XmlElement("Test")] int[] x);
	}

	public class ArrayParameterWithXmlElement : IArrayParameterWithXmlElement
	{
		public void Test([XmlElement("Test")] int[] x)
		{
		}
	}
}
