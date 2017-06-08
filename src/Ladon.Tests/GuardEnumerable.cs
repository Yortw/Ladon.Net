using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardEnumerableTests
	{
		[TestMethod]
		public void GuardEnumerable_GuardNullOrEmpty_ThrowsOnNull()
		{
			try
			{
				List<string> test = null;
				test.GuardNullOrEmpty(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardEnumerable_GuardNullOrEmpty_ThrowsOnEmpty()
		{
			try
			{
				List<string> test = new List<string>(0);
				test.GuardNullOrEmpty(nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardEnumerable_GuardNullOrEmpty_DoesNotThrowOnNonEmpty()
		{
			List<string> test = new List<string>(1);
			test.Add("Test");
			Assert.AreEqual(test, test.GuardNullOrEmpty(nameof(test)));
		}

	}
}