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
		public void GuardLong_GuardNegative_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardLong_GuardNegative_DoesNotThrowOnNegative()
		{
			long test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardLong_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				long test = 1;
				test.GuardRange(nameof(test), 5, 10);
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
				test.GuardRange(nameof(test), 5, 10);
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
			Assert.AreEqual(test, test.GuardRange(nameof(test), 5, 10));
		}



		[TestMethod]
		public void GuardLong_GuardZeroWithSubproperty_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardZeroWithSubproperty_DoesNotThrowOnNonZero()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardLong_GuardZeroWithSubproperty_DoesNotThrowOnNegative()
		{
			long test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardLong_GuardZeroOrNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardZeroOrNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardLong_GuardZeroOrNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				long test = -1;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardLong_GuardNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				long test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			long test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardLong_GuardNegativeWithSubproperty_DoesNotThrowOnNegative()
		{
			long test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardLong_GuardRangeWithSubproperty_ThrowsOnBelowMinimum()
		{
			try
			{
				long test = 1;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardRangeWithSubproperty_ThrowsOnOverMaximum()
		{
			try
			{
				long test = 15;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardLong_GuardRangeWithSubproperty_DoesNotThrowWithinRange()
		{
			long test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), "Subproperty", 5, 10));
		}

	}
}