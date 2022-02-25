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
				test.GuardRange(5, 10, nameof(test));
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
				test.GuardRange(5, 10, nameof(test));
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
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}





		[TestMethod]
		public void GuardShort_GuardZeroWithSubproperty_ThrowsOnZero()
		{
			try
			{
				short test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardZeroWithSubproperty_DoesNotThrowOnNonZero()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardShort_GuardZeroWithSubproperty_DoesNotThrowOnNegative()
		{
			short test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardShort_GuardZeroOrNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				short test = 0;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardZeroOrNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardShort_GuardZeroOrNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				short test = -1;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardShort_GuardNegativeWithSubproperty_DoesNotThrowOnZero()
		{
			short test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardShort_GuardNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			short test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardShort_GuardNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				short test = -1;
				test.GuardNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardShort_GuardRangeWithSubproperty_ThrowsOnBelowMinimum()
		{
			try
			{
				short test = 1;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardRangeWithSubproperty_ThrowsOnOverMaximum()
		{
			try
			{
				short test = 15;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardShort_GuardRangeWithSubproperty_DoesNotThrowWithinRange()
		{
			short test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), "Subproperty", 5, 10));
		}

	}
}