using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardDateTimeTests
	{
		[TestMethod]
		public void GuardDateTime_GuardAfter_ThrowsOnLaterDate()
		{
			try
			{
				DateTime test = new DateTime(2022, 02, 26);
				test.GuardAfter(new DateTime(2020, 01, 01));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		public void GuardDateTime_GuardAfter_ThrowsOnLaterTime()
		{
			try
			{
				DateTime test = new DateTime(2022, 02, 26, 13, 0, 0);
				test.GuardAfter(new DateTime(2022, 02, 26, 13, 15, 0));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTime_GuardAfter_DoesNotThrowForSameDate()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardAfter(new DateTime(2022, 02, 26));
		}

		[TestMethod]
		public void GuardDateTime_GuardAfter_DoesNotThrowForSameDateAndTime()
		{
			DateTime test = new DateTime(2022, 02, 26, 14, 15, 0);
			test.GuardAfter(new DateTime(2022, 02, 26, 14, 15, 0));
		}

		[TestMethod]
		public void GuardDateTime_GuardAfter_DoesNotThrowForEalierDate()
		{
			DateTime test = new DateTime(2021, 02, 25);
			test.GuardAfter(new DateTime(2022, 02, 26));
		}


		[TestMethod]
		public void GuardDateTime_GuardBefore_ThrowsOnEarlierDate()
		{
			try
			{
				DateTime test = new DateTime(2020, 01, 01);
				test.GuardBefore(new DateTime(2022, 02, 26));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		public void GuardDateTime_GuardBefore_ThrowsOnEarlierTime()
		{
			try
			{
				DateTime test = new DateTime(2022, 02, 26, 13, 15, 0);
				test.GuardBefore(new DateTime(2022, 02, 26, 13, 0, 0));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTime_GuardBefore_DoesNotThrowForSameDate()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardBefore(new DateTime(2022, 02, 26));
		}

		[TestMethod]
		public void GuardDateTime_GuardBefore_DoesNotThrowForSameDateAndTime()
		{
			DateTime test = new DateTime(2022, 02, 26, 14, 15, 0);
			test.GuardBefore(new DateTime(2022, 02, 26, 14, 15, 0));
		}

		[TestMethod]
		public void GuardDateTime_GuardBefore_DoesNotThrowForEalierDate()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardBefore(new DateTime(2021, 02, 25));
		}




		[TestMethod]
		public void GuardDateTime_GuardRange_DoesNotThrowWhenInRange()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardRange(new DateTime(2021, 02, 25), new DateTime(2023, 02, 25));
		}

		public void GuardDateTime_GuardRange_DoesNotThrowWhenEqualToMinimum()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardRange(new DateTime(2022, 02, 26), new DateTime(2023, 02, 25));
		}

		[TestMethod]
		public void GuardDateTime_GuardRange_DoesNotThrowWhenEqualToMaximum()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardRange(new DateTime(2021, 02, 25), new DateTime(2022, 02, 26));
		}

		[TestMethod]
		public void GuardDateTime_GuardRange_ThrowsOnEarlierDate()
		{
			try
			{
				DateTime test = new DateTime(2020, 01, 01);
				test.GuardRange(new DateTime(2022, 02, 26), new DateTime(2023, 02, 26));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTime_GuardRange_ThrowsOnLaterDate()
		{
			try
			{
				DateTime test = new DateTime(2024, 01, 01);
				test.GuardRange(new DateTime(2022, 02, 26), new DateTime(2023, 02, 26));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}



		[TestMethod]
		public void GuardDateTime_GuardMin_ThrowsOnMinDate()
		{
			try
			{
				DateTime test = DateTime.MinValue;
				test.GuardMin();
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTime_GuardMin_DoesNotThrowsOnNonMinDate()
		{
			DateTime test = new DateTime(2022, 02, 26);
			test.GuardMin();
		}



	}
}