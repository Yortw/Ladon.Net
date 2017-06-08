using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardStringTests
	{
		[TestMethod]
		public void GuardString_GuardNullOrEmpty_ThrowsOnNull()
		{
			try
			{
				string test = null;
				test.GuardNullOrEmpty(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardNullOrEmpty_ThrowsOnEmpty()
		{
			try
			{
				string test = "";
				test.GuardNullOrEmpty(nameof(test));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardNullOrEmpty_DoesNotThrowOnNonNullNonEmpty()
		{
			string test = "test string";
			Assert.AreEqual(test, test.GuardNull(nameof(test)));
		}

		[TestMethod]
		public void GuardString_GuardNullOrWhiteSpace_ThrowsOnNull()
		{
			try
			{
				string test = null;
				test.GuardNullOrWhiteSpace(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardNullOrWhiteSpace_ThrowsOnEmpty()
		{
			try
			{
				string test = "";
				test.GuardNullOrWhiteSpace(nameof(test));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardNullOrWhiteSpace_ThrowsOnWhitespace()
		{
			try
			{
				string test = "  \t ";
				test.GuardNullOrWhiteSpace(nameof(test));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardNullOrWhiteSpace_DoesNotThrowOnNonNullNonEmpty()
		{
			string test = "test string";
			Assert.AreEqual(test, test.GuardNullOrWhiteSpace(nameof(test)));
		}

		[TestMethod]
		public void GuardString_GuardLength_DoesNotThrowOnNull()
		{
			string test = null;
			Assert.AreEqual(test, test.GuardLength(nameof(test), 10));
		}

		[TestMethod]
		public void GuardString_GuardLength_DoesNotThrowUnderMaxLength()
		{
			string test = "test";
			Assert.AreEqual(test, test.GuardLength(nameof(test), 10));
		}

		[TestMethod]
		public void GuardString_GuardLength_ThrowsWhenOverMaxLength()
		{
			try
			{
				string test = "test test test test test test";
				Assert.AreEqual(test, test.GuardLength(nameof(test), 10));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardLengthRange_ThrowsWhenOverMaxLength()
		{
			try
			{
				string test = "test test test test test test";
				Assert.AreEqual(test, test.GuardLength(nameof(test), 5, 10));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardLengthRange_ThrowsWhenUnderMinLength()
		{
			try
			{
				string test = "t";
				Assert.AreEqual(test, test.GuardLength(nameof(test), 5, 10));
				Assert.Fail("Did not throw argument exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardString_GuardLengthRange_DoesNotThrowOnNull()
		{
			string test = null;
			Assert.AreEqual(test, test.GuardLength(nameof(test), 5, 10));
		}

		[TestMethod]
		public void GuardString_GuardLengthRange_DoesNotThrowOnWhenLengthInRange()
		{
			string test = "test 123";
			Assert.AreEqual(test, test.GuardLength(nameof(test), 5, 10));
		}


	}
}