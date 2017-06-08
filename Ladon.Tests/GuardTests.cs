using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardTests
	{
		[TestMethod]
		public void Guard_GuardNull_ThrowsOnNull()
		{
			try
			{
				object test = null;
				test.GuardNull(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void Guard_GuardNull_DoesNotThrowOnNonNull()
		{
			object test = new object();
			Assert.AreEqual(test, test.GuardNull(nameof(test)));
		}

		[TestMethod]
		public void Guard_GuardEquals_DoesNotThrowOnNonEqual()
		{
			string test = "test me";
			Assert.AreEqual(test, test.GuardEquals(nameof(test), "not allowed"));
		}

		[TestMethod]
		public void Guard_GuardEquals_ThrowsOnEquals()
		{
			try
			{
				string test = "not allowed";
				test.GuardEquals(nameof(test), "not allowed");
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

	}
}