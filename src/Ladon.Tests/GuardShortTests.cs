using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardShortTests
	{
		[TestMethod]
		public void GuardShort_GuardZero_ThrowsOnZero()
		{
			try
			{
				short test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardZero_DoesNotThrowOnNonZero()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardShort_GuardZero_DoesNotThrowOnNegative()
		{
			short test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardShort_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				short test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardShort_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				short test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardShort_GuardNegative_DoesNotThrowOnZero()
		{
			short test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardShort_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardShort_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				short test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardShort_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				short test = 1;
				test.GuardRange(nameof(test), 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				short test = 15;
				test.GuardRange(nameof(test), 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardRange_DoesNotThrowWithinRange()
		{
			short test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), 5, 10));
		}

	}
}