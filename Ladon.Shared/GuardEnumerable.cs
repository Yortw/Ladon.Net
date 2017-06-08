using System;
using System.Collections.Generic;
using System.Text;

namespace Ladon
{
#pragma warning disable 1591
	public static partial class GuardEnumerable
#pragma warning restore 1591
	{

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or contains zero items.
		/// </summary>
		/// <typeparam name="T">The type of value contained in the collection.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> contains zero items.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static ICollection<T> GuardNullOrEmpty<T>([ValidatedNotNull] this ICollection<T> argument, string argumentName)
		{
			if (argument == null) throw new ArgumentNullException(argumentName);
			if (argument.Count == 0) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.EnumerableCannotBeEmpty, argumentName), argumentName);

			return argument;
		}

		/// <summary>
		/// Throws an appropriate exception if <paramref name="argument"/> is null or contains zero items.
		/// </summary>
		/// <typeparam name="T">The type of value contained in the array.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the exception that is thrown.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> contains zero items.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T[] GuardNullOrEmpty<T>([ValidatedNotNull] this T[] argument, string argumentName)
		{
			if (argument == null) throw new ArgumentNullException(argumentName);
			if (argument.Length == 0) throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.EnumerableCannotBeEmpty, argumentName), argumentName);

			return argument;
		}

	}
}