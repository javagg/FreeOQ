using NUnit.Framework;
using System;
using FreeQuant.Data;
using FreeQuant.Series;

namespace FreeQuant.Tests
{
    [TestFixture()]
    public class BarSeriesTest
    {
		BarSeries bs;

		[SetUp]
		public void SetUp()
		{
			bs = new BarSeries("dsName");
		}

		 [Test()]
        public void TestCase()
        {
			Bar bar1 = new Bar();
			Bar bar2 = new Bar();
			bs.Add(bar1);
			bs.Add(bar2);
			Assert.AreEqual(1, bs.RealCount);
			Assert.AreSame(bar2, bs[0]);
			bs.Clear();
			Assert.AreEqual(0, bs.RealCount);

			DateTime dt1 = new DateTime(2014,1,1,12,12,12);
			Bar bar3 = new Bar(dt1,10,10,10,10,100,100);
			bs.Add(bar3);
			Assert.AreSame(bar3, bs[dt1]);
			bs.Clear();
			bs.Add(bar3);
			Assert.AreSame(bar3, bs[dt1, EIndexOption.Next]);
		}
    }
}

