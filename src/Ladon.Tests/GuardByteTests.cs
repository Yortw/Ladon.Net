using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardByteTests
	{
		[TestMethod]
		public void GuardByte_GuardZero_ThrowsOnZero()
		{
			try
			{
				byte test = 0;
				test.GuardZero(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardByte_GuardZero_DoesNotThrowOnNonZero()
		{
			byte test = 1;
			Assert.AreEqual(test, test.GuardZero(nameof(test)));
		}

		[TestMethod]
		public void GuardByte_GuardRange_ThrowsOnBelowMinimum()
		{
			try
			{
				byte test = 1;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardByte_GuardRange_ThrowsOnOverMaximum()
		{
			try
			{
				byte test = 15;
				test.GuardRange(5, 10, nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentOutOfRangeException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardByte_GuardRange_DoesNotThrowWithinRange()
		{
			byte test = 8;
			Assert.AreEqual(test, test.GuardRange(5, 10, nameof(test)));
		}

	}
}