using System;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class DivideTwoIntegersTest
	{
		DivideTwoIntegers divideTwoInteger = new DivideTwoIntegers();

		[TestMethod]
		public void Divide()
		{
			Assert.AreEqual(divideTwoInteger.Divide(82, 7), 82 / 7);
			Assert.AreEqual(divideTwoInteger.Divide(-82, 7), -82 / 7);
			Assert.AreEqual(divideTwoInteger.Divide(82, -7), 82 / -7);
			Assert.AreEqual(divideTwoInteger.Divide(-82, -7), -82 / -7);
			Assert.AreEqual(divideTwoInteger.Divide(0, 7), 0);
			Assert.AreEqual(divideTwoInteger.Divide(0, -7), 0);
			Assert.AreEqual(divideTwoInteger.Divide(1, 0), int.MaxValue);
			Assert.AreEqual(divideTwoInteger.Divide(-1, 0), int.MaxValue);
			Assert.AreEqual(divideTwoInteger.Divide(-1010369383, -2147483648), -1010369383 / -2147483648);
			Assert.AreEqual(divideTwoInteger.Divide(-2147483648, -1), int.MaxValue);
			Assert.AreEqual(divideTwoInteger.Divide(-2147483648, 1), int.MinValue / 1);
		}
	}
}
