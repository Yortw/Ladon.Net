using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Ladon
{
	/// <summary>
	/// Provides (extension) methods for guarding against bad method inputs.
	/// </summary>
	public static partial class Guard
	{

		/// <summary>
		/// Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
		/// </summary>
		/// <typeparam name="T">The type of value to be null checked, must be a reference type.</typeparam>
		/// <param name="argument">The value to null check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the <see cref="ArgumentNullException(string, string)"/> constructor if the value is null.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T GuardNull<T>([ValidatedNotNull, NotNull] this T argument, [CallerArgumentExpression("argument")] string argumentName = "") where T : class
		{
			if (argument == null) ThrowException(new ArgumentNullException(argumentName));
			
			return argument;
		}

		/// <summary>
		/// Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
		/// </summary>
		/// <typeparam name="T">The type of value to be null checked, must be a reference type.</typeparam>
		/// <param name="argument">The value to null check.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the <see cref="ArgumentNullException(string, string)"/> constructor if the value is null.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentNullException">Thrown if <paramref name="argument"/> is null.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T GuardNull<T>([ValidatedNotNull, NotNull] this T argument, string argumentName, string propertyName) where T : class
		{
			if (argument == null) ThrowException(new ArgumentNullException(argumentName + "." + propertyName));

			return argument;
		}

		/// <summary>
		/// Throws an <see cref="ArgumentException"/> if <paramref name="argument"/> is a specific value.
		/// </summary>
		/// <remarks>
		/// <para>The error message of the <see cref="ArgumentException"/> thrown will attempt to describe <paramref name="forbiddenValue"/> by calling it's ToString method.</para>
		/// </remarks>
		/// <typeparam name="T">The type of value being checked.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="forbiddenValue">The value that is not allowed.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the <see cref="ArgumentNullException(string, string)"/> constructor if the value is null.</param>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is equal to <paramref name="forbiddenValue"/>.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T GuardEquals<T>(this T argument, T forbiddenValue, [CallerArgumentExpression("argument")] string argumentName = "") where T : IEquatable<T>
		{
			if (argument != null && argument.Equals(forbiddenValue)) ThrowException(new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ValueNotAllowed, argumentName, forbiddenValue?.ToString() ?? Resources.NullPlaceholder), argumentName));
			if ((argument == null && forbiddenValue == null)) ThrowException(new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ValueNotAllowed, argumentName, forbiddenValue?.ToString() ?? Resources.NullPlaceholder), argumentName));

			return argument;
		}

		/// <summary>
		/// Throws an <see cref="ArgumentException"/> if <paramref name="argument"/> is a specific value.
		/// </summary>
		/// <remarks>
		/// <para>The error message of the <see cref="ArgumentException"/> thrown will attempt to describe <paramref name="forbiddenValue"/> by calling it's ToString method.</para>
		/// </remarks>
		/// <typeparam name="T">The type of value being checked.</typeparam>
		/// <param name="argument">The value to check.</param>
		/// <param name="forbiddenValue">The value that is not allowed.</param>
		/// <param name="argumentName">The name of the argument, passed as the paramName argument to the <see cref="ArgumentNullException(string, string)"/> constructor if the value is null.</param>
		/// <param name="propertyName">The name of a child property of the argument referred to by <paramref name="argumentName"/> that is the property really being validated.</param>
		/// <exception cref="System.ArgumentException">Thrown if <paramref name="argument"/> is equal to <paramref name="forbiddenValue"/>.</exception>
		/// <returns>The value of <paramref name="argument"/>, allowing guard clauses to be chained.</returns>
		[ContractAbbreviator]
#if SUPPORTS_AGGRESSIVEINLINING
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
		public static T GuardEquals<T>(this T argument, T forbiddenValue, string argumentName, string propertyName) where T : IEquatable<T>
		{
			if (argument != null && argument.Equals(forbiddenValue)) ThrowException(new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ValueNotAllowed, argumentName + "." + propertyName, forbiddenValue?.ToString() ?? Resources.NullPlaceholder), argumentName + "." + propertyName));
			if ((argument == null && forbiddenValue == null)) ThrowException(new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ValueNotAllowed, argumentName + "." + propertyName, forbiddenValue?.ToString() ?? Resources.NullPlaceholder), argumentName + "." + propertyName));

			return argument;
		}

		// Methods throwing exceptions are often (always?) not inlined. To allow
		// inlining of the guard clauses themselves, throw from a sub method.
		// Since the method is only called on the unhappy case, and it's static, 
		// perf hit should be minimal.
		internal static void ThrowException(Exception exception)
		{
			throw exception;
		}
	}
}