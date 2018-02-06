using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardFloatTests
	{
		[TestMethod]
		public void GuardFloat_GuardZero_ThrowsOnZero()
		{
			try
			{
				float test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardZero_DoesNotThrowOnNonZero()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardFloat_GuardZero_DoesNotThrowOnNegative()
		{
			float test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}


		[TestMethod]
		public void GuardFloat_GuardZeroOrNegative_ThrowsOnZero()
		{
			try
			{
				float test = 0;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardZeroOrNegative_DoesNotThrowOnPositiveValue()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardFloat_GuardZeroOrNegative_ThrowsOnNegative()
		{
			try
			{
				float test = -1;
				test.GuardZeroOrNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardFloat_GuardNegative_DoesNotThrowOnZero()
		{
			float test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test)));
		}

		[TestMethod]
		public void GuardFloat_GuardNegative_DoesNotThrowOnPositiveValue()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardFloat_GuardNegative_ThrowsOnNegative()
		{
			try
			{
				float test = -1;
				test.GuardNegative(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardFloat_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				float test = 1;
				test.GuardRange(nameof(test), 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				float test = 15;
				test.GuardRange(nameof(test), 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardRange_DoesNotThrowWithinRange()
		{
			float test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), 5, 10));
		}





		[TestMethod]
		public void GuardFloat_GuardZeroWithSubproperty_ThrowsOnZero()
		{
			try
			{
				float test = 0;
				test.GuardZero(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardZeroWithSubproperty_DoesNotThrowOnNonZero()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardFloat_GuardZeroWithSubproperty_DoesNotThrowOnNegative()
		{
			float test = -1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}


		[TestMethod]
		public void GuardFloat_GuardZeroOrNegativeWithSubproperty_ThrowsOnZero()
		{
			try
			{
				float test = 0;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardZeroOrNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZeroOrNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardFloat_GuardZeroOrNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				float test = -1;
				test.GuardZeroOrNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardFloat_GuardNegativeWithSubproperty_DoesNotThrowOnZero()
		{
			float test = 0;
			Assert.AreEqual(test, test.GuardNegative(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardFloat_GuardNegativeWithSubproperty_DoesNotThrowOnPositiveValue()
		{
			float test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test), "Subproperty"));
		}

		[TestMethod]
		public void GuardFloat_GuardNegativeWithSubproperty_ThrowsOnNegative()
		{
			try
			{
				float test = -1;
				test.GuardNegative(nameof(test), "Subproperty");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}


		[TestMethod]
		public void GuardFloat_GuardRangeWithSubproperty_ThrowsOnBelowMinimum()
		{
			try
			{
				float test = 1;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardRangeWithSubproperty_ThrowsOnOverMaximum()
		{
			try
			{
				float test = 15;
				test.GuardRange(nameof(test), "Subproperty", 5, 10);
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test.Subproperty", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardFloat_GuardRangeWithSubproperty_DoesNotThrowWithinRange()
		{
			float test = 8;
			Assert.AreEqual(test, test.GuardRange(nameof(test), "Subproperty", 5, 10));
		}
	}
}