using System;
using System.Collections.Generic;
using System.Text;

namespace Ladon
{
	/// <summary>
	/// Tells code analysis the parameter this attribute is applied to has been checked to ensure it is not null.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class ValidatedNotNullAttribute : Attribute
	{
	}
}