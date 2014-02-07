using NUnit.Framework;
using FreeQuant.Data;
using System;

namespace FreeQuant.Tests
{
	[TestFixture()]
	public class BarTest
	{
		private Bar bar;
		[SetUp]
		public void SetUp()
		{
			double open = 1.0;

			bar = new Bar();
		}
		[TearDown]
		public void TearDown()
		{
		}

		[Test()]
		public void TestBarCreate()
		{
		}
	}
}

