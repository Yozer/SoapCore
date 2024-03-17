using System;

namespace SoapCore.ServiceModel;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class SoapHeaderAttribute : Attribute
{
}
