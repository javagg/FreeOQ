using NUnit.Framework;
using System;
using FreeQuant.Series;

namespace FreeQuant.Tests
{
	[TestFixture()]
	public class TimeSeriesTest
	{
		TimeSeries ts;

		[SetUp]
		public void SetUp()
		{
			ts = new TimeSeries("tsName", "tsTitle");
		}

		[Test()]
		public void TestCreation()
		{
			Assert.IsNotNull(ts);
		}
		[Test()]
		public void TestAdd()
		{
			object obj1 = new Object();
			DateTime dt = new DateTime(2014,1,1,8,8,8);
			ts.Add(dt, obj1);
			Assert.AreSame(obj1, ts[dt]);
			Assert.AreSame(obj1, ts[0]);
		}
	}
}

