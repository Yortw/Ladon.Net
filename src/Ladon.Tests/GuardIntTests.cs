using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardIntTests
	{
		[TestMethod]
		public void GuardInt_GuardZero_ThrowsOnZero()
		{
			try
			{
				int test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardZero_DoesNotThrowOnNonZero()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardInt_GuardZero_DoesNotThrowOnNegative()
		{
			int test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardInt_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				int test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardInt_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				int test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardInt_GuardNegative_DoesNotThrowOnZero()
		{
			int test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardInt_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardInt_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				int test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardInt_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				int test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				int test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardRange_DoesNotThrowWithinRange()
		{
			int test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}


		[TestMethod]
		public void GuardInt_GuardZeroWithSubproperty_ThrowsOnZero()
		{
			try
			{
				int test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardZeroWithSubproperty_DoesNotThrowOnNonZero()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardInt_GuardZeroWithSubproperty_DoesNotThrowOnNegative()
		{
			int test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardInt_GuardZeroOrNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				int test = 0;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardZeroOrNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardInt_GuardZeroOrNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				int test = -1;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardInt_GuardNegativeWithSubproperty_DoesNotThrowOnZero()
		{
			int test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardInt_GuardNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			int test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardInt_GuardNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				int test = -1;
				test.GuardNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardInt_GuardRangeWithSubproperty_ThrowsOnBelowMinimum()
		{
			try
			{
				int test = 1;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardRangeWithSubproperty_ThrowsOnOverMaximum()
		{
			try
			{
				int test = 15;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardInt_GuardRangeWithSubproperty_DoesNotThrowWithinRange()
		{
			int test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), "Subproperty", 5, 10));
		}
	}
}