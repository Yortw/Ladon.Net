using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
				System.Diagnostics.Trace.WriteLine(ae.StackTrace);
			}
		}

		[TestMethod]
		public void Guard_GuardNull_UsesCallerArgumentExpression()
		{
			try
			{
				object test = null;
				test.GuardNull();
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentNullException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
				System.Diagnostics.Trace.WriteLine(ae.StackTrace);
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
				test.GuardEquals("not allowed", nameof(test));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void Guard_GuardClausesAreInlinedInReleaseMode()
		{
#if DEBUG
			Assert.Inconclusive("This test should only be run in release builds as it relies on compiler optimizations.");
#endif

			object o = null;
			try
			{
				o.GuardNull(nameof(o));
			}
			catch (ArgumentNullException ae)
			{
				System.Diagnostics.Trace.WriteLine(ae.StackTrace);
				var frames = ae.StackTrace.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
				Assert.IsFalse(frames.Where((f) => f.Contains("Ladon.Guard.GuardNull")).Any(), "GuardNull found in stack trace frame, method should have been inlined.");
				Assert.IsTrue(frames.Length < 3);
			}
		}

	}
}