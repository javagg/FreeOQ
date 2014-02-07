using NUnit.Framework;
using System;
using FreeQuant.Data;

namespace FreeQuant.Tests
{
    [TestFixture()]
    public class BarArrayTest
    {
        
		private BarArray ba;
		[SetUp]
		public void SetUp()
		{
			ba = new BarArray();
		}

		[Test()]
   	public void TestCase()
        {
			Bar bar = new Bar();
			ba.Add(bar);
			Assert.AreEqual(1, ba.Count);
			Assert.AreSame(ba[0], bar);
			Assert.AreEqual(ba[0].GetType(), typeof(Bar));
			ba.Remove(bar);
			Assert.AreEqual(0, ba.Count);
        }
    }
}

