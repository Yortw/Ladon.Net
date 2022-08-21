using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ladon.Tests
{
	[TestClass]
	public class GuardDateTimeOffsetTests
	{
		[TestMethod]
		public void GuardDateTimeOffset_GuardAfter_ThrowsOnLaterDate()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
				test.GuardAfter(new DateTimeOffset(new DateTime(2020, 01, 01)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		public void GuardDateTimeOffset_GuardAfter_ThrowsOnLaterTime()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26, 13, 0, 0));
				test.GuardAfter(new DateTimeOffset(new DateTime(2022, 02, 26, 13, 15, 0)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardAfter_DoesNotThrowForSameDate()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardAfter(new DateTimeOffset(new DateTime(2022, 02, 26)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardAfter_DoesNotThrowForSameDateAndTime()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26, 14, 15, 0));
			test.GuardAfter(new DateTimeOffset(new DateTime(2022, 02, 26, 14, 15, 0)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardAfter_DoesNotThrowForEalierDate()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2021, 02, 25));
			test.GuardAfter(new DateTimeOffset(new DateTime(2022, 02, 26)));
		}


		[TestMethod]
		public void GuardDateTimeOffset_GuardBefore_ThrowsOnEarlierDate()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2020, 01, 01));
				test.GuardBefore(new DateTimeOffset(new DateTime(2022, 02, 26)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		public void GuardDateTimeOffset_GuardBefore_ThrowsOnEarlierTime()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26, 13, 15, 0));
				test.GuardBefore(new DateTimeOffset(new DateTime(2022, 02, 26, 13, 0, 0)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardBefore_DoesNotThrowForSameDate()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardBefore(new DateTimeOffset(new DateTime(2022, 02, 26)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardBefore_DoesNotThrowForSameDateAndTime()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26, 14, 15, 0));
			test.GuardBefore(new DateTimeOffset(new DateTime(2022, 02, 26, 14, 15, 0)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardBefore_DoesNotThrowForEalierDate()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardBefore(new DateTimeOffset(new DateTime(2021, 02, 25)));
		}




		[TestMethod]
		public void GuardDateTimeOffset_GuardRange_DoesNotThrowWhenInRange()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardRange(new DateTimeOffset(new DateTime(2021, 02, 25)), new DateTimeOffset(new DateTime(2023, 02, 25)));
		}

		public void GuardDateTimeOffset_GuardRange_DoesNotThrowWhenEqualToMinimum()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardRange(new DateTimeOffset(new DateTime(2022, 02, 26)), new DateTimeOffset(new DateTime(2023, 02, 25)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardRange_DoesNotThrowWhenEqualToMaximum()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardRange(new DateTimeOffset(new DateTime(2021, 02, 25)), new DateTimeOffset(new DateTime(2022, 02, 26)));
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardRange_ThrowsOnEarlierDate()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2020, 01, 01));
				test.GuardRange(new DateTimeOffset(new DateTime(2022, 02, 26)), new DateTimeOffset(new DateTime(2023, 02, 26)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardRange_ThrowsOnLaterDate()
		{
			try
			{
				DateTimeOffset test = new DateTimeOffset(new DateTime(2024, 01, 01));
				test.GuardRange(new DateTimeOffset(new DateTime(2022, 02, 26)), new DateTimeOffset(new DateTime(2023, 02, 26)));
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}



		[TestMethod]
		public void GuardDateTimeOffset_GuardMin_ThrowsOnMinDate()
		{
			try
			{
				DateTimeOffset test = DateTimeOffset.MinValue;
				test.GuardMin();
				Assert.Fail("Did not throw argument null exception");
			}
			catch (ArgumentException ae)
			{
				Assert.AreEqual("test", ae.ParamName);
			}
		}

		[TestMethod]
		public void GuardDateTimeOffset_GuardMin_DoesNotThrowsOnNonMinDate()
		{
			DateTimeOffset test = new DateTimeOffset(new DateTime(2022, 02, 26));
			test.GuardMin();
		}



	}
}