using System;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class ImplementStrStrTest
	{
		ImplementStrStr implementStrStr = new ImplementStrStr();

		[TestMethod]
		public void StrStr()
		{
			Assert.AreEqual(implementStrStr.StrStr("abcd", "bc"), "abcd".IndexOf("bc"));
			Assert.AreEqual(implementStrStr.StrStr("abcd", "bce"), "abcd".IndexOf("bce"));
			Assert.AreEqual(implementStrStr.StrStr("a", "bc"), "a".IndexOf("bc"));
			Assert.AreEqual(implementStrStr.StrStr("", "bc"), "".IndexOf("bc"));
			Assert.AreEqual(implementStrStr.StrStr("a", ""), "a".IndexOf(""));
			Assert.AreEqual(implementStrStr.StrStr("a", "a"), "a".IndexOf("a"));
			Assert.AreEqual(implementStrStr.StrStr("ba", "a"), "ba".IndexOf("a"));
			Assert.AreEqual(implementStrStr.StrStr("mississippi", "issipi"), "mississippi".IndexOf("issipi"));
		}
	}
}
