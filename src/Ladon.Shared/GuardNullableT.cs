using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon
{
#pragma warning disable 1591
	public static partial class GuardNullableT
#pragma warning restore 1591
	{

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null.
		/// </summary>
		/// <typeparam name="T">The (sub)type of nullable value to test.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNull<T>([ValidatedNotNull] this T? argument, string argumentName) where T : struct
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or zero.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNullOrZero<T>([ValidatedNotNull] this T? argument, string argumentName) where T : struct, IComparable
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName));
			if (argument.Value.CompareTo(0) == 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeZero, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null, zero or negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null or less than or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNullZeroOrNegative<T>([ValidatedNotNull] this T? argument, string argumentName) where T : struct, IComparable
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName));
			if (argument.Value.CompareTo(0) <= 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeLessThanOrEqualToZero, argumentName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is less than zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNegative<T>(this T? argument, string argumentName) where T : struct, IComparable
		{
			if (argument == null) return argument;
			if (argument.Value.CompareTo(0) < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeNegative, argumentName)));

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
		public static T? GuardRange<T>(this T? argument, string argumentName, T minimum, T maximum) where T : struct, IComparable
		{
			if (argument == null) return argument;
			if (argument.Value.CompareTo(minimum) < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooSmall, argumentName, minimum)));
			if (argument.Value.CompareTo(maximum) > 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooLarge, argumentName, maximum)));

			return argument;
		}





		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null.
		/// </summary>
		/// <typeparam name="T">The (sub)type of nullable value to test.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNull<T>([ValidatedNotNull] this T? argument, string argumentName, string propertyName) where T : struct
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName + "." + propertyName));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or zero.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNullOrZero<T>([ValidatedNotNull] this T? argument, string argumentName, string propertyName) where T : struct, IComparable
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName + "." + propertyName));
			if (argument.Value.CompareTo(0) == 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeZero, argumentName + "." + propertyName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null, zero or negative.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">Thrown if <paramref name="argument"/> is null or less than or equal to zero.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T? GuardNullZeroOrNegative<T>([ValidatedNotNull] this T? argument, string argumentName, string propertyName) where T : struct, IComparable
		{
			if (argument == null) Guard.ThrowException(new ArgumentNullException(argumentName + "." + propertyName));
			if (argument.Value.CompareTo(0) <= 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeLessThanOrEqualToZero, argumentName + "." + propertyName)));

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or negative.
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
		public static T? GuardNegative<T>(this T? argument, string argumentName, string propertyName) where T : struct, IComparable
		{
			if (argument == null) return argument;
			if (argument.Value.CompareTo(0) < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberCannotBeNegative, argumentName + "." + propertyName)));

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
		public static T? GuardRange<T>(this T? argument, string argumentName, string propertyName, T minimum, T maximum) where T : struct, IComparable
		{
			if (argument == null) return argument;
			if (argument.Value.CompareTo(minimum) < 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooSmall, argumentName + "." + propertyName, minimum)));
			if (argument.Value.CompareTo(maximum) > 0) Guard.ThrowException(new ArgumentOutOfRangeException(argumentName + "." + propertyName, argument, String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.NumberTooLarge, argumentName + "." + propertyName, maximum)));

			return argument;
		}

	}
}