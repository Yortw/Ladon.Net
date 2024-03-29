using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardDoubleTests
	{
		[TestMethod]
		public void GuardDouble_GuardZero_ThrowsOnZero()
		{
			try
			{
				double test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDouble_GuardZero_DoesNotThrowOnNonZero()
		{
			double test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardDouble_GuardZero_DoesNotThrowOnNegative()
		{
			double test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardDouble_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				double test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDouble_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			double test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardDouble_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				double test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDouble_GuardNegative_DoesNotThrowOnZero()
		{
			double test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardDouble_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			double test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardDouble_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				double test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDouble_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				double test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDouble_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				double test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDouble_GuardRange_DoesNotThrowWithinRange()
		{
			double test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

	}
}