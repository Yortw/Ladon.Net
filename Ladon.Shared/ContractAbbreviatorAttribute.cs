using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Ladon
{
	/// <summary>
	/// Indicates to code contracts the method this attribute is applied to contains contracts for the calling method.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractAbbreviatorAttribute : global::System.Attribute
	{
	}
}