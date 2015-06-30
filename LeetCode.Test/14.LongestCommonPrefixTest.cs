using System;
using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
	[TestClass]
	public class LongestCommonPrefixTest
	{
		LongestCommonPrefix_ longestCommonPrefix = new LongestCommonPrefix_();

		[TestMethod]
		public void LongestCommonPrefix()
		{
			Assert.AreEqual(longestCommonPrefix
				.LongestCommonPrefix(new string[]
				{
					"abcde",
					"abcee",
					"ab",
					"abdec"
				})
				, "ab");
			Assert.AreEqual(longestCommonPrefix
				.LongestCommonPrefix(new string[]
				{
					"a",
					"b"
				})
				, "");
			Assert.AreEqual(longestCommonPrefix
				.LongestCommonPrefix(new string[]
				{
					
				})
				, String.Empty);
		}
	}
}
