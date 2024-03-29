using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ladon
{
#pragma warning disable 1591
	public static partial class GuardDateTimeOffset
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
		public static DateTimeOffset GuardMin(this DateTimeOffset argument, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument == DateTimeOffset.MinValue) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeZero, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is before <paramref name="minimum"/>.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="minimum">The minimum allowed value for <paramref name="argument"/>.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is before <paramref name="minimum"/>.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static DateTimeOffset GuardBefore(this DateTimeOffset argument, DateTimeOffset minimum, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			return GuardRange(argument, minimum, DateTimeOffset.MaxValue, argumentName);
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is after <paramref name="maximum"/>.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="maximum">The maximum allowed value for <paramref name="argument"/>.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is after <paramref name="maximum"/>.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static DateTimeOffset GuardAfter(this DateTimeOffset argument, DateTimeOffset maximum, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			return GuardRange(argument, DateTimeOffset.MinValue, maximum, argumentName);
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is outside of the specified range.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="minimum">The smallest allowed value.</param>
		/// <param name="maximum">The largest allowed value.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> outside the range specified.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static DateTimeOffset GuardRange(this DateTimeOffset argument, DateTimeOffset minimum, DateTimeOffset maximum, [CallerArgumentExpression("argument")] string argumentName = "")
		{
			if (argument < minimum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooSmall, argumentName, minimum)));
			if (argument > maximum) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooLarge, argumentName, maximum)));

			return argument;
		}

	}
}