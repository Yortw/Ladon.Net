using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardNullableIntTests
	{
		[TestMethod]
		public void GuardNullableInt_GuardNull_ThrowsOnNull()
		{
			try
			{
				int? test = null;
				test.GuardNull(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNull_DoesNotThrowOnNonNull()
		{
			int? test = 3;
			Assert.AreEqual(test, test.GuardNull(nameof(test)));
		}


		[TestMethod]
		public void GuardNullableInt_GuardNullOrZero_ThrowsOnNull()
		{
			try
			{
				int? test = null;
				test.GuardNullOrZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullOrZero_ThrowsOnZero()
		{
			try
			{
				int? test = 0;
				test.GuardNullOrZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullOrZero_DoesNotThrowOnNonZeroNonNull()
		{
			int? test = 2;
			Assert.AreEqual(test, test.GuardNullOrZero(nameof(test)));
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullOrZero_DoesNotThrowOnNegative()
		{
			int? test = -1;
			Assert.AreEqual(test, test.GuardNullOrZero(nameof(test)));
		}


		[TestMethod]
		public void GuardNullableInt_GuardNullZeroOrNegative_ThrowsOnNull()
		{
			try
			{
				int? test = null;
				test.GuardNullZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				int? test = 0;
				test.GuardNullZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				int? test = -1;
				test.GuardNullZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardNullZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			int? test = 1;
			Assert.AreEqual(test, test.GuardNullZeroOrNegative(nameof(test)));
		}



		[TestMethod]
		public void GuardNullableInt_GuardNegative_DoesNotThrowOnNull()
		{
			int? test = null;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardNullableInt_GuardNegative_DoesNotThrowOnZero()
		{
			int? test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardNullableInt_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			int? test = 1;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardNullableInt_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				int? test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardNullableInt_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				int? test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				int? test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardNullableInt_GuardRange_DoesNotThrowWithinRange()
		{
			int? test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

		[TestMethod]
		public void GuardNullableInt_GuardRange_DoesNotThrowForNull()
		{
			int? test = null;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

	}
}