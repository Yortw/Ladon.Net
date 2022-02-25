using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardDecimalTests
	{
		[TestMethod]
		public void GuardDecimal_GuardZero_ThrowsOnZero()
		{
			try
			{
				decimal test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardZero_DoesNotThrowOnNonZero()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardDecimal_GuardZero_DoesNotThrowOnNegative()
		{
			decimal test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				decimal test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				decimal test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDecimal_GuardNegative_DoesNotThrowOnZero()
		{
			decimal test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardDecimal_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardDecimal_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				decimal test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDecimal_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				decimal test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				decimal test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardRange_DoesNotThrowWithinRange()
		{
			decimal test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}






		[TestMethod]
		public void GuardDecimal_GuardZeroWithSubproperty_ThrowsOnZero()
		{
			try
			{
				decimal test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroWithSubproperty_DoesNotThrowOnNonZero()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroWithSubproperty_DoesNotThrowOnNegative()
		{
			decimal test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				decimal test = 0;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardDecimal_GuardZeroOrNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				decimal test = -1;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDecimal_GuardNegativeWithSubproperty_DoesNotThrowOnZero()
		{
			decimal test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardDecimal_GuardNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			decimal test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardDecimal_GuardNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				decimal test = -1;
				test.GuardNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardDecimal_GuardRangeWithSubproperty_ThrowsOnBelowMinimum()
		{
			try
			{
				decimal test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardRangeWithSubproperty_ThrowsOnOverMaximum()
		{
			try
			{
				decimal test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDecimal_GuardRangeWithSubproperty_DoesNotThrowWithinRange()
		{
			decimal test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

	}
}