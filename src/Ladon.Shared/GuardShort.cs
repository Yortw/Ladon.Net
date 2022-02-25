using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ladon
{
#pragma warning disable 1591
	public static partial class GuardShort
#pragma warning restore 1591
	{

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is zero.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardZero(this Int16 argument, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument == 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeZero, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is zero or negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is less than or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardZeroOrNegative(this Int16 argument, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument <= 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeLessThanOrEqualToZero, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is less than zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardNegative(this Int16 argument, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeNegative, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is outside of the specified range.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="minimum">The smallest allowed value.</param>
		/// <param name="maximum">The largest allowed value.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is outside the range specified.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardRange(this Int16 argument, Int16 minimum, Int16 maximum, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument < minimum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooSmall, argumentName, minimum)));
			if (argument > maximum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooLarge, argumentName, maximum)));

			return argument;
		}




		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is zero.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardZero(this Int16 argument, string argumentName, string propertyName)
		{
			if (argument == 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeZero, argumentName + "." + propertyName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is zero or negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is less than or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardZeroOrNegative(this Int16 argument, string argumentName, string propertyName)
		{
			if (argument <= 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeLessThanOrEqualToZero, argumentName + "." + propertyName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is less than zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardNegative(this Int16 argument, string argumentName, string propertyName)
		{
			if (argument < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeNegative, argumentName + "." + propertyName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is outside of the specified range.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <param name="minimum">The smallest allowed value.</param>
		/// <param name="maximum">The largest allowed value.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is outside the range specified.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static Int16 GuardRange(this Int16 argument, string argumentName, string propertyName, Int16 minimum, Int16 maximum)
		{
			if (argument < minimum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooSmall, argumentName + "." + propertyName, minimum)));
			if (argument > maximum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooLarge, argumentName + "." + propertyName, maximum)));

			return argument;
		}

	}
}