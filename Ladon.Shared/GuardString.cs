using System;
using System.Collections.Generic;
using System.Text;

namespace Ladon
{
#pragma warning disable 1591
	public static partial class GuardString
#pragma warning restore 1591
	{

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is either null or an empty string.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is an empty string (zero length).</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static string GuardNullOrEmpty([ValidatedNotNull] this string argument, string argumentName)
		{
			if (argument == null) throw new ArgumentNullException(argumentName);
			if (argument.Length == 0) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.StringArgumentCannotBeEmpty, argumentName), argumentName);

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null, an empty string, or contains only whitespace characters.
		/// </summary>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is an empty string (zero length) or contains only white space characters.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static string GuardNullOrWhiteSpace([ValidatedNotNull] this string argument, string argumentName)
		{
			if (argument == null) throw new ArgumentNullException(argumentName);
			if (argument.Length == 0) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.StringArgumentCannotBeEmpty, argumentName), argumentName);
			if (String.IsNullOrWhiteSpace(argument)) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.StringCannotBeWhitespace, argumentName), argumentName);

			return argument;
		}

		/// <summary>
		/// Throws an <see cref="System.ArgumentException"/> if <paramref name="argument"/> has a length longer than <paramref name="maximumLength"/>.
		/// </summary>
		/// <param name="argument">The string to check the length of.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="maximumLength">The maximum allowed length of the string.</param>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is non-null and has a length greater than <paramref name="maximumLength"/>.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static string GuardLength(this string argument, string argumentName, int maximumLength)
		{
			if ((argument?.Length ?? 0) > maximumLength) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.StringTooLong, argumentName, maximumLength), argumentName);

			return argument;
		}

		/// <summary>
		/// Throws an <see cref="System.ArgumentException"/> if <paramref name="argument"/> has a length outside the range specified by <paramref name="minimumLength"/> and <paramref name="maximumLength"/>.
		/// </summary>
		/// <param name="argument">The string to check the length of.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <param name="minimumLength">The minimum allowed length of the string.</param>
		/// <param name="maximumLength">The maximum allowed length of the string.</param>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is non-null and outside teh specified range.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static string GuardLength(this string argument, string argumentName, int minimumLength, int maximumLength)
		{
			if (argument == null) return argument;
			if (argument.Length < minimumLength || argument.Length > maximumLength) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.StringLengthOutOfRange, argumentName, minimumLength, maximumLength), argumentName);

			return argument;
		}

	}
}