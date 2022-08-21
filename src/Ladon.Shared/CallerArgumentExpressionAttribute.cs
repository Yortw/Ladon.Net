#if !NET5_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Runtime.CompilerServices
{
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	internal sealed class CallerArgumentExpressionAttribute : Attribute
	{
		public CallerArgumentExpressionAttribute(string parameterName)
		{
			ParameterName = parameterName;
		}

		public string ParameterName { get; }
	}
}
#endif
