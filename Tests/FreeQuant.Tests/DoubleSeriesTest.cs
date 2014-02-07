using NUnit.Framework;
using System;
using FreeQuant.Series;

namespace FreeQuant.Tests
{
	[TestFixture()]
	public class DoubleSeriesTest
	{
		DoubleSeries ds;

		[SetUp]
		public void SetUp()
		{
			ds = new DoubleSeries("dsName");
		}

		[Test()]
		public void TestCase()
		{
			Assert.AreEqual("", ds.Title);
		}
	}
}

