using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardLongTests
	{
		[TestMethod]
		public void GuardLong_GuardZero_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardZero_DoesNotThrowOnNonZero()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardLong_GuardZero_DoesNotThrowOnNegative()
		{
			long test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardLong_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardLong_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				long test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardLong_GuardNegative_DoesNotThrowOnZero()
		{
			long test = 0;
			test.GuardNegative(nameof(test));
		}

		[TestMethod]
		public void GuardLong_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardLong_GuardNegative_ThrowsOnNegative()
		{
			long test = -1;
			try
			{
				Assert.AreEqual(test, test.GuardNegative(nameof(test)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardLong_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				long test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				long test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardRange_DoesNotThrowWithinRange()
		{
			long test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

	}
}