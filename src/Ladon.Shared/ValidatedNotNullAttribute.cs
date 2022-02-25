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

#if !(NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
namespace System.Diagnostics.CodeAnalysis
{
	//
	// Summary:
	//     Specifies that an output is not null even if the corresponding type allows it.
	//     Specifies that an input argument was not null when the call returns.
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	internal sealed class NotNullAttribute : Attribute
	{
		//
		// Summary:
		//     Initializes a new instance of the System.Diagnostics.CodeAnalysis.NotNullAttribute
		//     class.
		public NotNullAttribute()
		{
		}
	}
}
#endif